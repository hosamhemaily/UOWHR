using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class NationalityTbl
    {
        public NationalityTbl()
        {
            EmployeeRelativeTbl = new HashSet<EmployeeRelativeTbl>();
            EmployeeTbl = new HashSet<EmployeeTbl>();
        }

        public long NationalityId { get; set; }
        public long? PropertyId { get; set; }
        public string NationalityCode { get; set; }
        public string NationalityEnName { get; set; }
        public string NationalityArName { get; set; }
        public string NationalityArNameShadow { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<EmployeeRelativeTbl> EmployeeRelativeTbl { get; set; }
        public virtual ICollection<EmployeeTbl> EmployeeTbl { get; set; }
    }
}
