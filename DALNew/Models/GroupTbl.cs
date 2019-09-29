using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class GroupTbl
    {
        public GroupTbl()
        {
            EmployeeGroupTbl = new HashSet<EmployeeGroupTbl>();
        }

        public long GroupId { get; set; }
        public long? PropertyId { get; set; }
        public string GroupCode { get; set; }
        public string GroupEnName { get; set; }
        public string GroupArName { get; set; }
        public string GroupArNameShadow { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<EmployeeGroupTbl> EmployeeGroupTbl { get; set; }
    }
}
