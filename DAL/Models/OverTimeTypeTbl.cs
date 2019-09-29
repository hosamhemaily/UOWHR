using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class OverTimeTypeTbl
    {
        public OverTimeTypeTbl()
        {
            AttendanceOverTimeTransactionTbl = new HashSet<AttendanceOverTimeTransactionTbl>();
            OverTimeTransactionTbl = new HashSet<OverTimeTransactionTbl>();
        }

        public long OverTimeTypeId { get; set; }
        public long? PropertyId { get; set; }
        public string OverTimeTypeCode { get; set; }
        public string OverTimeTypeEnName { get; set; }
        public string OverTimeTypeArName { get; set; }
        public string OverTimeTypeArNameShadow { get; set; }
        public double? OverTimeTypeRate { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<AttendanceOverTimeTransactionTbl> AttendanceOverTimeTransactionTbl { get; set; }
        public virtual ICollection<OverTimeTransactionTbl> OverTimeTransactionTbl { get; set; }
    }
}
