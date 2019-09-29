using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class CountryTbl
    {
        public CountryTbl()
        {
            EmployeeAddressTbl = new HashSet<EmployeeAddressTbl>();
            EmployeeRelativeTbl = new HashSet<EmployeeRelativeTbl>();
        }

        public long CountryId { get; set; }
        public long? PropertyId { get; set; }
        public string CountryCode { get; set; }
        public string CountryEnName { get; set; }
        public string CountryArName { get; set; }
        public string CountryArNameShadow { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<EmployeeAddressTbl> EmployeeAddressTbl { get; set; }
        public virtual ICollection<EmployeeRelativeTbl> EmployeeRelativeTbl { get; set; }
    }
}
