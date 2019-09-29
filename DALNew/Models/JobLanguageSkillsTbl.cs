using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class JobLanguageSkillsTbl
    {
        public long JobLanguageSkillsId { get; set; }
        public long? PropertyId { get; set; }
        public long? LanguageId { get; set; }
        public long? JobDescriptionId { get; set; }
        public byte? LanguageDegreeId { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual JobDescriptionTbl JobDescription { get; set; }
        public virtual LanguageTbl Language { get; set; }
        public virtual LanguageDegreeTbl LanguageDegree { get; set; }
    }
}
