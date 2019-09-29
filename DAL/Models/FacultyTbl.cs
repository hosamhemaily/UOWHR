﻿using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class FacultyTbl
    {
        public FacultyTbl()
        {
            EmployeeQualificationTbl = new HashSet<EmployeeQualificationTbl>();
        }

        public long FacultyId { get; set; }
        public long? PropertyId { get; set; }
        public string FacultyCode { get; set; }
        public string FacultyEnName { get; set; }
        public string FacultyArName { get; set; }
        public string FacultyArNameShadow { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<EmployeeQualificationTbl> EmployeeQualificationTbl { get; set; }
    }
}
