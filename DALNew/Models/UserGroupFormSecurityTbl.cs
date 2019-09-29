using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class UserGroupFormSecurityTbl
    {
        public long UserGroupFormSecurityId { get; set; }
        public long? UserGroupId { get; set; }
        public long? AppMenuId { get; set; }
        public string AppMenuValuePath { get; set; }
        public bool? ViewYn { get; set; }
        public bool? InsertYn { get; set; }
        public bool? UpdateYn { get; set; }
        public bool? DeleteYn { get; set; }
        public bool? ViewOwnedOnlyYn { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
    }
}
