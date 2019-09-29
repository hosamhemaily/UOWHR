using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class MedicalDegreeTbl
    {
        public long MedicalDegreeId { get; set; }
        public long? PropertyId { get; set; }
        public string MedicalDegreeCode { get; set; }
        public string MedicalDegreeEnName { get; set; }
        public string MedicalDegreeArName { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public string MedicalDegreeArNameShadow { get; set; }
    }
}
