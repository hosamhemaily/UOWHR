using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class EmployeeGroupTbl
    {
        public long EmployeeGroupId { get; set; }
        public long? EmployeeId { get; set; }
        public long? GroupId { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual EmployeeTbl Employee { get; set; }
        public virtual GroupTbl Group { get; set; }
    }
}
