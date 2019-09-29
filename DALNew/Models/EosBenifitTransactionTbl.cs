using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class EosBenifitTransactionTbl
    {
        public long EosBenifitTransactionId { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public DateTime? BenifitDate { get; set; }
        public long? EosRuleId { get; set; }
        public int? ServiceYears { get; set; }
        public int? NoneCompletedYearMonths { get; set; }
        public double? EosValue { get; set; }
        public bool? PaidWithSalaryYn { get; set; }
        public string Notes { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual EmployeeTbl Employee { get; set; }
        public virtual EosRuleTbl EosRule { get; set; }
    }
}
