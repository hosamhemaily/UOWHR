using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SpecialityTbl
    {
        public SpecialityTbl()
        {
            MedicalFamilyVisitTransactionTbl = new HashSet<MedicalFamilyVisitTransactionTbl>();
            MedicalVisitTransactionTbl = new HashSet<MedicalVisitTransactionTbl>();
        }

        public long SpecialityId { get; set; }
        public long? PropertyId { get; set; }
        public string SpecialityCode { get; set; }
        public string SpecialityEnName { get; set; }
        public string SpecialityArName { get; set; }
        public string SpecialityArNameShadow { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<MedicalFamilyVisitTransactionTbl> MedicalFamilyVisitTransactionTbl { get; set; }
        public virtual ICollection<MedicalVisitTransactionTbl> MedicalVisitTransactionTbl { get; set; }
    }
}
