﻿using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SpecialHolidayTbl
    {
        public long SpecialHolidayId { get; set; }
        public long? PropertyId { get; set; }
        public string SpecialHolidayCode { get; set; }
        public string SpecialHolidayEnName { get; set; }
        public string SpecialHolidayArName { get; set; }
        public string SpecialHolidayArNameShadow { get; set; }
        public DateTime? SpecialHolidayDate { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
    }
}
