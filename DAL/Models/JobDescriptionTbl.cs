using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class JobDescriptionTbl
    {
        public JobDescriptionTbl()
        {
            JobLanguageSkillsTbl = new HashSet<JobLanguageSkillsTbl>();
            JobResponsibilityTbl = new HashSet<JobResponsibilityTbl>();
        }

        public long JobDescriptionId { get; set; }
        public long? PropertyId { get; set; }
        public long? PositionId { get; set; }
        public string JobDescriptionSummary { get; set; }
        public long? PositionReportingTo { get; set; }
        public string PositionSubOrdinate { get; set; }
        public string Qualification { get; set; }
        public int? ExperienceFrom { get; set; }
        public int? ExperienceTo { get; set; }
        public double? ResponsibilitiesWeight { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual PositionTbl Position { get; set; }
        public virtual ICollection<JobLanguageSkillsTbl> JobLanguageSkillsTbl { get; set; }
        public virtual ICollection<JobResponsibilityTbl> JobResponsibilityTbl { get; set; }
    }
}
