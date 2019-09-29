using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class PenaltyTypeTbl
    {
        public PenaltyTypeTbl()
        {
            PenaltyTransactionTbl = new HashSet<PenaltyTransactionTbl>();
        }

        public byte PenaltyTypeId { get; set; }
        public string PenaltyTypeEnName { get; set; }
        public string PenaltyTypeArName { get; set; }

        public virtual ICollection<PenaltyTransactionTbl> PenaltyTransactionTbl { get; set; }
    }
}
