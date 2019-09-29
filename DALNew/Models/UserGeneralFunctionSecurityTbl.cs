using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class UserGeneralFunctionSecurityTbl
    {
        public long UserGeneralFunctionSecurityId { get; set; }
        public long PropertyId { get; set; }
        public long UserId { get; set; }
        public long UserGeneralFunctionId { get; set; }
        public string UserGeneralFunctionCode { get; set; }
        public string AppMenuValuePath { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
    }
}
