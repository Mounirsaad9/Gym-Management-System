using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Models;
using clsLogger;

namespace clsDataAccess
{
    public class clsSaleData
    {

        public enum enSaleDataProduct
        {
            Success,
            InsufficientStock,
            Failed
        }

        public static enSaleDataProduct AddSale(int? memberID, int userID, decimal totalAmount, List<clsSaleItemModel> items, out int newSaleID)
        {
            newSaleID = -1;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {

                    string saleQuery = @"INSERT INTO Sales (MemberID, UserID, SaleDate, TotalAmount)
                                         VALUES (@MemberID, @UserID, GETDATE(), @TotalAmount);
                                         SELECT SCOPE_IDENTITY();";

                    SqlCommand saleCommand = new SqlCommand(saleQuery, connection, transaction);
                    saleCommand.Parameters.AddWithValue("@MemberID", (object)memberID ?? DBNull.Value);
                    saleCommand.Parameters.AddWithValue("@UserID", userID);
                    saleCommand.Parameters.AddWithValue("@TotalAmount", totalAmount);

                    object result = saleCommand.ExecuteScalar();
                    int saleID = Convert.ToInt32(result);


                    foreach (var item in items)
                    {

                        string updateStockQuery = @"UPDATE Products
                                                    SET StockQuantity = StockQuantity - @Quantity
                                                    WHERE ProductID = @ProductID AND StockQuantity >= @Quantity";

                        SqlCommand updateStockCommand = new SqlCommand(updateStockQuery, connection, transaction);
                        updateStockCommand.Parameters.AddWithValue("@Quantity", item.Quantity);
                        updateStockCommand.Parameters.AddWithValue("@ProductID", item.ProductID);

                        int rowsAffected = updateStockCommand.ExecuteNonQuery();


                        if (rowsAffected == 0)
                        {
                            transaction.Rollback();
                            return enSaleDataProduct.InsufficientStock;
                        }

                        string itemQuery = @"INSERT INTO SaleItems (SaleID, ProductID, Quantity, UnitPrice, TotalPrice)
                                             VALUES (@SaleID, @ProductID, @Quantity, @UnitPrice, @TotalPrice)";

                        SqlCommand itemCommand = new SqlCommand(itemQuery, connection, transaction);
                        itemCommand.Parameters.AddWithValue("@SaleID", saleID);
                        itemCommand.Parameters.AddWithValue("@ProductID", item.ProductID);
                        itemCommand.Parameters.AddWithValue("@Quantity", item.Quantity);
                        itemCommand.Parameters.AddWithValue("@UnitPrice", item.UnitPrice);
                        itemCommand.Parameters.AddWithValue("@TotalPrice", item.TotalPrice);

                        itemCommand.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    newSaleID = saleID;
                    return enSaleDataProduct.Success;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    clsLog.LogError("clsSalesData.AddSale", ex);
                    return enSaleDataProduct.Failed;
                }
            }
        }

    }
}
