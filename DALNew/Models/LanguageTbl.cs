using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class LanguageTbl
    {
        public LanguageTbl()
        {
            EmployeeLanguageTbl = new HashSet<EmployeeLanguageTbl>();
            JobLanguageSkillsTbl = new HashSet<JobLanguageSkillsTbl>();
        }

        public long LanguageId { get; set; }
        public long? PropertyId { get; set; }
        public string LanguageCode { get; set; }
        public string LanguageEnName { get; set; }
        public string LanguageArName { get; set; }
        public string LanguageArNameShadow { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<EmployeeLanguageTbl> EmployeeLanguageTbl { get; set; }
        public virtual ICollection<JobLanguageSkillsTbl> JobLanguageSkillsTbl { get; set; }
    }
}
