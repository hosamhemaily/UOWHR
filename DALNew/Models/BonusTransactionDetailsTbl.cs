using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class BonusTransactionDetailsTbl
    {
        public long BonusTransactionDetailsId { get; set; }
        public long? BonusTransactionId { get; set; }
        public long? EmployeeId { get; set; }
        public double? BonusValueBeforeCalc { get; set; }
        public double? BonusTax { get; set; }
        public double? BonusValueAfterCalc { get; set; }
        public double? BonusNet { get; set; }
        public long? CurrencyId { get; set; }
        public bool? ActiveYn { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual BonusTransactionTbl BonusTransaction { get; set; }
        public virtual EmployeeTbl Employee { get; set; }
    }
}
