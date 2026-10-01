using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Models;
using System.IO;
using clsLogger;
using System.Data;

namespace clsDataAccess
{
    public class clsUserData
    {
        public static clsUserModel Login(string username, string password)
        {
            clsUserModel user = null;
            string HashedPassword = clsPasswordHelper.HashPassword(password);
            using (SqlConnection conn = new SqlConnection(clsConnectionString.ConnectingString))
            {
                string query = @"select * from Users where UserName = @UserName and PasswordHash = @PasswordHash and IsActive=1";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", username);
                    cmd.Parameters.AddWithValue("@PasswordHash", HashedPassword);
                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                user = new clsUserModel();
                                user.UserID = (int)reader["UserID"];
                                user.UserName = (string)reader["UserName"];
                                user.PasswordHash = (string)reader["PasswordHash"];
                                user.FullName = (string)reader["FullName"];
                                user.Role = (string)reader["Role"];
                                user.IsActive = (bool)reader["IsActive"];
                                user.CreatedDate = (DateTime)reader["CreateDate"];
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        clsLog.LogError("clsUserData.Login", ex);
                        throw;
                    }
                }
            }
            return user;
        }

        public static int AddUser(string username, string password, string fullName, string role)
        {
            int userID = -1;
            string HashedPassword = clsPasswordHelper.HashPassword(password);
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                string query = @"Insert into Users (UserName,PasswordHash,FullName,Role,IsActive,CreateDate) 
                                 values (@UserName,@PasswordHash,@FullName,@Role,1,@CreateDate);
                                SELECT SCOPE_IDENTITY()";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UserName", username);
                    cmd.Parameters.AddWithValue("@PasswordHash", HashedPassword);
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@Role", role);
                    cmd.Parameters.AddWithValue("@CreateDate", DateTime.Now);

                    try
                    {
                        connection.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int ID))
                        {
                            userID = ID;
                        }
                    }
                    catch (Exception ex)
                    {
                        clsLog.LogError("clsUserData.AddUser", ex);
                        throw;
                    }
                }
            }
            return userID;
        }

        public static bool UpdateUser(int userID, string fullName, string role, bool IsActive)
        {
            int RowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                string query = @"Update Users set FullName = @FullName, Role = @Role, IsActive=@IsActive where UserID = @UserID";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@Role", role);
                    cmd.Parameters.AddWithValue("@IsActive", IsActive);
                    try
                    {
                        connection.Open();
                        RowsAffected = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        clsLog.LogError("clsUserData.UpdateUser", ex);
                        throw;
                    }
                }
            }
            return (RowsAffected > 0);
        }

        public static bool ChangePassword(int UserID, string NewPassword)
        {
            int RowsAffected = 0;
            string HashedPassword = clsPasswordHelper.HashPassword(NewPassword);

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                string query = @"Update Users set PasswordHash = @PasswordHash where UserID = @UserID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@PasswordHash", HashedPassword);

                    try
                    {
                        connection.Open();
                        RowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        clsLog.LogError("clsUserData.ChangePassword", ex);
                        throw;
                    }
                }
            }
            return (RowsAffected > 0);
        }

        public static List<clsUserModel> GetAllUsers()
        {
            List<clsUserModel> usersList = new List<clsUserModel>();

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                
                string query = @"Select UserID, UserName, FullName, Role, IsActive, CreateDate from Users";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                clsUserModel user = new clsUserModel
                                {
                                    UserID = (int)reader["UserID"],
                                    UserName = (string)reader["UserName"],
                                    FullName = (string)reader["FullName"],
                                    Role = (string)reader["Role"],
                                    IsActive = (bool)reader["IsActive"],
                                    CreatedDate = (DateTime)reader["CreateDate"]
                                };

                                usersList.Add(user);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        clsLog.LogError("clsUserData.GetAllUsers", ex);
                        throw;
                    }
                }
            }
            return usersList;
        }

        public static bool IsUserNameExists(string username)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                string query = @"select count(*) from Users where UserName = @UserName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", username);
                    try
                    {
                        connection.Open();
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                    catch (Exception ex)
                    {
                        clsLog.LogError("clsUserData.IsUserNameExists", ex);
                        throw;
                    }
                }
            }
        }

        public static clsUserModel GetUserInfoByID(int UserID)
        {
            clsUserModel user = null;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                string query = @"select * from Users where UserID=@UserID";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UserID", UserID);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                user = new clsUserModel();
                                user.UserID = (int)reader["UserID"];
                                user.UserName = (string)reader["UserName"];
                                user.PasswordHash = (string)reader["PasswordHash"];
                                user.FullName = (string)reader["FullName"];
                                user.Role = (string)reader["Role"];
                                user.IsActive = (bool)reader["IsActive"];
                                user.CreatedDate = (DateTime)reader["CreateDate"];
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        clsLog.LogError("clsUserData.GetUserInfoByID", ex);
                        throw;
                    }
                }
            }
            return user;
        }

        public static bool VerifyPassword(int userID, string Password)
        {
            string HashedPassword = clsPasswordHelper.HashPassword(Password);
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                string query = @"select count(*) from Users where UserID=@UserID and PasswordHash = @PasswordHash";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    cmd.Parameters.AddWithValue("@PasswordHash", HashedPassword);
                    try
                    {
                        connection.Open();
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                    catch (Exception ex)
                    {
                        clsLog.LogError("clsUserData.VerifyPassword", ex);
                        throw;
                    }
                }
            }
        }
    }

}

