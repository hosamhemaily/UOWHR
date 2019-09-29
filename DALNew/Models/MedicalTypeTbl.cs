using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class MedicalTypeTbl
    {
        public MedicalTypeTbl()
        {
            MedicalCardsTransactionTbl = new HashSet<MedicalCardsTransactionTbl>();
            MedicalFamilyCardsTransactionTbl = new HashSet<MedicalFamilyCardsTransactionTbl>();
        }

        public long MedicalTypeId { get; set; }
        public long? PropertyId { get; set; }
        public string MedicalTypeCode { get; set; }
        public string MedicalTypeEnName { get; set; }
        public string MedicalTypeArName { get; set; }
        public string MedicalTypeArNameShadow { get; set; }
        public int? ExpiryMonths { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public byte? SingleFamily { get; set; }

        public virtual ICollection<MedicalCardsTransactionTbl> MedicalCardsTransactionTbl { get; set; }
        public virtual ICollection<MedicalFamilyCardsTransactionTbl> MedicalFamilyCardsTransactionTbl { get; set; }
    }
}
