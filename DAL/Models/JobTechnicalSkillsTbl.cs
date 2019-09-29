using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class JobTechnicalSkillsTbl
    {
        public long JobTechnicalSkillsId { get; set; }
        public long? PropertyId { get; set; }
        public string JobTechnicalSkillsEnName { get; set; }
        public string JobTechnicalSkillsArName { get; set; }
        public string JobTechnicalSkillsArNameShadow { get; set; }
        public long? JobDescriptionId { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
    }
}
