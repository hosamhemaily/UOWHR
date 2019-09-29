using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class EmployeeCommunicationTbl
    {
        public long EmployeeCommunicationId { get; set; }
        public long? EmployeeId { get; set; }
        public byte? CommunicationTypeId { get; set; }
        public string Number { get; set; }
        public bool? PrimaryYn { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual CommunicationTypeTbl CommunicationType { get; set; }
        public virtual EmployeeTbl Employee { get; set; }
    }
}
