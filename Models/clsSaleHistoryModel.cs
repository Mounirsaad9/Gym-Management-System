using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class clsSaleHistoryModel
    {

        public int SaleID { get; set; }
        public string MemberName { get; set; }
        public string UserName { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal TotalAmount { get; set; }

    }
}
