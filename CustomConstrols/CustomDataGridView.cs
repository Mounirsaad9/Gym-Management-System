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
    public partial class CustomDataGridView : DataGridView
    {
        private int _maxVisibleRows = 8;

        // خصائص إضافية يمكن التحكم بها من الـ Properties Window في الـ Designer
        public int MaxVisibleRows
        {
            get => _maxVisibleRows;
            set
            {
                _maxVisibleRows = value;
                Invalidate();
            }
        }

        public CustomDataGridView()
        {
            // تطبيق التصميم التلقائي عند إنشاء الكونترول
            _EditDesignDGV();

            // تفعيل الـ AutoFill للأعمدة افتراضياً لملء المساحة
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // منع إضافة صفوف فارغة أوتوماتيكياً
            this.AllowUserToAddRows = false;

            // إعدادات جمالية عامة
            this.BorderStyle = BorderStyle.None;
            this.RowHeadersVisible = false;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.MultiSelect = false;
        }

        // دالة التصميم والهوية البصرية الموحدة
        private void _EditDesignDGV()
        {
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.BackColor = Color.FromArgb(30, 35, 50);
            headerStyle.ForeColor = Color.FromArgb(220, 220, 190);
            headerStyle.SelectionBackColor = Color.FromArgb(50, 60, 130);
            headerStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.ColumnHeadersDefaultCellStyle = headerStyle;
            this.EnableHeadersVisualStyles = false;

            DataGridViewCellStyle rowStyle = new DataGridViewCellStyle();
            rowStyle.BackColor = Color.FromArgb(28, 28, 28);
            //rowStyle.ForeColor = Color.WhiteSmoke;
            rowStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            rowStyle.SelectionBackColor = Color.FromArgb(40, 50, 70);
            //rowStyle.SelectionForeColor = Color.White;
            rowStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.RowsDefaultCellStyle = rowStyle;

            this.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(35, 35, 35);
            this.RowTemplate.Height = 40;
        }

        // دالة أوتوماتيكية لضبط ارتفاع الجدول بناءً على عدد العناصر (الـ AutoScroll الذكي)
        public void AdjustGridHeight(int itemsCount)
        {
            int rowHeight = this.RowTemplate.Height;
            int headerHeight = this.ColumnHeadersHeight;

            int visibleRows = Math.Min(itemsCount, _maxVisibleRows);

            this.Height = headerHeight + (visibleRows * rowHeight) + 2;
        }
    }
}
