using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SelfServiceDelegationTbl
    {
        public long SelfServiceDelegationId { get; set; }
        public long? PropertyId { get; set; }
        public long? SelfServiceDelegationFromEmployeeId { get; set; }
        public long? SelfServiceDelegationToEmployeeId { get; set; }
        public DateTime? SelfServiceDelegationFromDate { get; set; }
        public DateTime? SelfServiceDelegationToDate { get; set; }
        public bool? SelfServiceDelegationAutoReleaseYn { get; set; }
        public bool? SelfServiceDelegationReleasedYn { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
    }
}
