using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class clsMembershipAlertDTO
    {
        public int MembershipID { get; set; }
        public int MemberID { get; set; }
        public string MemberFullName { get; set; }
        public string Phone { get; set; }
        public string PlanName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int DaysRemaining { get; set; }
        public string IsActive { get; set; }

        public string DisplayDaysRemaining
        {
            get
            {
                if (DaysRemaining < 0)
                    return $"Expired {Math.Abs(DaysRemaining)} Days ago"; 
                else if (DaysRemaining == 0)
                    return "Ends Today";
                else
                    return $"{DaysRemaining} Days Left";
            }
        }
    }
}
