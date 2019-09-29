using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class EmployeeEmailTbl
    {
        public long EmployeeEmailId { get; set; }
        public long? EmployeeId { get; set; }
        public byte? EmailTypeId { get; set; }
        public string Email { get; set; }
        public bool? PrimaryYn { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual EmailTypeTbl EmailType { get; set; }
        public virtual EmployeeTbl Employee { get; set; }
    }
}
