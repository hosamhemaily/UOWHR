using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class PaymentGroupDetailsTbl
    {
        public long PaymentGroupId { get; set; }
        public long PaymentId { get; set; }

        public virtual PaymentTbl Payment { get; set; }
        public virtual PaymentGroupTbl PaymentGroup { get; set; }
    }
}
