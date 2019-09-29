using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SysFieldNameTbl
    {
        public long FieldNameId { get; set; }
        public string FieldName { get; set; }
        public string EnName { get; set; }
        public string ArName { get; set; }
    }
}
