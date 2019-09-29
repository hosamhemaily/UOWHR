using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class MedicineTbl
    {
        public MedicineTbl()
        {
            MedicalFamilyInvoiceTransactionDetailsTbl = new HashSet<MedicalFamilyInvoiceTransactionDetailsTbl>();
            MedicalFamilyMonthlyMedicineTransactionTbl = new HashSet<MedicalFamilyMonthlyMedicineTransactionTbl>();
            MedicalInvoiceTransactionDetailsTbl = new HashSet<MedicalInvoiceTransactionDetailsTbl>();
        }

        public long MedicineId { get; set; }
        public long? PropertyId { get; set; }
        public string MedicineCode { get; set; }
        public string MedicineEnName { get; set; }
        public string MedicineArName { get; set; }
        public string MedicineArNameShadow { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<MedicalFamilyInvoiceTransactionDetailsTbl> MedicalFamilyInvoiceTransactionDetailsTbl { get; set; }
        public virtual ICollection<MedicalFamilyMonthlyMedicineTransactionTbl> MedicalFamilyMonthlyMedicineTransactionTbl { get; set; }
        public virtual ICollection<MedicalInvoiceTransactionDetailsTbl> MedicalInvoiceTransactionDetailsTbl { get; set; }
    }
}
