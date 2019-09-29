using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ReligionTbl
    {
        public ReligionTbl()
        {
            EmployeeRelativeTbl = new HashSet<EmployeeRelativeTbl>();
            EmployeeTbl = new HashSet<EmployeeTbl>();
        }

        public long ReligionId { get; set; }
        public long? PropertyId { get; set; }
        public string ReligionCode { get; set; }
        public string ReligionEnName { get; set; }
        public string ReligionArName { get; set; }
        public string ReligionArNameShadow { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<EmployeeRelativeTbl> EmployeeRelativeTbl { get; set; }
        public virtual ICollection<EmployeeTbl> EmployeeTbl { get; set; }
    }
}
