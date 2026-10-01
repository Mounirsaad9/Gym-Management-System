using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using clsDataAccess;
using Models;

namespace clsBusinessLayer
{
    public class clsSubscriptionPlans
    {
        public enum enSaveResult
        {
            Success,
            InvalidName,
            InvalidDuration,
            InvalidPrice,
            Failed
        }

        private clsSubscriptionPlansModel _SubscriptionPlans = new clsSubscriptionPlansModel();

        public clsSubscriptionPlansModel MemberPlan
        {
            get { return _SubscriptionPlans; }
        }

        private enSaveResult _Validate()
        {
            // التحقق من الاسم
            if (string.IsNullOrWhiteSpace(_SubscriptionPlans.PlanName))
                return enSaveResult.InvalidName;

            // التحقق من المدة (يجب أن تكون يوم واحد على الأقل)
            if (_SubscriptionPlans.DurationDays <= 0)
                return enSaveResult.InvalidDuration;

            // التحقق من السعر (لا يمكن أن يكون سالباً، ويمكن أن يكون 0 لو هناك خطة مجانية)
            if (_SubscriptionPlans.Price < 0)
                return enSaveResult.InvalidPrice;

            return enSaveResult.Success;
        }

        // 3. إرجاع List بدلاً من DataTable
        public static List<clsSubscriptionPlansModel> GetAllSubscriptionPlans()
        {
            return clsSubscriptionPlansData.GetAllSubscriptionPlans();
        }

        // 4. تعديل دالة الحفظ لتستخدم التحقق وتمرر الكائن بالكامل
        public enSaveResult UpdatePlan()
        {
            // أولاً: إجراء التحقق النهائي
            enSaveResult validationResult = _Validate();

            // إذا فشل التحقق، نرجع السبب للواجهة فوراً دون الاتصال بقاعدة البيانات
            if (validationResult != enSaveResult.Success)
                return validationResult;

            // ثانياً: إذا نجح التحقق، نرسل الكائن بالكامل لطبقة DAL
            bool isSaved = clsSubscriptionPlansData.UpdateSubscriptionPlans(_SubscriptionPlans);

            return isSaved ? enSaveResult.Success : enSaveResult.Failed;
        }

        public clsSubscriptionPlans GetSubscriptionPlanInfoByID(int PlanID)
        {
            clsSubscriptionPlansModel subscriptionPlans = clsSubscriptionPlansData.GetSubscriptionPlanInfoByID(PlanID);

            if (subscriptionPlans != null)
            {
                _SubscriptionPlans = subscriptionPlans;
                return this;
            }

            return null;
        }

        public static string GetPlanNameByID(int PlanID)
        {
            clsSubscriptionPlansModel plan = clsSubscriptionPlansData.GetSubscriptionPlanInfoByID(PlanID);

            if (plan != null)
            {
                return plan.PlanName;
            }
            return "Unknown Plan";
        }
    }
}
