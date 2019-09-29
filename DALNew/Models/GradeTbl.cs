using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class GradeTbl
    {
        public GradeTbl()
        {
            PositionTbl = new HashSet<PositionTbl>();
        }

        public long GradeId { get; set; }
        public long? PropertyId { get; set; }
        public string GradeCode { get; set; }
        public string GradeEnName { get; set; }
        public string GradeArName { get; set; }
        public string GradeArNameShadow { get; set; }
        public double? TicketsNumber { get; set; }
        public string GradeCostCenter { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public byte? IncentiveStaff { get; set; }
        public double? Rate { get; set; }
        public double? PensionSchemeRate { get; set; }

        public virtual ICollection<PositionTbl> PositionTbl { get; set; }
    }
}
