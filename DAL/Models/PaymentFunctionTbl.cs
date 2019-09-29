using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class PaymentFunctionTbl
    {
        public PaymentFunctionTbl()
        {
            EmployeePaymentModeTbl = new HashSet<EmployeePaymentModeTbl>();
        }

        public byte PaymentFunctionId { get; set; }
        public string PaymentFunctionEnName { get; set; }
        public string PaymentFunctionArName { get; set; }

        public virtual ICollection<EmployeePaymentModeTbl> EmployeePaymentModeTbl { get; set; }
    }
}
