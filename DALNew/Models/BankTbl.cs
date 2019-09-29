using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class BankTbl
    {
        public BankTbl()
        {
            EmployeePaymentModeTbl = new HashSet<EmployeePaymentModeTbl>();
        }

        public long BankId { get; set; }
        public long? PropertyId { get; set; }
        public string BankCode { get; set; }
        public string BankEnName { get; set; }
        public string BankArName { get; set; }
        public string BankArNameShadow { get; set; }
        public string BankAccountNumber { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<EmployeePaymentModeTbl> EmployeePaymentModeTbl { get; set; }
    }
}
