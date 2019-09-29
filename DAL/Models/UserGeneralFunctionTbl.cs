using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class UserGeneralFunctionTbl
    {
        public long UserGeneralFunctionId { get; set; }
        public string UserGeneralFunctionCode { get; set; }
        public string UserGeneralFunctionEnName { get; set; }
        public string UserGeneralFunctionArName { get; set; }
        public int? ParentId { get; set; }
        public string AppMenuValuePath { get; set; }
        public int LicenseTypeId { get; set; }
        public int? DisplayOrder { get; set; }
    }
}
