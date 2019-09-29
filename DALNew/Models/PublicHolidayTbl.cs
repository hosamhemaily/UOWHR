﻿using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class PublicHolidayTbl
    {
        public PublicHolidayTbl()
        {
            HolidayAllowanceTransactionTbl = new HashSet<HolidayAllowanceTransactionTbl>();
        }

        public long PublicHolidayId { get; set; }
        public long? PropertyId { get; set; }
        public string PublicHolidayCode { get; set; }
        public string PublicHolidayEnName { get; set; }
        public string PublicHolidayArName { get; set; }
        public string PublicHolidayArNameShadow { get; set; }
        public DateTime? PublicHolidayDate { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<HolidayAllowanceTransactionTbl> HolidayAllowanceTransactionTbl { get; set; }
    }
}
