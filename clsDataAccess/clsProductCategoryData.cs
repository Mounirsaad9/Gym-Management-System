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
    public class clsProductCategoryData
    {
        public static List<clsProductCategoryModel> GetAllCategories()
        {
            List<clsProductCategoryModel> categories = new List<clsProductCategoryModel>();
            string query = @"select CategoryID,CategoryName from ProductCategories";

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            clsProductCategoryModel category = new clsProductCategoryModel();
                            category.CategoryID = (int)reader["CategoryID"];
                            category.CategoryName = (string)reader["CategoryName"];

                            categories.Add(category);
                        }
                    }

                }
                catch (Exception ex)
                {
                    clsLog.LogError("clsProductCategoryData.GetAllCategories",ex);
                    throw;
                }
                    
                
            }
            return categories;
        }

        public static int AddCategory(string categoryName)
        {
            int NewCategoryID = -1;

            string query = @"Insert Into ProductCategories (CategoryName) values 
                            (@CategoryName);
                             SELECT SCOPE_IDENTITY()";

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CategoryName", categoryName);
                    connection.Open();

                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out NewCategoryID))
                    {
                        return NewCategoryID;
                    }


                }
                catch (Exception ex)
                {
                    clsLog.LogError("clsProductCategoryData.AddCategory", ex);
                    throw;
                }

            }
            return NewCategoryID;
        }

        public static bool UpdateCategory(int CategoryID,string categoryName)
        {
            int RowsAffected = 0;

            string query = @"Update ProductCategories set CategoryName= @CategoryName where CategoryID = @CategoryID";
            
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                 SqlCommand command = new SqlCommand(query, connection);
                 command.Parameters.AddWithValue("@CategoryID",CategoryID);
                 command.Parameters.AddWithValue("@CategoryName",categoryName);
                try
                {
                    connection.Open();

                    RowsAffected = command.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    clsLog.LogError("clsProductCategoryData.UpdateCategory", ex);
                    throw;
                }
            }
            return (RowsAffected > 0);
        }
    
        public static bool IsCategoryNameExists(string CategoryName,int ExcludeCategoryID=0)
        {

            //<> means not equal (!=) and this let this function works in both way add and update
            string query = @"select count(*) from ProductCategories where CategoryName = @CategoryName and 
                            CategoryID <> @ExcludeCategoryID";

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                SqlCommand command = new SqlCommand(query,connection);
                command.Parameters.AddWithValue("@CategoryName",CategoryName);
                command.Parameters.AddWithValue("@ExcludeCategoryID",ExcludeCategoryID);

                try
                {
                    connection.Open();

                    int count = (int)command.ExecuteScalar();

                    return (count > 0);
                }
                catch (Exception ex)
                {
                    clsLog.LogError("clsProductCategoryData.IsCategoryNameExists", ex);

                    throw;
                }

            }
        }


    }
}
