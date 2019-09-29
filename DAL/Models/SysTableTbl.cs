using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SysTableTbl
    {
        public long TableId { get; set; }
        public string TableName { get; set; }
        public int? DeleteOrder { get; set; }
        public string TableType { get; set; }
        public bool? RecordPerProperty { get; set; }
        public string SqlIdentity { get; set; }
    }
}
