using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class clsMembershipHistoryDTO
    {
        public int MemberShipID { get; set; }
        public string PlanName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; } // نصي يستقبل 'Active' أو 'Expired'
    }
}
