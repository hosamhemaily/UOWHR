using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class MaritalStatusTbl
    {
        public MaritalStatusTbl()
        {
            EmployeeMonthlySalaryTbl = new HashSet<EmployeeMonthlySalaryTbl>();
            EmployeeRelativeTbl = new HashSet<EmployeeRelativeTbl>();
            EmployeeTbl = new HashSet<EmployeeTbl>();
        }

        public long MaritalStatusId { get; set; }
        public long? PropertyId { get; set; }
        public string MaritalStatusCode { get; set; }
        public string MaritalStatusEnName { get; set; }
        public string MaritalStatusArName { get; set; }
        public string MaritalStatusArNameShadow { get; set; }
        public byte? MaritalStatusTypeId { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual MaritalStatusTypeTbl MaritalStatusType { get; set; }
        public virtual ICollection<EmployeeMonthlySalaryTbl> EmployeeMonthlySalaryTbl { get; set; }
        public virtual ICollection<EmployeeRelativeTbl> EmployeeRelativeTbl { get; set; }
        public virtual ICollection<EmployeeTbl> EmployeeTbl { get; set; }
    }
}
