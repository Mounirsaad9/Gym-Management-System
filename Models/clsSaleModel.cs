using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class clsSaleModel
    {

        public int SaleID { get; set; }
        public int? MemberID { get; set; }
        public int UserID { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal TotalAmount { get; set; }

    }
}
