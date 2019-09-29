using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class DiseaseTbl
    {
        public DiseaseTbl()
        {
            MedicalFamilyVisitTransactionTbl = new HashSet<MedicalFamilyVisitTransactionTbl>();
            MedicalVisitTransactionTbl = new HashSet<MedicalVisitTransactionTbl>();
        }

        public long DiseaseId { get; set; }
        public long? PropertyId { get; set; }
        public string DiseaseCode { get; set; }
        public string DiseaseEnName { get; set; }
        public string DiseaseArName { get; set; }
        public string DiseaseArNameShadow { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<MedicalFamilyVisitTransactionTbl> MedicalFamilyVisitTransactionTbl { get; set; }
        public virtual ICollection<MedicalVisitTransactionTbl> MedicalVisitTransactionTbl { get; set; }
    }
}
