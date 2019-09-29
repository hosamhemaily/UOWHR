using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class TicketTransactionTbl
    {
        public long TicketTransactionId { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public int? Year { get; set; }
        public DateTime? TicketDate { get; set; }
        public int? EmployeeTicketsConsumed { get; set; }
        public int? FamilyTicketsConsumed { get; set; }
        public string Notes { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public int? ChildrenTicketsConsumed { get; set; }

        public virtual EmployeeTbl Employee { get; set; }
    }
}
