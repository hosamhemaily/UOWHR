using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ServiceChargeTransactionTbl
    {
        public ServiceChargeTransactionTbl()
        {
            ServiceChargeTransactionDetailsTbl = new HashSet<ServiceChargeTransactionDetailsTbl>();
        }

        public long ServiceChargeTransactionId { get; set; }
        public long? PropertyId { get; set; }
        public int? TheYear { get; set; }
        public int? TheMonth { get; set; }
        public bool? WholePropertyYn { get; set; }
        public long? BranchId { get; set; }
        public bool? CalculateServiceChargeForPastMonthSalaryYn { get; set; }
        public bool? IncludeSettelmentEmployeesYn { get; set; }
        public byte? ServiceChargeWay { get; set; }
        public double? GuestContactRate { get; set; }
        public double? NonGuestContactRate { get; set; }
        public double? TotalAmount { get; set; }
        public double? GuestContactAmount { get; set; }
        public double? NonGuestContactAmount { get; set; }
        public double? EmployeesAmount { get; set; }
        public double? BrokenAmount { get; set; }
        public double? BonusAmount { get; set; }
        public double? GuestContactSalaries { get; set; }
        public double? NonGuestContactSalaries { get; set; }
        public double? GuarantySalaries { get; set; }
        public double? NetSalaries { get; set; }
        public bool? CalculatedYn { get; set; }
        public bool? PaidYn { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual PropertyTbl Property { get; set; }
        public virtual ICollection<ServiceChargeTransactionDetailsTbl> ServiceChargeTransactionDetailsTbl { get; set; }
    }
}
