﻿using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class PaymentDetailsTbl
    {
        public long PaymentId { get; set; }
        public long LinkedPaymentId { get; set; }

        public virtual PaymentTbl Payment { get; set; }
    }
}
