using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class LateTypeTbl
    {
        public LateTypeTbl()
        {
            AttendanceLateTransactionTbl = new HashSet<AttendanceLateTransactionTbl>();
            LateTransactionTbl = new HashSet<LateTransactionTbl>();
        }

        public long LateTypeId { get; set; }
        public long? PropertyId { get; set; }
        public string LateTypeCode { get; set; }
        public string LateTypeEnName { get; set; }
        public string LateTypeArName { get; set; }
        public string LateTypeArNameShadow { get; set; }
        public double? LateTypeRate { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<AttendanceLateTransactionTbl> AttendanceLateTransactionTbl { get; set; }
        public virtual ICollection<LateTransactionTbl> LateTransactionTbl { get; set; }
    }
}
