using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VacationRuleTbl
    {
        public VacationRuleTbl()
        {
            EmployeeTbl = new HashSet<EmployeeTbl>();
            VacationBalanceDetailsTbl = new HashSet<VacationBalanceDetailsTbl>();
            VacationRuleAgeYearsTbl = new HashSet<VacationRuleAgeYearsTbl>();
            VacationRuleWorkingMonthTbl = new HashSet<VacationRuleWorkingMonthTbl>();
        }

        public long VacationRuleId { get; set; }
        public long? PropertyId { get; set; }
        public string VacationRuleCode { get; set; }
        public string VacationRuleEnName { get; set; }
        public string VacationRuleArName { get; set; }
        public string VacationRuleArNameShadow { get; set; }
        public byte? VacationRulePeriodYearlyContract { get; set; }
        public byte? VacationRuleWayCityResort { get; set; }
        public byte? VacationBalanceView { get; set; }
        public byte? DayOffCalculation { get; set; }
        public byte? HolidayCalculation { get; set; }
        public byte? ViewVacationBalanceTill { get; set; }
        public bool? PercentVacationBalanceInHiringMonthYn { get; set; }
        public bool? AbsenceEffectInAnnualOtherConsumbtionYn { get; set; }
        public bool? AbsenceEffectInDayOffOtherConsumbtionYn { get; set; }
        public bool? AbsenceEffectInHolidayOtherConsumbtionYn { get; set; }
        public bool? UsePublicHolidayYn { get; set; }
        public bool? UseSpecialHolidayYn { get; set; }
        public bool? PublicHolidayAllowanceDeductFromEmployeeBalanceYn { get; set; }
        public bool? RemoteAreaYn { get; set; }
        public int? RemoteAreaDays { get; set; }
        public bool? FixedDayOff { get; set; }
        public byte? FirstDayOffId { get; set; }
        public byte? SecondDayOffId { get; set; }
        public bool? SecondDayOffEveryTwoWeeksYn { get; set; }
        public bool? AutoAddDayOffTransactionYn { get; set; }
        public int? YearlyDayOffAmount { get; set; }
        public byte? WorkingMonthsHiringInsurance { get; set; }
        public bool? TransferAnnualBalanceYearlyYn { get; set; }
        public int? MaxAnnualAmountTransferable { get; set; }
        public bool? MaxMonthForAnnualTransferredYn { get; set; }
        public int? MaxMonthForAnnual { get; set; }
        public bool? TransferDayOffBalanceYearlyYn { get; set; }
        public int? MaxDayOffAmountTransferable { get; set; }
        public bool? MaxMonthForDayOffTransferredYn { get; set; }
        public int? MaxMonthForDayOff { get; set; }
        public bool? TransferHolidayBalanceYearlyYn { get; set; }
        public int? MaxHolidayAmountTransferable { get; set; }
        public bool? MaxMonthForHolidayTransferredYn { get; set; }
        public int? MaxMonthForHoliday { get; set; }
        public bool? ComputeDayOffWhenOccurresInHolidayYn { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public int? StartMonth { get; set; }
        public long? SpecialHolidayReligionId { get; set; }

        public virtual DayOfTheWeekTbl FirstDayOff { get; set; }
        public virtual DayOfTheWeekTbl SecondDayOff { get; set; }
        public virtual ICollection<EmployeeTbl> EmployeeTbl { get; set; }
        public virtual ICollection<VacationBalanceDetailsTbl> VacationBalanceDetailsTbl { get; set; }
        public virtual ICollection<VacationRuleAgeYearsTbl> VacationRuleAgeYearsTbl { get; set; }
        public virtual ICollection<VacationRuleWorkingMonthTbl> VacationRuleWorkingMonthTbl { get; set; }
    }
}
