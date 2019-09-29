using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class SysBankFileDetailsFieldTbl
    {
        public long SysBankFileDetailsFieldId { get; set; }
        public string SysBankFileDetailsFieldEnName { get; set; }
        public string SysBankFileDetailsFieldArName { get; set; }
        public bool? NeedNoDecimalsYn { get; set; }
        public bool? NeedValueYn { get; set; }
    }
}
