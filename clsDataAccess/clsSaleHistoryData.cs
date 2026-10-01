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
    public class clsSaleHistoryData
    {

        public static List<clsSaleHistoryModel> GetAllSales()
        {
            List<clsSaleHistoryModel> sales = new List<clsSaleHistoryModel>();

            string query = @"SELECT s.SaleID, s.SaleDate, s.TotalAmount,
                                    ISNULL(m.FirstName + ' ' + m.LastName, 'Walk-in / Guest') AS MemberName,
                                    u.FullName AS UserName
                             FROM Sales s
                             LEFT JOIN Members m ON s.MemberID = m.MemberID
                             INNER JOIN Users u ON s.UserID = u.UserID
                             ORDER BY s.SaleDate DESC";

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clsSaleHistoryModel sale = new clsSaleHistoryModel();
                            sale.SaleID = (int)reader["SaleID"];
                            sale.SaleDate = (DateTime)reader["SaleDate"];
                            sale.TotalAmount = (decimal)reader["TotalAmount"];
                            sale.MemberName = (string)reader["MemberName"];
                            sale.UserName = (string)reader["UserName"];

                            sales.Add(sale);
                        }
                    }
                }
                catch (Exception ex)
                {
                    clsLog.LogError("clsSalesData.GetAllSales", ex);
                    throw;
                }
            }

            return sales;
        }

        public static List<clsSaleItemHistoryModel> GetSaleItemsBySaleID(int saleID)
        {
            List<clsSaleItemHistoryModel> items = new List<clsSaleItemHistoryModel>();

            string query = @"SELECT p.ProductName, si.Quantity, si.UnitPrice, si.TotalPrice
                      FROM SaleItems si
                      INNER JOIN Products p ON si.ProductID = p.ProductID
                      WHERE si.SaleID = @SaleID";

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SaleID", saleID);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clsSaleItemHistoryModel item = new clsSaleItemHistoryModel();
                            item.ProductName = (string)reader["ProductName"];
                            item.Quantity = (int)reader["Quantity"];
                            item.UnitPrice = (decimal)reader["UnitPrice"];
                            item.TotalPrice = (decimal)reader["TotalPrice"];

                            items.Add(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    clsLog.LogError("clsSalesData.GetSaleItemsBySaleID", ex);
                    throw;
                }
            }

            return items;
        }

    }
}
