using clsLogger;
using System;
using System.Data;
using System.Data.SqlClient;

namespace clsDataAccess
{
    public static class clsDatabaseData
    {
       
        public static bool CreateBackup(string backupFilePath)
        {
            bool isSuccess = false;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                using (SqlCommand command = new SqlCommand("sp_BackupDatabase", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@BackupPath", backupFilePath);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        isSuccess = true;
                    }
                    catch (Exception ex)
                    {
                        clsLog.LogError("clsDatabaseData.CreateBackup", ex);
                        throw;
                    }
                }
            }
            return isSuccess;
        }

        public static bool RestoreBackup(string backupFilePath)
        {
            // 1. تنظيف وإغلاق الاتصالات المعلقة في الذاكرة
            SqlConnection.ClearAllPools();

            // 2. التحويل للاتصال بقاعدة master
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(clsConnectionString.ConnectingString);
            builder.InitialCatalog = "master";

            // 3. نص الاستعلام المباشر المضاد للأخطاء والكوارث
            string query = @"
              IF EXISTS (SELECT name FROM sys.databases WHERE name = N'Gym')
              BEGIN
                ALTER DATABASE [Gym] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
              END

              RESTORE DATABASE [Gym] FROM DISK = @BackupPath WITH REPLACE;

              IF EXISTS (SELECT name FROM sys.databases WHERE name = N'Gym')
              BEGIN
                ALTER DATABASE [Gym] SET MULTI_USER;
              END";

                    using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.CommandTimeout = 300; // 5 دقائق لضمان عدم حدوث Timeout
                    command.Parameters.AddWithValue("@BackupPath", backupFilePath);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        return true; // العملية نجحت بسلام
                    }
                    catch (Exception ex)
                    {
                        clsLog.LogError("clsDatabaseData.RestoreBackup", ex);
                        throw;
                    }
                }
            }
        }
    }
}