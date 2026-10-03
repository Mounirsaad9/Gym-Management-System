using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class clsMemberShipModel
    {
        public int MemberShipID { get; set; }

        public int MemberID { get; set; }
        public int PlanID { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public bool IsActive { get; set; }

    }
}
