using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class AddionalPaymentDeModel
    {
        public long AdditionalPaymentTransactionDetailsId { get; set; }
        public long? AdditionalPaymentTransactionId { get; set; }
        public long? EmployeeId { get; set; }
        public double? PaymentValueBeforeCalc { get; set; }
        public double? PaymentTax { get; set; }
        public double? PaymentValueAfterCalc { get; set; }
        public double? PaymentNetValue { get; set; }
        public string Full_Ar_Name { get; set; }
        public EmployeeModel Employee { get; set; }
    }
}
