using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class HandicappedTypeTbl
    {
        public HandicappedTypeTbl()
        {
            EmployeeTbl = new HashSet<EmployeeTbl>();
        }

        public long HandicappedTypeId { get; set; }
        public long? PropertyId { get; set; }
        public string HandicappedTypeCode { get; set; }
        public string HandicappedTypeEnName { get; set; }
        public string HandicappedTypeArName { get; set; }
        public string HandicappedTypeArNameShadow { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<EmployeeTbl> EmployeeTbl { get; set; }
    }
}
