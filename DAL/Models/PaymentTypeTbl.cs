using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class PaymentTypeTbl
    {
        public PaymentTypeTbl()
        {
            PaymentTbl = new HashSet<PaymentTbl>();
        }

        public byte PaymentTypeId { get; set; }
        public string PaymentTypeEnName { get; set; }
        public string PaymentTypeArName { get; set; }

        public virtual ICollection<PaymentTbl> PaymentTbl { get; set; }
    }
}
