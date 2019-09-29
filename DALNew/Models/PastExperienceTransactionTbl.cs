using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class PastExperienceTransactionTbl
    {
        public long PastExperienceTransactionId { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public long? PastExperiencePlaceId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string Notes { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual EmployeeTbl Employee { get; set; }
        public virtual PastExperiencePlaceTbl PastExperiencePlace { get; set; }
    }
}
