using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using clsLogger;

namespace clsDataAccess
{
    public class clsRegistrationData
    {
        public static bool RegisterMemberWithMemberShip(string FirstName, string LastName, string Phone, DateTime DateOfBirth, byte Gendor, int PlanID, DateTime StartDate,
          DateTime EndDate, decimal Amount, string Notes, out int NewMemberID,out int NewMemberShipID)
        {
            NewMemberID = -1;
            NewMemberShipID = -1;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {

                    string query1 = @"Insert into Members (FirstName,LastName,Phone,DateOfBirth,Gendor,CreatedDate) values
                    (@FirstName,@LastName,@Phone,@DateOfBirth,@Gendor,@CreatedDate); SELECT SCOPE_IDENTITY()";

                    SqlCommand cmd1 = new SqlCommand(query1, connection, transaction);

                    cmd1.Parameters.AddWithValue("@FirstName", FirstName);
                    cmd1.Parameters.AddWithValue("@LastName", LastName);
                    cmd1.Parameters.AddWithValue("@Phone", Phone);
                    cmd1.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    cmd1.Parameters.AddWithValue("@Gendor", Gendor);
                    cmd1.Parameters.AddWithValue("@CreatedDate", DateTime.Now);

                    int memberID = Convert.ToInt32(cmd1.ExecuteScalar());

                    bool isActive = (DateTime.Now <= EndDate);

                    string query2 = @"Insert Into MemberShips (MemberID,PlanID,StartDate,EndDate,IsActive)
                         values (@MemberID,@PlanID,@StartDate,@EndDate,@IsActive);
                         SELECT SCOPE_IDENTITY()";

                    SqlCommand cmd2 = new SqlCommand(query2, connection, transaction);

                    cmd2.Parameters.AddWithValue("@MemberID", memberID); 
                    cmd2.Parameters.AddWithValue("@PlanID", PlanID);
                    cmd2.Parameters.AddWithValue("@StartDate", StartDate);
                    cmd2.Parameters.AddWithValue("@EndDate", EndDate);
                    cmd2.Parameters.AddWithValue("@IsActive", isActive);

                     NewMemberShipID = Convert.ToInt32(cmd2.ExecuteScalar());


                    string query3 = @"Insert Into Payments (MemberShipID,PaymentDate,Amount,Notes) values (@MemberShipID,@PaymentDate,@Amount,@Notes)";

                    SqlCommand cmd3 = new SqlCommand(query3, connection, transaction);

                    cmd3.Parameters.AddWithValue("@MemberShipID", NewMemberShipID);
                    cmd3.Parameters.AddWithValue("@PaymentDate", DateTime.Now);
                    cmd3.Parameters.AddWithValue("@Amount", Amount);
                    cmd3.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(Notes) ? (object)DBNull.Value : Notes);

                    cmd3.ExecuteNonQuery();

                   
                    transaction.Commit();
                    NewMemberID = memberID;
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    clsLog.LogError("clsRegistrationData.RegisterMemberWithMemberShip", ex);
                    throw;
                }
            }
        }

        public static bool RenewMemberShipWithPayment(int ExistingMemberID, int oldMemberShipID, int PLanID, DateTime StartDate, DateTime EndDate, 
            decimal Amount, string Notes, out int NewMemberShipID)
        {
            NewMemberShipID = -1;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    
                    string query1 = @"Update MemberShips Set IsActive = 0 Where MemberShipID = @OldMemberShipID";
                    SqlCommand cmdUpdateOld = new SqlCommand(query1, connection, transaction);
                    cmdUpdateOld.Parameters.AddWithValue("@OldMemberShipID", oldMemberShipID);
                    cmdUpdateOld.ExecuteNonQuery();

                    bool isActive = (DateTime.Now <= EndDate);

                    string query2 = @"Insert Into MemberShips (MemberID,PLanID,StartDate,EndDate,IsActive) values 
                    (@MemberID,@PLanID,@StartDate,@EndDate,@IsActive); SELECT SCOPE_IDENTITY()";
                    SqlCommand cmd1 = new SqlCommand(query2, connection, transaction);

                    cmd1.Parameters.AddWithValue("@MemberID", ExistingMemberID);
                    cmd1.Parameters.AddWithValue("@PlanID", PLanID);
                    cmd1.Parameters.AddWithValue("@StartDate", StartDate);
                    cmd1.Parameters.AddWithValue("@EndDate", EndDate);
                    cmd1.Parameters.AddWithValue("@IsActive", isActive);

                    int memberShipID = Convert.ToInt32(cmd1.ExecuteScalar());

                    string query3 = @"Insert into Payments (MemberShipID,PaymentDate,Amount,Notes)
                         values (@MemberShipID,@PaymentDate,@Amount,@Notes)";
                    SqlCommand cmd2 = new SqlCommand(query3, connection, transaction);

                    cmd2.Parameters.AddWithValue("@MemberShipID", memberShipID);
                    cmd2.Parameters.AddWithValue("@PaymentDate", DateTime.Now);
                    cmd2.Parameters.AddWithValue("@Amount", Amount);
                    cmd2.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(Notes) ? (object)DBNull.Value : Notes);

                    cmd2.ExecuteNonQuery();

         
                    transaction.Commit();
                    NewMemberShipID = memberShipID;
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    clsLog.LogError("clsRegistrationData.RenewMemberShipWithPayment", ex);
                    throw;
                }
            }
        }


    }
}
