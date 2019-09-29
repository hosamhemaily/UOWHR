using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ComponentComparisionAnalysisReportDetailsTbl
    {
        public long ComponentComparisionAnalysisReportDetailsId { get; set; }
        public long? PropertyId { get; set; }
        public long? UserId { get; set; }
        public int? ComponentTypeId { get; set; }
        public string ComponentTypeEnName { get; set; }
        public string ComponentTypeArName { get; set; }
        public long? ComponentId { get; set; }
        public string ComponentEnName { get; set; }
        public string ComponentArName { get; set; }
        public int? ComparisonFieldId { get; set; }
        public long? EmployeeId { get; set; }
        public double? TheValue { get; set; }
    }
}
