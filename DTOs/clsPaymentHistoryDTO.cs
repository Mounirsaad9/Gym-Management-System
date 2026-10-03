using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class clsPaymentHistoryDTO
    {
        public int PaymentID { get; set; }
        public string PaymentDate { get; set; } // نصي لأن الاستعلام يحوله بصيغة 103
        public decimal Amount { get; set; }
        public string PlanName { get; set; }
        public string Notes { get; set; }
    }
}
