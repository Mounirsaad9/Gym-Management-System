using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class clsPaymentsModel
    {
        public int PaymentID { get; set; }

        public int MemberShipID { get; set; }

        public DateTime PaymentDate { get; set; }

        public decimal Amount { get; set; }

        public string Notes { get; set; }


    }
}
