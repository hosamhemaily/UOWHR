using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class EmployeePaymentModeTbl
    {
        public long EmployeePaymentModeId { get; set; }
        public long? EmployeeId { get; set; }
        public int? TheYear { get; set; }
        public int? TheMonth { get; set; }
        public byte? PaymentModeTypeId { get; set; }
        public byte? PaymentFunctionId { get; set; }
        public double? PaymentModeValue { get; set; }
        public long? CurrencyId { get; set; }
        public long? BankId { get; set; }
        public string BankBranchNumber { get; set; }
        public string BankAccountNumber { get; set; }
        public string BankEmployeeNumber { get; set; }
        public bool? DefaultYn { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public bool? ShowInWbsYn { get; set; }

        public virtual BankTbl Bank { get; set; }
        public virtual CurrencyTbl Currency { get; set; }
        public virtual EmployeeTbl Employee { get; set; }
        public virtual PaymentFunctionTbl PaymentFunction { get; set; }
        public virtual PaymentModeTypeTbl PaymentModeType { get; set; }
    }
}
