using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class clsSubscriptionPlansModel
    {
        public int PlanID { get; set; }

        public string PlanName { get; set; }

        public int DurationDays { get; set; }

        public decimal Price { get; set; }

    }
}
