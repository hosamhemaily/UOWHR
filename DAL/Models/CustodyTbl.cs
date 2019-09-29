using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CustodyTbl
    {
        public CustodyTbl()
        {
            CustodyTransactionTbl = new HashSet<CustodyTransactionTbl>();
        }

        public long CustodyId { get; set; }
        public long? PropertyId { get; set; }
        public string CustodyCode { get; set; }
        public string CustodyEnName { get; set; }
        public string CustodyArName { get; set; }
        public string CustodyArNameShadow { get; set; }
        public bool? ExpireYn { get; set; }
        public int? ExpireMonths { get; set; }
        public bool? HasNumberYn { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<CustodyTransactionTbl> CustodyTransactionTbl { get; set; }
    }
}
