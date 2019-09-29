using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class AddionalPaymentHeModel
    {
        public long AdditionalPaymentTransactionId { get; set; }
        public long? PropertyId { get; set; }
        public int? TheYear { get; set; }
        public int? TheMonth { get; set; }
        public DateTime? AdditionalPaymentDate { get; set; }
        public long? PaymentId { get; set; }
        public int? PayWay { get; set; }

        public virtual ICollection<AddionalPaymentDeModel> AdditionalPaymentTransactionDetailsTbl { get; set; }
    }
}
