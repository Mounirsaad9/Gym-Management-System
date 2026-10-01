using System;
using System.Windows.Forms;
using clsBusinessLayer;

namespace Gym
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // تشغيل التطبيق عبر الـ ApplicationContext الخاص بنا
             Application.Run(new clsAppContext());
            //Application.Run(new test());
        }
    }

    public class clsAppContext : ApplicationContext
    {
        private bool _isFirstRunInDebug = true;

        public clsAppContext()
        {
            ResetCurrentUser();
            StartApplicationFlow();
        }

        private void StartApplicationFlow()
        {
#if DEBUG
            // إذا كنا في وضع الـ DEBUG والتشغيل الأول: نقوم بالدخول التلقائي
            if (_isFirstRunInDebug)
            {
                _isFirstRunInDebug = false;
                if (TryDebugAutoLogin())
                {
                    ShowMainForm();
                    return;
                }
            }
#endif
            // في وضع الـ RELEASE أو إذا فشل الـ Auto-Login أو بعد Logout: يفتح شاشة الدخول
            ShowLogin();
        }

#if DEBUG
        private bool TryDebugAutoLogin()
        {
            int debugUserID = 6;
            clsUser debugUser = clsUser.GetUserInfoByID(debugUserID);

            if (debugUser != null)
            {
                clsCurrentUser.UserID = debugUser.UserData.UserID;
                clsCurrentUser.UserName = debugUser.UserData.UserName;
                clsCurrentUser.FullName = debugUser.UserData.FullName;
                clsCurrentUser.Role = debugUser.UserData.Role;

                clsAuditLog.Log(
                    userID: clsCurrentUser.UserID,
                    actionType: "LOGIN",
                    tableName: "Users",
                    recordID: clsCurrentUser.UserID,
                    actionDetails: $"Auto-Login (Debug Mode) for user '{clsCurrentUser.UserName}'"
                );

                return true;
            }

            return false;
        }
#endif

        private void ShowLogin()
        {
            ResetCurrentUser();

            frmLogin login = new frmLogin();
            login.FormClosed += OnLoginClosed;
            login.Show();
        }

        private void ShowMainForm()
        {
            frmMain frm = new frmMain();
            frm.FormClosed += OnMainFormClosed;
            frm.Show();
        }

        private void OnLoginClosed(object sender, FormClosedEventArgs e)
        {
            // التحقق من النجاح عبر وجود UserID أو Role (يفضل استخدام UserID > 0)
            if (clsCurrentUser.UserID > 0 || !string.IsNullOrEmpty(clsCurrentUser.Role))
            {
                ShowMainForm();
            }
            else
            {
                ExitThread(); // إنهاء التطبيق بنظافة إذا أغلق شاشة اللوجن دون دخول
            }
        }

        private void OnMainFormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain mainForm = sender as frmMain;

            if (mainForm != null && mainForm.UserLoggedOut)
            {
                // إذا سجل خروج، يعود لشاشة تسجيل الدخول
                StartApplicationFlow();
            }
            else
            {
                // إذا أغلق الشاشة من زر (X) ينتهي البرنامج
                ExitThread();
            }
        }

        private void ResetCurrentUser()
        {
            // يمكنك استخدام clsCurrentUser.LogOut() إذا كانت تؤدي نفس الغرض
            clsCurrentUser.UserID = 0;
            clsCurrentUser.UserName = string.Empty;
            clsCurrentUser.FullName = string.Empty;
            clsCurrentUser.Role = string.Empty;
        }
    }
}