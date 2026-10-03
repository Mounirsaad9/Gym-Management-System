using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class clsAuditLogDTO
    {
        public int LogID { get; set; }
        public DateTime ActionDate { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string ActionType { get; set; }
        public string TableName { get; set; }
        public int? RecordID { get; set; }
        public string ActionDetails { get; set; }
        public string HostName { get; set; }
    }
}
