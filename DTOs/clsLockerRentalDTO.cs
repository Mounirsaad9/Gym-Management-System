using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class clsLockerRentalDTO
    {
        public int RentalID { get; set; }
        public int LockerID { get; set; }
        public string LockerNumber { get; set; }
        public int MemberID { get; set; }
        public string MemberFullName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int RentalDays { get; set; }
        public decimal TotalAmount { get; set; }
        public bool IsActive { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }
        public string CreatedByUserName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
