using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ResidencyTypeTbl
    {
        public ResidencyTypeTbl()
        {
            EmployeeRelativeTbl = new HashSet<EmployeeRelativeTbl>();
            EmployeeTbl = new HashSet<EmployeeTbl>();
            ResidencyRenewalTransactionTbl = new HashSet<ResidencyRenewalTransactionTbl>();
        }

        public long ResidencyTypeId { get; set; }
        public long? PropertyId { get; set; }
        public string ResidencyTypeCode { get; set; }
        public string ResidencyTypeEnName { get; set; }
        public string ResidencyTypeArName { get; set; }
        public string ResidencyTypeArNameShadow { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<EmployeeRelativeTbl> EmployeeRelativeTbl { get; set; }
        public virtual ICollection<EmployeeTbl> EmployeeTbl { get; set; }
        public virtual ICollection<ResidencyRenewalTransactionTbl> ResidencyRenewalTransactionTbl { get; set; }
    }
}
