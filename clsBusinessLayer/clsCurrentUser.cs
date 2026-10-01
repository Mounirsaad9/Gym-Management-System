using System;

namespace clsBusinessLayer
{
    public static class clsCurrentUser
    {
        public static int UserID { get; set; } = -1; // 🌟 القيمة الافتراضية -1 تعني لا يوجد مستخدم
        public static string UserName { get; set; } = "";
        public static string FullName { get; set; } = "";
        public static string Role { get; set; } = "";

        // 🌟 1. خاصية سريعة لمعرفة هل يوجد مستخدم مسجل دخوله حالياً أم لا
        public static bool IsLoggedIn => UserID > 0;

        // 🌟 2. التحقق من صلاحية الأدمن بشكل غير حساس لحالة الأحرف (Admin / admin)
        public static bool IsAdmin()
        {
            return string.Equals(Role, "Admin", StringComparison.OrdinalIgnoreCase);
        }

        public static void LogOut()
        {
            UserID = -1;
            UserName = "";
            FullName = "";
            Role = "";
        }
    }
}