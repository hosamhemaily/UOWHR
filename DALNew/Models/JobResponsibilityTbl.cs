﻿using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class JobResponsibilityTbl
    {
        public long JobResponsibilityId { get; set; }
        public long? PropertyId { get; set; }
        public string JobResponsibilityEnName { get; set; }
        public string JobResponsibilityArName { get; set; }
        public string JobResponsibilityArNameShadow { get; set; }
        public long? JobDescriptionId { get; set; }
        public double? Weight { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual JobDescriptionTbl JobDescription { get; set; }
    }
}
