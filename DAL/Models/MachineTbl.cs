using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MachineTbl
    {
        public long MachineId { get; set; }
        public string MachineName { get; set; }
        public string LoginName { get; set; }
    }
}
