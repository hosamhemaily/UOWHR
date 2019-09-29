using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MilitaryStatusTbl
    {
        public MilitaryStatusTbl()
        {
            EmployeeTbl = new HashSet<EmployeeTbl>();
        }

        public long MilitaryStatusId { get; set; }
        public long? PropertyId { get; set; }
        public string MilitaryStatusCode { get; set; }
        public string MilitaryStatusEnName { get; set; }
        public string MilitaryStatusArName { get; set; }
        public string MilitaryStatusArNameShadow { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<EmployeeTbl> EmployeeTbl { get; set; }
    }
}
