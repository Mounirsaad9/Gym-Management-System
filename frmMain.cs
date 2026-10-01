using clsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class frmMain : BaseForm
    {
        
        private UserControl _activeUserControl = null;
        public bool UserLoggedOut
        { get; private set; } = false;
        public frmMain()
        {
            InitializeComponent();
           
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            // إعادة إجبار الـ UserControl النشط على ملء الـ panelContainer
            if (_activeUserControl != null && !_activeUserControl.IsDisposed)
            {
                _activeUserControl.Size = panelContainer.ClientSize;
            }
        }

        private void DisplayScreen(UserControl uc)
        {
           
            if (_activeUserControl != null && _activeUserControl.GetType() == uc.GetType())
                return;

            
            if (!CloseActiveScreensWithConfirmation())
            {
                uc.Dispose(); 
                return;
            }

            
            _activeUserControl = uc;
            uc.AutoSize = false;
            uc.Dock = DockStyle.Fill;
            uc.Disposed += (s, e) =>
            {
                _activeUserControl = null;
                HandleLogoVisibility();
            };
            panelContainer.Controls.Add(uc);
            uc.Size = panelContainer.ClientSize;
            uc.BringToFront();
        }

        private bool CloseActiveScreensWithConfirmation()
        {
            
            if (_activeUserControl != null)
            {
                DialogResult result = MessageBox.Show(
                    "This window will close and you will move to another window.\nDo you want to continue?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                
                if (result == DialogResult.No)
                {
                    return false;
                }
            }

            
            
            if (_activeUserControl != null) { _activeUserControl.Dispose(); _activeUserControl = null; }

            picLogo.Visible = false;
            return true; 
        }

        private void HandleLogoVisibility()
        {
            if (_activeUserControl == null)
            {
                picLogo.Visible = true;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            

            lblCurrentUser.Text = $"Welcome, {clsCurrentUser.UserName} ({clsCurrentUser.Role})";
            
        }

        private void roundedButtonChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            frm.Show();
        }

        private void roundedButtonLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want to LogOut?", "LogOut", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {

                // 1. 📝 تسجيل حركة تسجيل الخروج في الـ Audit Log
                clsAuditLog.Log(
                    userID: clsCurrentUser.UserID,
                    actionType: "LOGOUT",
                    tableName: "Users",
                    recordID: clsCurrentUser.UserID,
                    actionDetails: $"User '{clsCurrentUser.UserName}' logged out of the system"
                );

                UserLoggedOut = true;
                CloseWithFadeOut();
            }
        }

        private void roundedButtonMembers_Click(object sender, EventArgs e)
        {
            

            DisplayScreen(new ucListMembers());
        }

        private void roundedButtonListUsers_Click(object sender, EventArgs e)
        {
            if (!clsCurrentUser.IsAdmin())
            {
                MessageBox.Show("Access Denied. Admin Only.");

                return;
            }


            DisplayScreen(new ucListUsers());
        }

        private void roundedButtonProducts_Click(object sender, EventArgs e)
        {
            if (!clsCurrentUser.IsAdmin())
            {
                MessageBox.Show("Access Denied. Admin Only.");

                return;
            }

            DisplayScreen(new ucListProducts());
        }

        private void btnSalesInvoice_Click(object sender, EventArgs e)
        {
            
            DisplayScreen(new ucSales());
        }

        private void btnSalesHistory_Click(object sender, EventArgs e)
        {
           frmSalesHistory frm = new frmSalesHistory();
            frm.Show();
        }

        private void btnAuditLogs_Click(object sender, EventArgs e)
        {
            if (!clsCurrentUser.IsAdmin())
            {
                MessageBox.Show("Access Denied. Admin Only.");

                return;
            }

            DisplayScreen(new ucAuditLogs());
        }

        private void btnMemberShipAlerts_Click(object sender, EventArgs e)
        {
            frmMemberShipsAlerts frm = new frmMemberShipsAlerts();
            frm.Show();
        }

        private void btnLockers_Click(object sender, EventArgs e)
        {
            DisplayScreen(new ucLockerManagement());
        }

        private void btnBackUpRestore_Click(object sender, EventArgs e)
        {
            frmBackupRestore frm = new frmBackupRestore();
            frm.Show();
        }



        //private async void btnTestForm_Click(object sender, EventArgs e)
        //{
        //    int totalIterations = 300;

        //    long initialMemory = GC.GetTotalMemory(true);

        //    for (int i = 1; i <= totalIterations; i++)
        //    {
        //        // 1️⃣ إنشاء Form وهمي موقت يستضيف الـ UserControl
        //        using (Form hostForm = new Form())
        //        {
        //            hostForm.Size = new Size(1000, 700);
        //            hostForm.StartPosition = FormStartPosition.CenterScreen;

        //            // 2️⃣ إنشاء الـ User Control الذي تريد اختباره (استبدل ucSales باسم الـ User Control لديك)
        //            using (ucSales testUC = new ucSales())
        //            {
        //                testUC.Dock = DockStyle.Fill;
        //                hostForm.Controls.Add(testUC); // إضافة الـ UC داخل الفنـاء

        //                // إظهار الشاشة الحاضنة
        //                hostForm.Show();
        //                Application.DoEvents();

        //                await Task.Delay(10); // مهلة بسيطة للمشاهدة

        //                // إزالة الـ Control وإغلاق الشاشة
        //                hostForm.Controls.Remove(testUC);
        //                hostForm.Close();
        //                Application.DoEvents();
        //            }
        //        }

        //        // طباعة النتيجة كل 50 دورة
        //        if (i % 50 == 0)
        //        {
        //            long currentMemory = GC.GetTotalMemory(false);
        //            Console.WriteLine($"دورة {i}/{totalIterations} | الذاكرة الحالية: {currentMemory / 1024.0 / 1024.0:F2} MB");
        //        }
        //    }

        //    // تنظيف قسري للذاكرة
        //    GC.Collect();
        //    GC.WaitForPendingFinalizers();
        //    GC.Collect();

        //    long finalMemory = GC.GetTotalMemory(true);

        //    double initialMB = initialMemory / 1024.0 / 1024.0;
        //    double finalMB = finalMemory / 1024.0 / 1024.0;

        //    MessageBox.Show($"تم إنهاء اختبار الـ User Control بنجاح!\nالذاكرة الابتدائية: {initialMB:F2} MB\nالذاكرة النهائية: {finalMB:F2} MB",
        //                    "UC Memory Test Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

    }
}
