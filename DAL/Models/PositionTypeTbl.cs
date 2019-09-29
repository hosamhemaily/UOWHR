using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class PositionTypeTbl
    {
        public PositionTypeTbl()
        {
            PositionTbl = new HashSet<PositionTbl>();
        }

        public long PositionTypeId { get; set; }
        public long? PropertyId { get; set; }
        public string PositionTypeCode { get; set; }
        public string PositionTypeEnName { get; set; }
        public string PositionTypeArName { get; set; }
        public string PositionTypeArNameShadow { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<PositionTbl> PositionTbl { get; set; }
    }
}
