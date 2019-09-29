using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class EmployeeLanguageTbl
    {
        public long EmployeeLanguageId { get; set; }
        public long? EmployeeId { get; set; }
        public long? LanguageId { get; set; }
        public byte? ReadDegreeId { get; set; }
        public byte? WriteDegreeId { get; set; }
        public byte? SpeakDegreeId { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual EmployeeTbl Employee { get; set; }
        public virtual LanguageTbl Language { get; set; }
        public virtual LanguageDegreeTbl ReadDegree { get; set; }
        public virtual LanguageDegreeTbl SpeakDegree { get; set; }
        public virtual LanguageDegreeTbl WriteDegree { get; set; }
    }
}
