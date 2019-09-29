using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MedicalFamilyVisitTransactionTbl
    {
        public long MedicalFamilyVisitTransactionId { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public long? EmployeeRelativeId { get; set; }
        public DateTime? VisitDate { get; set; }
        public string VisitNumber { get; set; }
        public string VisitPlace { get; set; }
        public string VisitReason { get; set; }
        public string Doctor { get; set; }
        public long? SpecialityId { get; set; }
        public long? DiseaseId { get; set; }
        public double? Amount { get; set; }
        public string Diagnosis { get; set; }
        public bool? DuductFromEmployeeYn { get; set; }
        public double? DeductionValue { get; set; }
        public int? TheMonth { get; set; }
        public int? TheYear { get; set; }
        public bool? InternalYn { get; set; }
        public int? SysMedicalVacationTypeId { get; set; }
        public int? NoOfDays { get; set; }
        public string Notes { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual DiseaseTbl Disease { get; set; }
        public virtual EmployeeTbl Employee { get; set; }
        public virtual EmployeeRelativeTbl EmployeeRelative { get; set; }
        public virtual SpecialityTbl Speciality { get; set; }
    }
}
