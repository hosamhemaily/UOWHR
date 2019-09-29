using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SysDateFormatTbl
    {
        public int DateFormatId { get; set; }
        public string AppDateFormat { get; set; }
        public string DateValidator { get; set; }
        public int? SqlCode { get; set; }
    }
}
