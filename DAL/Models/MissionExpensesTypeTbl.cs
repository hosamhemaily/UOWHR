using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MissionExpensesTypeTbl
    {
        public MissionExpensesTypeTbl()
        {
            MissionExpensesTransactionTbl = new HashSet<MissionExpensesTransactionTbl>();
        }

        public long MissionExpensesTypeId { get; set; }
        public long? PropertyId { get; set; }
        public string MissionExpensesTypeCode { get; set; }
        public string MissionExpensesTypeEnName { get; set; }
        public string MissionExpensesTypeArName { get; set; }
        public string MissionExpensesTypeArNameShadow { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<MissionExpensesTransactionTbl> MissionExpensesTransactionTbl { get; set; }
    }
}
