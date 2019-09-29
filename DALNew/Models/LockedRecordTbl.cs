using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class LockedRecordTbl
    {
        public long PropertyId { get; set; }
        public long AppMenuId { get; set; }
        public long RecordId { get; set; }
        public long? UserId { get; set; }
        public long? MachineId { get; set; }
    }
}
