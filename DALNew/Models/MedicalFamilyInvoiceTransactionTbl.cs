using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class MedicalFamilyInvoiceTransactionTbl
    {
        public MedicalFamilyInvoiceTransactionTbl()
        {
            MedicalFamilyInvoiceTransactionDetailsTbl = new HashSet<MedicalFamilyInvoiceTransactionDetailsTbl>();
        }

        public long MedicalFamilyInvoiceTransactionId { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public long? EmployeeRelativeId { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string InvoiceNumber { get; set; }
        public double? Amount { get; set; }
        public string Description { get; set; }
        public bool? DuductFromEmployeeYn { get; set; }
        public double? DeductionValue { get; set; }
        public int? TheMonth { get; set; }
        public int? TheYear { get; set; }
        public bool? MedicineDetailsYn { get; set; }
        public string Notes { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual EmployeeTbl Employee { get; set; }
        public virtual EmployeeRelativeTbl EmployeeRelative { get; set; }
        public virtual ICollection<MedicalFamilyInvoiceTransactionDetailsTbl> MedicalFamilyInvoiceTransactionDetailsTbl { get; set; }
    }
}
