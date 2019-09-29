using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class SelfServiceRequestDetailsTbl
    {
        public long SelfServiceRequestDetailsId { get; set; }
        public long? RequestMasterId { get; set; }
        public string AttendanceTypeId { get; set; }
        public long? EmployeeId { get; set; }
        public DateTime? AttendanceDate { get; set; }
        public string Abbreviation { get; set; }
        public long? FormId { get; set; }
    }
}
