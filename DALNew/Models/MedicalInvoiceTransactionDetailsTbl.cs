﻿using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class MedicalInvoiceTransactionDetailsTbl
    {
        public long MedicalInvoiceTransactionDetailsId { get; set; }
        public long? MedicalInvoiceTransactionId { get; set; }
        public long? MedicineId { get; set; }
        public double? Amount { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual MedicalInvoiceTransactionTbl MedicalInvoiceTransaction { get; set; }
        public virtual MedicineTbl Medicine { get; set; }
    }
}
