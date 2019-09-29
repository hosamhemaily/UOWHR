using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ChangeOfStatusReasonTbl
    {
        public ChangeOfStatusReasonTbl()
        {
            ChangeOfStatusTransactionTbl = new HashSet<ChangeOfStatusTransactionTbl>();
        }

        public long ChangeOfStatusReasonId { get; set; }
        public long? PropertyId { get; set; }
        public string ChangeOfStatusReasonCode { get; set; }
        public string ChangeOfStatusReasonEnName { get; set; }
        public string ChangeOfStatusReasonArName { get; set; }
        public string ChangeOfStatusReasonArNameShadow { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<ChangeOfStatusTransactionTbl> ChangeOfStatusTransactionTbl { get; set; }
    }
}
