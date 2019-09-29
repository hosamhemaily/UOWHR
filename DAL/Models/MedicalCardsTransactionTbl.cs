using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MedicalCardsTransactionTbl
    {
        public long MedicalCardsTransactionId { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public long? MedicalTypeId { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string CardNumber { get; set; }
        public bool? StoppedYn { get; set; }
        public string Notes { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public double? MaxLimit { get; set; }

        public virtual EmployeeTbl Employee { get; set; }
        public virtual MedicalTypeTbl MedicalType { get; set; }
    }
}
