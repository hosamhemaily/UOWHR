using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class EmployeeStatusTbl
    {
        public byte EmployeeStatusId { get; set; }
        public string EmployeeStatusEnName { get; set; }
        public string EmployeeStatusArName { get; set; }
    }
}
