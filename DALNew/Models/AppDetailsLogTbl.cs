using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class AppDetailsLogTbl
    {
        public long DetailsLogId { get; set; }
        public long? MasterLogId { get; set; }
        public string FieldName { get; set; }
        public string OldEnValue { get; set; }
        public string NewEnValue { get; set; }
        public string OldArValue { get; set; }
        public string NewArValue { get; set; }

        public virtual AppMasterLogTbl MasterLog { get; set; }
    }
}
