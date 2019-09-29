using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class SponsorTbl
    {
        public SponsorTbl()
        {
            EmployeeRelativeTbl = new HashSet<EmployeeRelativeTbl>();
            EmployeeTbl = new HashSet<EmployeeTbl>();
        }

        public long SponsorId { get; set; }
        public long? PropertyId { get; set; }
        public string SponsorCode { get; set; }
        public string SponsorEnName { get; set; }
        public string SponsorArName { get; set; }
        public string SponsorArNameShadow { get; set; }
        public byte? SponsorTypeId { get; set; }
        public string CommercialLicense { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual SponsorTypeTbl SponsorType { get; set; }
        public virtual ICollection<EmployeeRelativeTbl> EmployeeRelativeTbl { get; set; }
        public virtual ICollection<EmployeeTbl> EmployeeTbl { get; set; }
    }
}
