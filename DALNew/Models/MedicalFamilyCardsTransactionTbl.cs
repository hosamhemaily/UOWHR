using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class MedicalFamilyCardsTransactionTbl
    {
        public long MedicalFamilyCardsTransactionId { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public long? EmployeeRelativeId { get; set; }
        public long? MedicalTypeId { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string CardNumber { get; set; }
        public bool? StoppedYn { get; set; }
        public double? MaxLimit { get; set; }
        public string Notes { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual EmployeeTbl Employee { get; set; }
        public virtual EmployeeRelativeTbl EmployeeRelative { get; set; }
        public virtual MedicalTypeTbl MedicalType { get; set; }
    }
}
