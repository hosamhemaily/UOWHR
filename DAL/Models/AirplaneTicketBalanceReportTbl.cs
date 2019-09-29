using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class AirplaneTicketBalanceReportTbl
    {
        public long AirplaneTicketBalanceReportId { get; set; }
        public long? PropertyId { get; set; }
        public long? UserId { get; set; }
        public long? EmployeeId { get; set; }
        public double? EmployeeYearlyTicketsDue { get; set; }
        public double? EmployeeTicketsConsumed { get; set; }
        public double? FamilyYearlyTicketsDue { get; set; }
        public double? FamilyTicketsConsumed { get; set; }
        public double? ChildrenYearlyTicketsDue { get; set; }
        public double? ChildrenTicketsConsumed { get; set; }
        public double? TicketRate { get; set; }
        public double? ChildRate { get; set; }
    }
}
