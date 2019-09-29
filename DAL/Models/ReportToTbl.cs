using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ReportToTbl
    {
        public long ReportToId { get; set; }
        public long? EmployeeId { get; set; }
        public int? ReportToTypeId { get; set; }
        public string ReportToTypeEnName { get; set; }
        public string ReportToTypeArName { get; set; }
        public long? ReportToEmployeeId { get; set; }
        public int? ReportToLevelId { get; set; }
        public long? PropertyId { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
    }
}
