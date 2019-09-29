using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class MedicalBenefitTransactionTbl
    {
        public long MedicalBenefitTransactionId { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public long? MedicalBenefitId { get; set; }
        public DateTime? MedicalBenefitDate { get; set; }
        public DateTime? RepeateDate { get; set; }
        public double? MedicalBenefitValue { get; set; }
        public string Notes { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual MedicalBenefitTbl MedicalBenefit { get; set; }
    }
}
