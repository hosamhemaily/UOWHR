using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class InterfaceTbl
    {
        public int InterfaceId { get; set; }
        public long? PropertyId { get; set; }
        public string OverTimePaymentId { get; set; }
        public string VacationBalancePaymentId { get; set; }
        public string HolidayAllowancePaymentId { get; set; }
        public string OutSideDeductionId { get; set; }
        public string AbsenceWithPermissionDeductionId { get; set; }
        public string AbsenceWithoutPermissionDeductionId { get; set; }
        public string PenaltyDeductionId { get; set; }
        public string PenaltyValueDeductionId { get; set; }
        public string LateDeductionId { get; set; }
        public string VacationBalanceDeductionId { get; set; }
        public string ContractExpiryDeductionId { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public string MedicalDeductionId { get; set; }
        public string TrainingDeductionId { get; set; }
        public string DayoffDeductionId { get; set; }
        public string HolidayDeductionId { get; set; }
        public string DayoffPaymentId { get; set; }
        public string HolidayPaymentId { get; set; }
        public string EosPaymentId { get; set; }
        public string MonthComplementPaymentId { get; set; }
        public string CompanyInsuranceDeductionId { get; set; }
        public string PenaltyNotListDeductionId { get; set; }
    }
}
