using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class GovernorateTbl
    {
        public GovernorateTbl()
        {
            EmployeeAddressTbl = new HashSet<EmployeeAddressTbl>();
            EmployeeRelativeTbl = new HashSet<EmployeeRelativeTbl>();
            EmployeeTbl = new HashSet<EmployeeTbl>();
            OrganizationLegalFormTbl = new HashSet<OrganizationLegalFormTbl>();
        }

        public long GovernorateId { get; set; }
        public long? PropertyId { get; set; }
        public string GovernorateCode { get; set; }
        public string GovernorateEnName { get; set; }
        public string GovernorateArName { get; set; }
        public string GovernorateArNameShadow { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<EmployeeAddressTbl> EmployeeAddressTbl { get; set; }
        public virtual ICollection<EmployeeRelativeTbl> EmployeeRelativeTbl { get; set; }
        public virtual ICollection<EmployeeTbl> EmployeeTbl { get; set; }
        public virtual ICollection<OrganizationLegalFormTbl> OrganizationLegalFormTbl { get; set; }
    }
}
