using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class EmployeeCostCenterTbl
    {
        public long EmployeeCostCenterId { get; set; }
        public long? EmployeeId { get; set; }
        public long? PropertyId { get; set; }
        public long? DivisionId { get; set; }
        public long? DepartmentId { get; set; }
        public long? SectionId { get; set; }
        public double? PaymentsRate { get; set; }
        public double? DeductionsRate { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual DepartmentTbl Department { get; set; }
        public virtual DivisionTbl Division { get; set; }
        public virtual EmployeeTbl Employee { get; set; }
        public virtual PropertyTbl Property { get; set; }
        public virtual SectionTbl Section { get; set; }
    }
}
