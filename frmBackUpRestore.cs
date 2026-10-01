using System;
using System.IO;
using System.Windows.Forms;
using clsBusinessLayer;

namespace Gym
{
    public partial class frmBackupRestore : BaseForm
    {
        public frmBackupRestore()
        {
            InitializeComponent();
        }

        private void frmBackupRestore_Load(object sender, EventArgs e)
        {
            txtBackupPath.TextValue = clsDatabase.GetDefaultBackupFolder();
        }

        private void btnBrowseBackup_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select Destination Folder for Backup";
                if (Directory.Exists(txtBackupPath.TextValue))
                {
                    folderDialog.SelectedPath = txtBackupPath.TextValue;
                }

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtBackupPath.TextValue = folderDialog.SelectedPath;
                }
            }
        }

        private void btnCreateBackup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBackupPath.TextValue))
            {
                MessageBox.Show("Please select a valid folder path first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to create a manual database backup?",
                "Confirm Backup",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            string fileName = $"Gym_Backup_{DateTime.Now:yyyy_MM_dd_HHmmss}.bak";
            string fullPath = Path.Combine(txtBackupPath.TextValue, fileName);

            try
            {
                if (clsDatabase.PerformBackup(fullPath))
                {
                    // تسجيل الحركة في الـ Audit Log
                    clsAuditLog.Log(
                        userID: clsCurrentUser.UserID,
                        actionType: "BACKUP",
                        tableName: "Database",
                        recordID: 0,
                        actionDetails: $"Backup created at: {fullPath}"
                    );

                    MessageBox.Show($"Backup created successfully!\n\nPath: {fullPath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Backup process failed:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowseRestore_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Backup Files (*.bak)|*.bak";
                openFileDialog.Title = "Select Backup File to Restore";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtRestorePath.TextValue = openFileDialog.FileName;
                }
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRestorePath.TextValue) || !File.Exists(txtRestorePath.TextValue))
            {
                MessageBox.Show("Please select a valid (.bak) backup file.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "CRITICAL WARNING:\nRestoring the database will overwrite all existing data with the selected backup!\n\nAre you absolutely sure you want to proceed?",
                "Confirm Database Restore",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (clsDatabase.PerformRestore(txtRestorePath.TextValue))
                {
                    clsAuditLog.Log(
                        userID: clsCurrentUser.UserID,
                        actionType: "RESTORE",
                        tableName: "Database",
                        recordID: 0,
                        actionDetails: $"Restored database from: {txtRestorePath.TextValue}"
                    );

                    MessageBox.Show("Database restored successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Restore process failed:\n{ex.Message}", "Restore Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseWithFadeOut();
        }
    }
}