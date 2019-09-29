using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class PaymentStatusTbl
    {
        public PaymentStatusTbl()
        {
            PaymentTbl = new HashSet<PaymentTbl>();
        }

        public byte PaymentStatusId { get; set; }
        public string PaymentStatusEnName { get; set; }
        public string PaymentStatusArName { get; set; }

        public virtual ICollection<PaymentTbl> PaymentTbl { get; set; }
    }
}
