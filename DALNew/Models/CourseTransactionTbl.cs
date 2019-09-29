﻿using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class CourseTransactionTbl
    {
        public long CourseTransactionId { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public long? CourseId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string CourseCenter { get; set; }
        public string CourseDetails { get; set; }
        public string EmployeeDegree { get; set; }
        public string Notes { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual CourseTbl Course { get; set; }
        public virtual EmployeeTbl Employee { get; set; }
    }
}
