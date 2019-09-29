using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class MedicalMonthlyMedicineTransactionTbl
    {
        public long MedicalMonthlyMedicineTransactionId { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public DateTime? TransactionDate { get; set; }
        public long? MedicineId { get; set; }
        public int? MonthlyMedicineQty { get; set; }
        public int? NoOfMonth { get; set; }
        public bool? MedicinePermanentYn { get; set; }
        public bool? MedicineStoppedYn { get; set; }
        public string Notes { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
    }
}
