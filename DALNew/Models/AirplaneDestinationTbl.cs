using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class AirplaneDestinationTbl
    {
        public AirplaneDestinationTbl()
        {
            EmployeeTbl = new HashSet<EmployeeTbl>();
            MonthlyTicketRateTbl = new HashSet<MonthlyTicketRateTbl>();
        }

        public long AirplaneDestinationId { get; set; }
        public long? PropertyId { get; set; }
        public string AirplaneDestinationCode { get; set; }
        public string AirplaneDestinationEnName { get; set; }
        public string AirplaneDestinationArName { get; set; }
        public string AirplaneDestinationArNameShadow { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<EmployeeTbl> EmployeeTbl { get; set; }
        public virtual ICollection<MonthlyTicketRateTbl> MonthlyTicketRateTbl { get; set; }
    }
}
