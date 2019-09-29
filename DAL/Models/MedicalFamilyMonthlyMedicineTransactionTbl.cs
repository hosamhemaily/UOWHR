using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MedicalFamilyMonthlyMedicineTransactionTbl
    {
        public long MedicalFamilyMonthlyMedicineTransactionId { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public long? EmployeeRelativeId { get; set; }
        public DateTime? TransactionDate { get; set; }
        public long? MedicineId { get; set; }
        public int? MonthlyMedicineQty { get; set; }
        public int? NoOfMonth { get; set; }
        public bool? MedicinePermanentYn { get; set; }
        public bool? MedicineStoppedYn { get; set; }
        public string Notes { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual EmployeeTbl Employee { get; set; }
        public virtual EmployeeRelativeTbl EmployeeRelative { get; set; }
        public virtual MedicineTbl Medicine { get; set; }
    }
}
