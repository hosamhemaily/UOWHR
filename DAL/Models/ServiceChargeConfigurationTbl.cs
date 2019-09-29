using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ServiceChargeConfigurationTbl
    {
        public long ServiceChargeConfigurationId { get; set; }
        public long? PropertyId { get; set; }
        public double? GuestContactSalariesMaxRate { get; set; }
        public double? EmployeeRate { get; set; }
        public double? GuestContactRate { get; set; }
        public double? NoneGuestContactRate { get; set; }
        public double? BrokenRate { get; set; }
        public double? BonusRate { get; set; }
        public byte? GuestNoneGuestContactRates { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
    }
}
