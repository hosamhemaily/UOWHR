using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VacationTypeTbl
    {
        public VacationTypeTbl()
        {
            VacationDeductionInterfaceTbl = new HashSet<VacationDeductionInterfaceTbl>();
            VacationRangeDeductionTbl = new HashSet<VacationRangeDeductionTbl>();
            VacationRangeSliceTbl = new HashSet<VacationRangeSliceTbl>();
            VacationTransactionTbl = new HashSet<VacationTransactionTbl>();
        }

        public long VacationTypeId { get; set; }
        public long? PropertyId { get; set; }
        public string VacationTypeCode { get; set; }
        public string VacationTypeEnName { get; set; }
        public string VacationTypeArName { get; set; }
        public string VacationTypeArNameShadow { get; set; }
        public byte? VacationCategoryId { get; set; }
        public bool? EffectInAnnualDueYn { get; set; }
        public bool? EffectInDayOffDueYn { get; set; }
        public bool? EffectInHolidayDueYn { get; set; }
        public bool? EffectInEosYn { get; set; }
        public string Abbreviation { get; set; }
        public string Color { get; set; }
        public bool? ByRequestYn { get; set; }
        public bool? DeductionRangeYn { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public int? MaxLimit { get; set; }
        public bool? DisplayInHeadCountReportYn { get; set; }
        public int? OtherConsumptionType { get; set; }
        public double? FixedPercentage { get; set; }
        public int? VacationOverlappingType { get; set; }

        public virtual VacationCategoryTbl VacationCategory { get; set; }
        public virtual ICollection<VacationDeductionInterfaceTbl> VacationDeductionInterfaceTbl { get; set; }
        public virtual ICollection<VacationRangeDeductionTbl> VacationRangeDeductionTbl { get; set; }
        public virtual ICollection<VacationRangeSliceTbl> VacationRangeSliceTbl { get; set; }
        public virtual ICollection<VacationTransactionTbl> VacationTransactionTbl { get; set; }
    }
}
