using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class clsLockerDTO
    {
        public int LockerID { get; set; }
        public string LockerNumber { get; set; }
        public byte StatusID { get; set; }
        public string StatusName { get; set; } // "Available", "Rented", "Under Maintenance"

        // بيانات العقد النشط الحالي (إن وجد)
        public int? CurrentRentalID { get; set; }
        public int? MemberID { get; set; }
        public string MemberFullName { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
