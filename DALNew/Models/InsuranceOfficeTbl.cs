using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class InsuranceOfficeTbl
    {
        public InsuranceOfficeTbl()
        {
            EmployeeTbl = new HashSet<EmployeeTbl>();
            OrganizationLegalFormTbl = new HashSet<OrganizationLegalFormTbl>();
        }

        public long InsuranceOfficeId { get; set; }
        public long? PropertyId { get; set; }
        public string InsuranceOfficeCode { get; set; }
        public string InsuranceOfficeEnName { get; set; }
        public string InsuranceOfficeArName { get; set; }
        public string InsuranceOfficeArNameShadow { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<EmployeeTbl> EmployeeTbl { get; set; }
        public virtual ICollection<OrganizationLegalFormTbl> OrganizationLegalFormTbl { get; set; }
    }
}
