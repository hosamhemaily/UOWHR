using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SysReportFilterTbl
    {
        public long SysReportFilterId { get; set; }
        public long? SysReportId { get; set; }
        public string LableEnName { get; set; }
        public string LableArName { get; set; }
        public string LableControlId { get; set; }
        public string FieldName { get; set; }
        public string FieldControlId { get; set; }
        public string FieldType { get; set; }
        public string TdId { get; set; }
        public string TableName { get; set; }
        public string Operator { get; set; }
        public bool? RequiredYn { get; set; }
        public string CommandName { get; set; }
        public string FieldId { get; set; }
        public string Name { get; set; }
        public bool? MendatoryYn { get; set; }
        public string DefaultValue { get; set; }

        public virtual SysReportTbl SysReport { get; set; }
    }
}
