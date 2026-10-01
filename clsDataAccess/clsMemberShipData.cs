using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Models;
using System.Data;
using clsLogger;
using DTOs;
using System.ComponentModel;

namespace clsDataAccess
{
    public class clsMemberShipData
    {
      
        public static int AddMemberShip(clsMemberShipModel memberShip)
        {
            int memberShipID = -1;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                string query = @"INSERT INTO MemberShips (MemberID, PlanID, StartDate, EndDate, IsActive)
                             VALUES (@MemberID, @PlanID, @StartDate, @EndDate, @IsActive);
                             SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MemberID", memberShip.MemberID);
                    command.Parameters.AddWithValue("@PlanID", memberShip.PlanID);
                    command.Parameters.AddWithValue("@StartDate", memberShip.StartDate);
                    command.Parameters.AddWithValue("@EndDate", memberShip.EndDate);
                    command.Parameters.AddWithValue("@IsActive", memberShip.IsActive);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int ID))
                        {
                            memberShipID = ID;
                        }
                    }
                    catch (Exception ex)
                    {
                        clsLog.LogError("clsMemberShipData.AddMemberShip", ex);
                        throw;
                    }
                }
            }
            return memberShipID;
        } 

        
        public static clsMemberShipModel GetMemberShipInfoByID(int memberShipID)
        {
            clsMemberShipModel memberShip = null;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                string query = @"SELECT * FROM MemberShips WHERE MemberShipID = @MemberShipID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MemberShipID", memberShipID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                memberShip = new clsMemberShipModel
                                {
                                    MemberShipID = memberShipID,
                                    MemberID = (int)reader["MemberID"],
                                    PlanID = (int)reader["PlanID"],
                                    StartDate = (DateTime)reader["StartDate"],
                                    EndDate = (DateTime)reader["EndDate"],
                                    IsActive = (bool)reader["IsActive"]
                                };
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        clsLog.LogError("clsMemberShipData.GetMemberShipInfoByID", ex);
                        throw;
                    }
                }
            }
            return memberShip;
        }

        
        public static bool UpdateMemberShip(clsMemberShipModel memberShip)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                string query = @"UPDATE MemberShips 
                             SET MemberID = @MemberID, PlanID = @PlanID, StartDate = @StartDate, EndDate = @EndDate, IsActive = @IsActive 
                             WHERE MemberShipID = @MemberShipID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MemberShipID", memberShip.MemberShipID);
                    command.Parameters.AddWithValue("@MemberID", memberShip.MemberID);
                    command.Parameters.AddWithValue("@PlanID", memberShip.PlanID);
                    command.Parameters.AddWithValue("@StartDate", memberShip.StartDate);
                    command.Parameters.AddWithValue("@EndDate", memberShip.EndDate);
                    command.Parameters.AddWithValue("@IsActive", memberShip.IsActive);

                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        clsLog.LogError("clsMemberShipData.UpdateMemberShip", ex);
                        throw;
                    }
                }
            }
            return (rowsAffected > 0);
        }

       
        public static clsMemberShipModel GetLastMemberShipByMemberID(int memberID)
        {
            clsMemberShipModel memberShip = null;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                string query = @"SELECT TOP 1 * FROM MemberShips WHERE MemberID = @MemberID ORDER BY StartDate DESC";

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
                                memberShip = new clsMemberShipModel
                                {
                                    MemberShipID = (int)reader["MemberShipID"],
                                    MemberID = (int)reader["MemberID"],
                                    PlanID = (int)reader["PlanID"],
                                    StartDate = (DateTime)reader["StartDate"],
                                    EndDate = (DateTime)reader["EndDate"],
                                    IsActive = (bool)reader["IsActive"]
                                };
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        clsLog.LogError("clsMemberShipData.GetLastMemberShipByMemberID", ex);
                        throw;
                    }
                }
            }
            return memberShip;
        }

        public static List<clsMembershipHistoryDTO> GetAllMemberShipsByMemberID(int memberID)
        {
            List<clsMembershipHistoryDTO> historyList = new List<clsMembershipHistoryDTO>();
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                string query = @"SELECT 
                                ms.MemberShipID,
                                sp.PlanName,
                                ms.StartDate,
                                ms.EndDate,
                                CASE 
                                    WHEN ms.EndDate >= GETDATE() THEN 'Active'
                                    ELSE 'Expired'
                                END AS Status
                             FROM MemberShips ms
                             INNER JOIN SubscriptionPlans sp ON ms.PlanID = sp.PlanID
                             WHERE ms.MemberID = @MemberID
                             ORDER BY ms.StartDate DESC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MemberID", memberID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                historyList.Add(new clsMembershipHistoryDTO
                                {
                                    MemberShipID = (int)reader["MemberShipID"],
                                    PlanName = (string)reader["PlanName"],
                                    StartDate = (DateTime)reader["StartDate"],
                                    EndDate = (DateTime)reader["EndDate"],
                                    Status = (string)reader["Status"]
                                });
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        clsLog.LogError("clsMemberShipData.GetAllMemberShipsByMemberID", ex);
                        throw;
                    }
                }
            }
            return historyList;
        }

        public static BindingList<clsMembershipAlertDTO> GetExpiringAndExpiredMemberships(int daysThreshold)
        {
            var list = new BindingList<clsMembershipAlertDTO>();

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                using (SqlCommand command = new SqlCommand("sp_GetExpiringAndExpiredMemberships", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@DaysThreshold", daysThreshold);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                list.Add(new clsMembershipAlertDTO
                                {
                                    MembershipID = Convert.ToInt32(reader["MembershipID"]),
                                    MemberID = Convert.ToInt32(reader["MemberID"]),
                                    MemberFullName = reader["MemberFullName"].ToString(),
                                    Phone = reader["Phone"].ToString(),
                                    PlanName = reader["PlanName"].ToString(),
                                    StartDate = Convert.ToDateTime(reader["StartDate"]),
                                    EndDate = Convert.ToDateTime(reader["EndDate"]),
                                    DaysRemaining = Convert.ToInt32(reader["DaysRemaining"]),
                                    IsActive = reader["IsActive"].ToString()
                                });
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        clsLog.LogError("clsMemberShipData.GetExpiringAndExpiredMemberships", ex); 
                    }
                }
            }

            return list;
        }

    }
}
