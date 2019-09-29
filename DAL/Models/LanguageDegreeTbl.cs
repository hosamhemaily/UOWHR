using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class LanguageDegreeTbl
    {
        public LanguageDegreeTbl()
        {
            EmployeeLanguageTblReadDegree = new HashSet<EmployeeLanguageTbl>();
            EmployeeLanguageTblSpeakDegree = new HashSet<EmployeeLanguageTbl>();
            EmployeeLanguageTblWriteDegree = new HashSet<EmployeeLanguageTbl>();
            JobLanguageSkillsTbl = new HashSet<JobLanguageSkillsTbl>();
        }

        public byte LanguageDegreeId { get; set; }
        public string LanguageDegreeEnName { get; set; }
        public string LanguageDegreeArName { get; set; }

        public virtual ICollection<EmployeeLanguageTbl> EmployeeLanguageTblReadDegree { get; set; }
        public virtual ICollection<EmployeeLanguageTbl> EmployeeLanguageTblSpeakDegree { get; set; }
        public virtual ICollection<EmployeeLanguageTbl> EmployeeLanguageTblWriteDegree { get; set; }
        public virtual ICollection<JobLanguageSkillsTbl> JobLanguageSkillsTbl { get; set; }
    }
}
