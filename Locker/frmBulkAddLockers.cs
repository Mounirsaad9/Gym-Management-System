using clsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class frmBulkAddLockers : BaseForm
    {
        private string _highestLockerNumber = string.Empty;
        private int _highestNumericValue = 0;

        public frmBulkAddLockers()
        {
            InitializeComponent();
        }

        private void frmBulkAddLockers_Load(object sender, EventArgs e)
        {
            _LoadInitialData();
        }

        private void _LoadInitialData()
        {
           
            _highestLockerNumber = clsLocker.GetHighestLockerNumber();

            if (!string.IsNullOrEmpty(_highestLockerNumber))
            {
                lblHighestLocker.Text = $"Highest Locker: {_highestLockerNumber}";

                //استخراج الجزء الرقمي
                Match match = Regex.Match(_highestLockerNumber, @"\d+");
                if (match.Success)
                {
                    _highestNumericValue = int.Parse(match.Value);

                    // استخراج البادئة
                    int numberIndex = _highestLockerNumber.IndexOf(match.Value);
                    txtPrefix.TextValue = _highestLockerNumber.Substring(0, numberIndex);
                }
            }
            else
            {
                lblHighestLocker.Text = "Highest Locker: None (Database is Empty)";
                txtPrefix.TextValue = "L-";
                _highestNumericValue = 0;
            }

            
            txtStartNumber.TextValue = (_highestNumericValue + 1).ToString();
            txtCount.TextValue = "10";

          
            _UpdatePreviewStatus();
        }

        /// <summary>
        /// دالة المعاينة الحية والتفاعل مع إدخالات المستخدم لحظياً
        /// </summary>
        private void _UpdatePreviewStatus()
        {
            
            if (!int.TryParse(txtStartNumber.TextValue.Trim(), out int startNumber) || startNumber <= 0 ||
                !int.TryParse(txtCount.TextValue.Trim(), out int count) || count <= 0)
            {
                lblPreviewStatus.Text = "⚠️ Please enter valid positive numbers for Start Number and Count.";
                pnlPreview.BackColor = Color.FromArgb(60, 50, 20); 
                lblPreviewStatus.ForeColor = Color.Khaki;
                btnSave.Enabled = false;
                return;
            }

            if (_highestNumericValue > 0 && startNumber > _highestNumericValue + 1)
            {
                lblPreviewStatus.Text = $"⚠️ Sequence Gap: Start Number cannot skip numbers!\n" +
                    $" Next valid number is {_highestNumericValue + 1}.";
                pnlPreview.BackColor = Color.FromArgb(70, 45, 10); 
                lblPreviewStatus.ForeColor = Color.Orange;
                btnSave.Enabled = false; 
                return; 
            }

            string prefix = txtPrefix.TextValue.Trim();
            int endNumber = startNumber + count - 1;

            
            if (startNumber > _highestNumericValue)
            {
                lblPreviewStatus.Text = $"✅ Ready: Will create {count} new lockers from {prefix}{startNumber} to {prefix}{endNumber}.";
                pnlPreview.BackColor = Color.FromArgb(20, 60, 30);
                lblPreviewStatus.ForeColor = Color.LightGreen;
                btnSave.Enabled = true;
            }
            
            else if (endNumber <= _highestNumericValue)
            {
                lblPreviewStatus.Text = $"⛔ Warning: All lockers from {prefix}{startNumber} to {prefix}{endNumber} already exist!";
                pnlPreview.BackColor = Color.FromArgb(70, 20, 20);
                lblPreviewStatus.ForeColor = Color.Coral;
                btnSave.Enabled = false; 
            }
            
            else
            {
                int newCount = endNumber - _highestNumericValue;
                int firstNewNumber = _highestNumericValue + 1;

                lblPreviewStatus.Text = $"⚠️ Notice: Lockers up to {prefix}{_highestNumericValue} exist.\n" +
                    $" Only {newCount} new lockers ({prefix}{firstNewNumber} to {prefix}{endNumber}) will be created.";
                pnlPreview.BackColor = Color.FromArgb(70, 45, 10);
                lblPreviewStatus.ForeColor = Color.Orange;
                btnSave.Enabled = true;
            }
        }

        private void btnSuggest_Click(object sender, EventArgs e)
        {
            int nextAvailable = clsLocker.GetNextLockerNumber(txtPrefix.TextValue.Trim());
            txtStartNumber.TextValue = nextAvailable.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseWithFadeOut();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtStartNumber.TextValue.Trim(), out int startNumber) ||
                !int.TryParse(txtCount.TextValue.Trim(), out int count))
            {
                MessageBox.Show("Invalid input values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string prefix = txtPrefix.TextValue.Trim();

            
            int insertedCount = clsLocker.AddBulkLockers(count, startNumber, prefix);

            if (insertedCount > 0)
            {
                MessageBox.Show($"Successfully added {insertedCount} lockers out of {count} requested.",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                CloseWithFadeOut();
            }
            else
            {
                MessageBox.Show("No lockers were inserted. All requested numbers might already exist.",
                                "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtInput_TextValueChanged()
        {
            _UpdatePreviewStatus();
        }
    }
}
