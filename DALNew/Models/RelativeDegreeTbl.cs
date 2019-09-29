using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class RelativeDegreeTbl
    {
        public RelativeDegreeTbl()
        {
            EmployeeRelativeTbl = new HashSet<EmployeeRelativeTbl>();
        }

        public long RelativeDegreeId { get; set; }
        public long? PropertyId { get; set; }
        public string RelativeDegreeCode { get; set; }
        public string RelativeDegreeEnName { get; set; }
        public string RelativeDegreeArName { get; set; }
        public string RelativeDegreeArNameShadow { get; set; }
        public byte? RelativeDegreeTypeId { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual RelativeDegreeTypeTbl RelativeDegreeType { get; set; }
        public virtual ICollection<EmployeeRelativeTbl> EmployeeRelativeTbl { get; set; }
    }
}
