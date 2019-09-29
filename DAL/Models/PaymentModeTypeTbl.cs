using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class PaymentModeTypeTbl
    {
        public PaymentModeTypeTbl()
        {
            EmployeePaymentModeTbl = new HashSet<EmployeePaymentModeTbl>();
        }

        public byte PaymentModeTypeId { get; set; }
        public string PaymentModeTypeEnName { get; set; }
        public string PaymentModeTypeArName { get; set; }

        public virtual ICollection<EmployeePaymentModeTbl> EmployeePaymentModeTbl { get; set; }
    }
}
