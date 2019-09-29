using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class MedicalDegreeDetailsTbl
    {
        public long MedicalDegreeDetailsId { get; set; }
        public long? PropertyId { get; set; }
        public int? MedicalDegreeId { get; set; }
        public long? RelativeDegreeId { get; set; }
        public double? MedicalValue { get; set; }
        public double? EmployeePercentage { get; set; }
        public double? CompanyPercentage { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
    }
}
