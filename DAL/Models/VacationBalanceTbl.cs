using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VacationBalanceTbl
    {
        public VacationBalanceTbl()
        {
            VacationBalanceDetailsTbl = new HashSet<VacationBalanceDetailsTbl>();
        }

        public long VacationBalanceId { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public int? TheYear { get; set; }
        public DateTime? ContractDate { get; set; }
        public byte? VacationCategoryId { get; set; }
        public double? VacationOpeningBalance { get; set; }
        public bool? SettlementYn { get; set; }
        public bool? ActiveYn { get; set; }

        public virtual EmployeeTbl Employee { get; set; }
        public virtual VacationCategoryTbl VacationCategory { get; set; }
        public virtual ICollection<VacationBalanceDetailsTbl> VacationBalanceDetailsTbl { get; set; }
    }
}
