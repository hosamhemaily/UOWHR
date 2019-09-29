using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class AttendanceTransactionFlagTbl
    {
        public AttendanceTransactionFlagTbl()
        {
            AttendanceMachineLogTbl = new HashSet<AttendanceMachineLogTbl>();
        }

        public byte AttendanceTransactionFlagId { get; set; }
        public string AttendanceTransactionFlagEnName { get; set; }
        public string AttendanceTransactionFlagArName { get; set; }

        public virtual ICollection<AttendanceMachineLogTbl> AttendanceMachineLogTbl { get; set; }
    }
}
