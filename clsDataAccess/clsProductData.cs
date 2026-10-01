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
    public class clsProductData
    {
        public static List<clsProductModel> GetAllProducts()
        {
            List<clsProductModel> products = new List<clsProductModel>();

            string query = @"SELECT ProductID, CategoryID, ProductName, PurchasePrice, SellingPrice,
                                    StockQuantity, MinStockAlert, BarcodeValue, IsActive
                             FROM Products
                             WHERE IsActive = 1";

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                clsProductModel product = new clsProductModel
                                {
                                    ProductID = Convert.ToInt32(reader["ProductID"]),
                                    CategoryID = Convert.ToInt32(reader["CategoryID"]),
                                    ProductName = reader["ProductName"].ToString(),
                                    PurchasePrice = Convert.ToDecimal(reader["PurchasePrice"]),
                                    SellingPrice = Convert.ToDecimal(reader["SellingPrice"]),
                                    StockQuantity = Convert.ToInt32(reader["StockQuantity"]),
                                    MinStockAlert = Convert.ToInt32(reader["MinStockAlert"]),
                                    BarcodeValue = reader["BarcodeValue"] != DBNull.Value ? reader["BarcodeValue"].ToString() : null,
                                    IsActive = Convert.ToBoolean(reader["IsActive"])
                                };

                                products.Add(product);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    clsLog.LogError("clsProductData.GetAllProducts", ex);
                    throw;
                }
            }

            return products;
        }

        public static int AddProduct(int categoryID, string productName, decimal purchasePrice, decimal sellingPrice,
                                     int stockQuantity, int minStockAlert, string barcodeValue)
        {
            int newProductID = -1;

            string query = @"INSERT INTO Products
                              (CategoryID, ProductName, PurchasePrice, SellingPrice, StockQuantity, MinStockAlert, BarcodeValue, IsActive)
                             VALUES
                              (@CategoryID, @ProductName, @PurchasePrice, @SellingPrice, @StockQuantity, @MinStockAlert, @BarcodeValue, 1);
                             SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CategoryID", categoryID);
                        command.Parameters.AddWithValue("@ProductName", productName);
                        command.Parameters.AddWithValue("@PurchasePrice", purchasePrice);
                        command.Parameters.AddWithValue("@SellingPrice", sellingPrice);
                        command.Parameters.AddWithValue("@StockQuantity", stockQuantity);
                        command.Parameters.AddWithValue("@MinStockAlert", minStockAlert);
                        command.Parameters.AddWithValue("@BarcodeValue", (object)barcodeValue ?? DBNull.Value);

                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            newProductID = id;
                        }
                    }
                }
                catch (Exception ex)
                {
                    clsLog.LogError("clsProductData.AddProduct", ex);
                    throw;
                }
            }

            return newProductID;
        }

        public static bool UpdateProduct(int productID, int categoryID, string productName, decimal purchasePrice, decimal price,
                                         int stockQuantity, int minStockAlert, string barcodeValue)
        {
            string query = @"UPDATE Products
                             SET CategoryID = @CategoryID,
                                 ProductName = @ProductName,
                                 PurchasePrice = @PurchasePrice,
                                 SellingPrice = @SellingPrice,
                                 StockQuantity = @StockQuantity,
                                 MinStockAlert = @MinStockAlert,
                                 BarcodeValue = @BarcodeValue
                             WHERE ProductID = @ProductID";

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProductID", productID);
                        command.Parameters.AddWithValue("@CategoryID", categoryID);
                        command.Parameters.AddWithValue("@ProductName", productName);
                        command.Parameters.AddWithValue("@PurchasePrice", purchasePrice);
                        command.Parameters.AddWithValue("@SellingPrice", price);
                        command.Parameters.AddWithValue("@StockQuantity", stockQuantity);
                        command.Parameters.AddWithValue("@MinStockAlert", minStockAlert);
                        command.Parameters.AddWithValue("@BarcodeValue", (object)barcodeValue ?? DBNull.Value);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    clsLog.LogError("clsProductData.UpdateProduct", ex);
                    throw;
                }
            }
        }

        public static bool DeactivateProduct(int productID)
        {
            string query = @"UPDATE Products SET IsActive = 0 WHERE ProductID = @ProductID";

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProductID", productID);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    clsLog.LogError("clsProductData.DeactivateProduct", ex);
                    throw;
                }
            }
        }

        public static bool IsProductNameExists(string productName, int excludeProductID = 0)
        {
            string query = @"SELECT TOP 1 1 FROM Products
                             WHERE ProductName = @ProductName
                             AND ProductID <> @ExcludeProductID";

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProductName", productName);
                        command.Parameters.AddWithValue("@ExcludeProductID", excludeProductID);

                        connection.Open();
                        object result = command.ExecuteScalar();

                        return result != null;
                    }
                }
                catch (Exception ex)
                {
                    clsLog.LogError("clsProductData.IsProductNameExists", ex);
                    throw;
                }
            }
        }


        public static clsProductModel GetProductByID(int productID)
        {
            clsProductModel product = null;

            
            string query = @"SELECT ProductID, CategoryID, ProductName, PurchasePrice, SellingPrice,
                            StockQuantity, MinStockAlert, BarcodeValue, IsActive
                     FROM Products
                     WHERE ProductID = @ProductID";

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProductID", productID);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                
                                product = new clsProductModel
                                {
                                    ProductID = Convert.ToInt32(reader["ProductID"]),
                                    CategoryID = Convert.ToInt32(reader["CategoryID"]),
                                    ProductName = reader["ProductName"].ToString(),
                                    PurchasePrice = Convert.ToDecimal(reader["PurchasePrice"]),
                                    SellingPrice = Convert.ToDecimal(reader["SellingPrice"]),
                                    StockQuantity = Convert.ToInt32(reader["StockQuantity"]),
                                    MinStockAlert = Convert.ToInt32(reader["MinStockAlert"]),
                                    
                                    BarcodeValue = reader["BarcodeValue"] != DBNull.Value ? reader["BarcodeValue"].ToString() : null,
                                    IsActive = Convert.ToBoolean(reader["IsActive"])
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    clsLog.LogError("clsProductData.GetProductByID", ex);
                    throw; 
                }
            }

            return product;
        }
    }
}