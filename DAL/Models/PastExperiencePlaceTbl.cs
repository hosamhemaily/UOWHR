using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class PastExperiencePlaceTbl
    {
        public PastExperiencePlaceTbl()
        {
            PastExperienceTransactionTbl = new HashSet<PastExperienceTransactionTbl>();
        }

        public long PastExperiencePlaceId { get; set; }
        public long? PropertyId { get; set; }
        public string PastExperiencePlaceCode { get; set; }
        public string PastExperiencePlaceEnName { get; set; }
        public string PastExperiencePlaceArName { get; set; }
        public string PastExperiencePlaceArNameShadow { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<PastExperienceTransactionTbl> PastExperienceTransactionTbl { get; set; }
    }
}
