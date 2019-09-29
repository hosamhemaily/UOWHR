using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class RehireTransactionTbl
    {
        public long RehireTransactionId { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public DateTime? RehireDate { get; set; }
        public bool? NewEmployeeCodeYn { get; set; }
        public string OldEmployeeCode { get; set; }
        public string NewEmployeeCode { get; set; }
        public bool? CalculateNewProbationPeriodYn { get; set; }
        public string Notes { get; set; }
        public DateTime? PreviousTerminationDate { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual EmployeeTbl Employee { get; set; }
    }
}
