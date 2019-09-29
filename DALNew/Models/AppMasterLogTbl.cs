using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class AppMasterLogTbl
    {
        public AppMasterLogTbl()
        {
            AppDetailsLogTbl = new HashSet<AppDetailsLogTbl>();
        }

        public long MasterLogId { get; set; }
        public long? PropertyId { get; set; }
        public long? FormId { get; set; }
        public long? RecId { get; set; }
        public long? EmployeeId { get; set; }
        public long? AppUserId { get; set; }
        public long? UserGroupId { get; set; }
        public string ActionType { get; set; }
        public string DescriptionEn { get; set; }
        public string DescriptionAr { get; set; }
        public long? UserId { get; set; }
        public DateTime? ActionDate { get; set; }
        public long? MachineId { get; set; }

        public virtual ICollection<AppDetailsLogTbl> AppDetailsLogTbl { get; set; }
    }
}
