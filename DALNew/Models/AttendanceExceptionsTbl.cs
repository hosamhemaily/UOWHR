﻿using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class AttendanceExceptionsTbl
    {
        public long AttendanceExceptionsId { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public DateTime? TheDate { get; set; }
        public int? ActionTypeId { get; set; }
        public long? SupervisorEmployeeId { get; set; }
        public bool? ApprovedYn { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public int? ShiftOrder { get; set; }

        public virtual EmployeeTbl Employee { get; set; }
    }
}
