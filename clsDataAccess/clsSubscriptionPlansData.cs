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

namespace clsDataAccess
{
    public  class clsSubscriptionPlansData
    {
        public static List<clsSubscriptionPlansModel> GetAllSubscriptionPlans()
        {
            // 1. إنشاء القائمة الفارغة بدلاً من DataTable
            List<clsSubscriptionPlansModel> plansList = new List<clsSubscriptionPlansModel>();

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                string query = @"SELECT * FROM SubscriptionPlans";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        // 2. استخدام حلقة الدوران لقراءة كل صف وتحويله إلى كائن
                        while (reader.Read())
                        {
                            clsSubscriptionPlansModel plan = new clsSubscriptionPlansModel();
                            plan.PlanID = (int)reader["PlanID"];
                            plan.PlanName = (string)reader["PlanName"];
                            plan.DurationDays = (int)reader["DurationDays"];
                            plan.Price = Convert.ToDecimal(reader["Price"]);

                            // إضافة الكائن إلى القائمة
                            plansList.Add(plan);
                        }
                    }
                    catch (Exception ex)
                    {
                        // من اجل تسجيل الخطأ في حالة حدوثة
                        clsLog.LogError("clsSubscriptionPlansData.GetAllSubscriptionPlans", ex);
                        throw new Exception(ex.Message);
                    }
                }
            }
            // 3. إرجاع القائمة
            return plansList;
        }

        // تمرير الكائن (plan) بالكامل بدلاً من المتغيرات المنفصلة
        public static bool UpdateSubscriptionPlans(clsSubscriptionPlansModel plan)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                string query = @"UPDATE SubscriptionPlans 
                             SET PlanName = @PlanName, 
                                 DurationDays = @DurationDays, 
                                 Price = @Price 
                             WHERE PlanID = @PlanID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // قراءة القيم من الكائن مباشرة
                    command.Parameters.AddWithValue("@PlanID", plan.PlanID);
                    command.Parameters.AddWithValue("@PlanName", plan.PlanName);
                    command.Parameters.AddWithValue("@DurationDays", plan.DurationDays);
                    command.Parameters.AddWithValue("@Price", plan.Price);

                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        clsLog.LogError("clsSubscriptionPlansData.UpdateSubscriptionPlans", ex);
                        throw new Exception(ex.Message);
                    }
                }
            }
            return (rowsAffected > 0);
        }

        public static clsSubscriptionPlansModel GetSubscriptionPlanInfoByID(int PlanID)
        {
            clsSubscriptionPlansModel plan = null;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectingString))
            {
                string query = @"SELECT * FROM SubscriptionPlans WHERE PlanID = @PlanID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PlanID", PlanID);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            plan = new clsSubscriptionPlansModel();
                            plan.PlanID = (int)reader["PlanID"];
                            plan.PlanName = (string)reader["PlanName"];
                            plan.DurationDays = (int)reader["DurationDays"];
                            plan.Price = Convert.ToDecimal(reader["Price"]);
                        }
                    }
                    catch (Exception ex)
                    {
                        clsLog.LogError("clsSubscriptionPlansData.GetSubscriptionPlanInfoByID", ex);
                        throw new Exception(ex.Message);
                    }
                }
            }
            return plan;
        }

    }
}
