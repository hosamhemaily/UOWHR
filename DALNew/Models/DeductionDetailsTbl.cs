using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class DeductionDetailsTbl
    {
        public long DeductionId { get; set; }
        public long PaymentId { get; set; }

        public virtual DeductionTbl Deduction { get; set; }
    }
}
