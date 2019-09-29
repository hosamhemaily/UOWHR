using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class MedicalBenefitTbl
    {
        public MedicalBenefitTbl()
        {
            MedicalBenefitTransactionTbl = new HashSet<MedicalBenefitTransactionTbl>();
        }

        public long MedicalBenefitId { get; set; }
        public long? PropertyId { get; set; }
        public string MedicalBenefitCode { get; set; }
        public string MedicalBenefitEnName { get; set; }
        public string MedicalBenefitArName { get; set; }
        public string MedicalBenefitArNameShadow { get; set; }
        public bool? RepeatableYn { get; set; }
        public int? RepeatEveryMonths { get; set; }
        public bool? HasValueYn { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<MedicalBenefitTransactionTbl> MedicalBenefitTransactionTbl { get; set; }
    }
}
