﻿using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class SysDbScriptsTbl
    {
        public long DbScriptId { get; set; }
        public string DbScriptName { get; set; }
        public DateTime? DbScriptInsetDate { get; set; }
    }
}
