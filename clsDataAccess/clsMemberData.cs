using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Models;
using System.Data;
using System.CodeDom;
using clsLogger;
using DTOs;

namespace clsDataAccess
{
    public class clsMemberData
    {
        public static int AddMember(clsMemberModel member)
        {
            int memberID = -1;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                string query = @"INSERT INTO Members (FirstName, LastName, Phone, DateOfBirth, Gendor, CreatedDate) 
                             VALUES (@FirstName, @LastName, @Phone, @DateOfBirth, @Gendor, @CreatedDate);
                             SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", member.FirstName);
                    command.Parameters.AddWithValue("@LastName", member.LastName);
                    command.Parameters.AddWithValue("@Phone", member.Phone);
                    command.Parameters.AddWithValue("@DateOfBirth", member.DateOfBirth);
                    command.Parameters.AddWithValue("@Gendor", member.Gendor);
                    command.Parameters.AddWithValue("@CreatedDate", DateTime.Now); 

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int ID))
                        {
                            memberID = ID;
                        }
                    }
                    catch (Exception ex)
                    {
                        clsLog.LogError("clsMemberData.AddMember", ex);
                        throw;
                    }
                }
            }
            return memberID;
        }

     
        public static bool UpdateMember(clsMemberModel member)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                string query = @"UPDATE Members SET
                                FirstName = @FirstName, 
                                LastName = @LastName, 
                                Phone = @Phone,
                                DateOfBirth = @DateOfBirth, 
                                Gendor = @Gendor
                              
                             WHERE MemberID = @MemberID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MemberID", member.MemberID);
                    command.Parameters.AddWithValue("@FirstName", member.FirstName);
                    command.Parameters.AddWithValue("@LastName", member.LastName);
                    command.Parameters.AddWithValue("@Phone", member.Phone);
                    command.Parameters.AddWithValue("@DateOfBirth", member.DateOfBirth);
                    command.Parameters.AddWithValue("@Gendor", member.Gendor);
                    

                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        clsLog.LogError("clsMemberData.UpdateMember", ex);
                        throw;
                    }
                }
            }
            return (rowsAffected > 0);
        }

       
        public static clsMemberModel GetMemberInfoByID(int memberID)
        {
            clsMemberModel member = null;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                string query = @"SELECT * FROM Members WHERE MemberID = @MemberID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MemberID", memberID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                member = new clsMemberModel
                                {
                                    MemberID = (int)reader["MemberID"],
                                    FirstName = (string)reader["FirstName"],
                                    LastName = (string)reader["LastName"],
                                    DateOfBirth = (DateTime)reader["DateOfBirth"],
                                    Phone = (string)reader["Phone"],
                                    Gendor = (byte)reader["Gendor"],
                                    CreatedDate = (DateTime)reader["CreatedDate"]
                                };
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        clsLog.LogError("clsMemberData.GetMemberInfoByID", ex);
                        throw;
                    }
                }
            }
            return member;
        }

    
        public static List<clsMemberDTO> GetAllMembers()
        {
            List<clsMemberDTO> membersList = new List<clsMemberDTO>();

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                string query = @"SELECT MemberID, Name, Phone, DateOfBirth, Gendor, 
                                MemberShipID, StartDate, EndDate, PlanName, IsActive 
                         FROM Members_View";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                clsMemberDTO member = new clsMemberDTO
                                {
                                    MemberID = (int)reader["MemberID"],
                                    Name = (string)reader["Name"],
                                    Phone = (string)reader["Phone"],
                                    DateOfBirth = (DateTime)reader["DateOfBirth"],
                                    Gendor = (string)reader["Gendor"],
                                    MemberShipID = (int)reader["MemberShipID"],
                                    StartDate = (DateTime)reader["StartDate"],
                                    EndDate = (DateTime)reader["EndDate"],
                                    PlanName = (string)reader["PlanName"],
                                    IsActive = (string)reader["IsActive"]
                                };

                                membersList.Add(member);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        clsLog.LogError("clsMemberData.GetAllMembers", ex);
                        throw;
                    }
                }
            }
            return membersList;
        }

        public static clsMemberDTO GetMemberDTOByID(int memberID)
        {
            clsMemberDTO memberDTO = null;

            string query = @"SELECT MemberID, Name, Phone, DateOfBirth, Gendor, 
                                MemberShipID, StartDate, EndDate, PlanName, IsActive from Members_View
                             WHERE MemberID = @MemberID";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MemberID", memberID);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                        
                            if (reader.Read())
                            {
                                memberDTO = new clsMemberDTO
                                {
                                    MemberID = (int)reader["MemberID"],
                                    Name = (string)reader["Name"],
                                    Phone = (string)reader["Phone"],
                                    DateOfBirth = (DateTime)reader["DateOfBirth"],
                                    Gendor = (string)reader["Gendor"],
                                    MemberShipID = (int)reader["MemberShipID"],
                                    StartDate = (DateTime)reader["StartDate"],
                                    EndDate = (DateTime)reader["EndDate"],
                                    PlanName = (string)reader["PlanName"],
                                    IsActive = (string)reader["IsActive"]
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsLog.LogError("clsMemberData.GetMemberDTOByID", ex);
                throw;
                
            }

            return memberDTO; 
        }

    }
}
