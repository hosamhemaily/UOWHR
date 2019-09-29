using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class MissionExpensesTransactionTbl
    {
        public long MissionExpensesTransactionId { get; set; }
        public string AttendanceTypeId { get; set; }
        public long? PropertyId { get; set; }
        public long? MissionTransactionId { get; set; }
        public long? MissionExpensesTypeId { get; set; }
        public double? Amount { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual MissionExpensesTypeTbl MissionExpensesType { get; set; }
    }
}
