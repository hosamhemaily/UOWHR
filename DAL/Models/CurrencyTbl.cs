using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CurrencyTbl
    {
        public CurrencyTbl()
        {
            EmployeeMonthlySalaryTbl = new HashSet<EmployeeMonthlySalaryTbl>();
            EmployeePaymentModeTbl = new HashSet<EmployeePaymentModeTbl>();
            EmployeeTbl = new HashSet<EmployeeTbl>();
        }

        public long CurrencyId { get; set; }
        public long? PropertyId { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyEnName { get; set; }
        public string CurrencyArName { get; set; }
        public string CurrencyArNameShadow { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public int? NoOfDecimal { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public string CurrencyConversion { get; set; }

        public virtual ICollection<EmployeeMonthlySalaryTbl> EmployeeMonthlySalaryTbl { get; set; }
        public virtual ICollection<EmployeePaymentModeTbl> EmployeePaymentModeTbl { get; set; }
        public virtual ICollection<EmployeeTbl> EmployeeTbl { get; set; }
    }
}
