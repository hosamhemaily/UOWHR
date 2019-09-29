using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class EmployeeSharedPropertyTbl
    {
        public long EmployeeSharedPropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public long? PropertyId { get; set; }

        public virtual EmployeeTbl Employee { get; set; }
        public virtual PropertyTbl Property { get; set; }
    }
}
