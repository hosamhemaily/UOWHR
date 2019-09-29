using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ComponentComparisionReportDetailsTbl
    {
        public long ComponentComparisionReportDetailsId { get; set; }
        public long? PropertyId { get; set; }
        public long? UserId { get; set; }
        public int? FirstYear { get; set; }
        public int? FirstMonth { get; set; }
        public int? SecondYear { get; set; }
        public int? SecondMonth { get; set; }
        public int? ComponentTypeId { get; set; }
        public string ComponentTypeEnName { get; set; }
        public string ComponentTypeArName { get; set; }
        public long? ComponentId { get; set; }
        public string ComponentEnName { get; set; }
        public string ComponentArName { get; set; }
        public double? FirstValue { get; set; }
        public double? SecondValue { get; set; }
    }
}
