using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class HolidayAllowanceTransactionTbl
    {
        public HolidayAllowanceTransactionTbl()
        {
            HolidayAllowanceTransactionDetailsTbl = new HashSet<HolidayAllowanceTransactionDetailsTbl>();
        }

        public long HolidayAllowanceTransactionId { get; set; }
        public long? PropertyId { get; set; }
        public long? PublicHolidayId { get; set; }
        public DateTime? HolidayDate { get; set; }
        public byte? HolidayAllowanceTypeId { get; set; }
        public DateTime? AlternativeDate { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public string DescriptionEn { get; set; }
        public string DescriptionAr { get; set; }
        public bool? PaidAsAdditionalPaymnet { get; set; }

        public virtual HolidayAllowanceTypeTbl HolidayAllowanceType { get; set; }
        public virtual PublicHolidayTbl PublicHoliday { get; set; }
        public virtual ICollection<HolidayAllowanceTransactionDetailsTbl> HolidayAllowanceTransactionDetailsTbl { get; set; }
    }
}
