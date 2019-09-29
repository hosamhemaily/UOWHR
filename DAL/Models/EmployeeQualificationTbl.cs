using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class EmployeeQualificationTbl
    {
        public long EmployeeQualificationId { get; set; }
        public long? EmployeeId { get; set; }
        public long? QualificationId { get; set; }
        public long? FacultyId { get; set; }
        public long? UniversityId { get; set; }
        public int? QualificationYear { get; set; }
        public long? QualificationGradeId { get; set; }
        public string Specialty { get; set; }
        public string WorkingLicenseNumber { get; set; }
        public string QualificationNotes { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual EmployeeTbl Employee { get; set; }
        public virtual FacultyTbl Faculty { get; set; }
        public virtual QualificationTbl Qualification { get; set; }
        public virtual QualificationGradeTbl QualificationGrade { get; set; }
        public virtual UniversityTbl University { get; set; }
    }
}
