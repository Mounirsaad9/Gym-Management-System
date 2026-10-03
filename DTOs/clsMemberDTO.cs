using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{

    public class clsMemberDTO
    {
        public int MemberID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gendor { get; set; } // تم تحويله لـ string لأن الفيو تُرجع 'Male' أو 'Female'
        public int MemberShipID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string PlanName { get; set; }
        public string IsActive { get; set; } // تم تحويله لـ string لأن الفيو تُرجع 'Active' أو 'Expired' أو 'Frozen'
    }
}
