using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class EmployeeTbl
    {
        public EmployeeTbl()
        {
            AbsenceTransactionTbl = new HashSet<AbsenceTransactionTbl>();
            AdditionalPaymentTransactionDetailsTbl = new HashSet<AdditionalPaymentTransactionDetailsTbl>();
            AttendanceExceptionsTbl = new HashSet<AttendanceExceptionsTbl>();
            AttendanceMachineLogTbl = new HashSet<AttendanceMachineLogTbl>();
            BenefitTransactionTbl = new HashSet<BenefitTransactionTbl>();
            BonusTransactionDetailsTbl = new HashSet<BonusTransactionDetailsTbl>();
            CertificateTransactionTbl = new HashSet<CertificateTransactionTbl>();
            ChangeOfStatusTransactionTbl = new HashSet<ChangeOfStatusTransactionTbl>();
            ContractRenewalTransactionTbl = new HashSet<ContractRenewalTransactionTbl>();
            CourseTransactionTbl = new HashSet<CourseTransactionTbl>();
            CustodyTransactionTbl = new HashSet<CustodyTransactionTbl>();
            DailyEmploymentAttendanceTransactionTbl = new HashSet<DailyEmploymentAttendanceTransactionTbl>();
            DeductionTransactionTbl = new HashSet<DeductionTransactionTbl>();
            DocumentBorrowingTransactionTbl = new HashSet<DocumentBorrowingTransactionTbl>();
            EmployeeAddressTbl = new HashSet<EmployeeAddressTbl>();
            EmployeeCommunicationTbl = new HashSet<EmployeeCommunicationTbl>();
            EmployeeCostCenterTbl = new HashSet<EmployeeCostCenterTbl>();
            EmployeeEmailTbl = new HashSet<EmployeeEmailTbl>();
            EmployeeFeesTbl = new HashSet<EmployeeFeesTbl>();
            EmployeeGroupTbl = new HashSet<EmployeeGroupTbl>();
            EmployeeLanguageTbl = new HashSet<EmployeeLanguageTbl>();
            EmployeeMonthlySalaryTbl = new HashSet<EmployeeMonthlySalaryTbl>();
            EmployeePaymentModeTbl = new HashSet<EmployeePaymentModeTbl>();
            EmployeeQualificationTbl = new HashSet<EmployeeQualificationTbl>();
            EmployeeRelativeTbl = new HashSet<EmployeeRelativeTbl>();
            EmployeeSharedPropertyTbl = new HashSet<EmployeeSharedPropertyTbl>();
            EosBenifitTransactionTbl = new HashSet<EosBenifitTransactionTbl>();
            HiringDocumentTransactionTbl = new HashSet<HiringDocumentTransactionTbl>();
            HolidayAllowanceTransactionDetailsTbl = new HashSet<HolidayAllowanceTransactionDetailsTbl>();
            LateTransactionTbl = new HashSet<LateTransactionTbl>();
            LoanTransactionTbl = new HashSet<LoanTransactionTbl>();
            MedicalCardsTransactionTbl = new HashSet<MedicalCardsTransactionTbl>();
            MedicalFamilyCardsTransactionTbl = new HashSet<MedicalFamilyCardsTransactionTbl>();
            MedicalFamilyInvoiceTransactionTbl = new HashSet<MedicalFamilyInvoiceTransactionTbl>();
            MedicalFamilyMonthlyMedicineTransactionTbl = new HashSet<MedicalFamilyMonthlyMedicineTransactionTbl>();
            MedicalFamilyVisitTransactionTbl = new HashSet<MedicalFamilyVisitTransactionTbl>();
            MedicalInvoiceTransactionTbl = new HashSet<MedicalInvoiceTransactionTbl>();
            MedicalVisitTransactionTbl = new HashSet<MedicalVisitTransactionTbl>();
            MissionTransactionTbl = new HashSet<MissionTransactionTbl>();
            MonthlyWorkingHoursTransactionTbl = new HashSet<MonthlyWorkingHoursTransactionTbl>();
            OverTimeTransactionTbl = new HashSet<OverTimeTransactionTbl>();
            PastExperienceTransactionTbl = new HashSet<PastExperienceTransactionTbl>();
            PaymentTransactionTbl = new HashSet<PaymentTransactionTbl>();
            PenaltyTransactionTbl = new HashSet<PenaltyTransactionTbl>();
            PermissionTransactionTbl = new HashSet<PermissionTransactionTbl>();
            RehireTransactionTbl = new HashSet<RehireTransactionTbl>();
            ResidencyRenewalTransactionTbl = new HashSet<ResidencyRenewalTransactionTbl>();
            SelfServiceApprovalTbl = new HashSet<SelfServiceApprovalTbl>();
            SelfServiceRequestTbl = new HashSet<SelfServiceRequestTbl>();
            ServiceChargeTransactionDetailsTbl = new HashSet<ServiceChargeTransactionDetailsTbl>();
            TaxBalanceTransactionDetailsTbl = new HashSet<TaxBalanceTransactionDetailsTbl>();
            TerminationTransactionTbl = new HashSet<TerminationTransactionTbl>();
            TicketTransactionTbl = new HashSet<TicketTransactionTbl>();
            VacationBalanceTbl = new HashSet<VacationBalanceTbl>();
            VacationRangeDeductionTbl = new HashSet<VacationRangeDeductionTbl>();
            VacationTransactionTbl = new HashSet<VacationTransactionTbl>();
            WorkPermissionTransactionTbl = new HashSet<WorkPermissionTransactionTbl>();
        }

        public long EmployeeId { get; set; }
        public long? PropertyId { get; set; }
        public string EmployeeCode { get; set; }
        public long? PrefixId { get; set; }
        public string FullEnName { get; set; }
        public string FirstEnName { get; set; }
        public string MiddleEnName { get; set; }
        public string LastEnName { get; set; }
        public string FullArName { get; set; }
        public string ShadowArName { get; set; }
        public string FirstArName { get; set; }
        public string MiddleArName { get; set; }
        public string LastArName { get; set; }
        public DateTime? BirthDate { get; set; }
        public byte? GenderId { get; set; }
        public long? ReligionId { get; set; }
        public long? MaritalStatusId { get; set; }
        public int? NumberOfChildren { get; set; }
        public string MaritalStatusNotes { get; set; }
        public bool? HandicappedYn { get; set; }
        public long? HandicappedTypeId { get; set; }
        public long? HandicappedLevelId { get; set; }
        public string HandicappedNotes { get; set; }
        public byte? BloodTypeId { get; set; }
        public bool? HealthFitnessYn { get; set; }
        public long? NationalityId { get; set; }
        public bool? ForeignerYn { get; set; }
        public string PassportNumber { get; set; }
        public string PassportIssuePlace { get; set; }
        public DateTime? PassportIssueDate { get; set; }
        public DateTime? PassportExpireDate { get; set; }
        public string NationalityNotes { get; set; }
        public string ResidencyNumber { get; set; }
        public long? ResidencyTypeId { get; set; }
        public string ResidencyIssuePlace { get; set; }
        public DateTime? ResidencyIssueDate { get; set; }
        public DateTime? ResidencyExpireDate { get; set; }
        public string ResidencyNotes { get; set; }
        public string CivilIdNumber { get; set; }
        public byte? CivilIdTypeId { get; set; }
        public string Office { get; set; }
        public long? GovernorateId { get; set; }
        public DateTime? CivilIdIssueDate { get; set; }
        public DateTime? CivilIdExpireDate { get; set; }
        public string BirthPlace { get; set; }
        public string CivilIdNotes { get; set; }
        public long? MilitaryStatusId { get; set; }
        public string MilitaryNumber { get; set; }
        public DateTime? MilitaryIssueDate { get; set; }
        public DateTime? MilitaryExpireDate { get; set; }
        public string MilitaryLocation { get; set; }
        public string MilitaryNotes { get; set; }
        public long? DivisionId { get; set; }
        public long? DepartmentId { get; set; }
        public long? SectionId { get; set; }
        public long? PositionId { get; set; }
        public bool? ManagerYn { get; set; }
        public byte? SecurityLevelId { get; set; }
        public byte? HousingTypeId { get; set; }
        public bool? SharedHousingYn { get; set; }
        public long? SponsorId { get; set; }
        public byte? EmploymentTypeId { get; set; }
        public DateTime? HiringDate { get; set; }
        public DateTime? ProbationPeriodExpireDate { get; set; }
        public long? ContractId { get; set; }
        public DateTime? ContractIssueDate { get; set; }
        public DateTime? ContractExpireDate { get; set; }
        public DateTime? FirstHiringDateInTheChain { get; set; }
        public double? FirstSalary { get; set; }
        public long? VacationRuleId { get; set; }
        public string AttendanceMachineClockNumber { get; set; }
        public long? AttendanceMachineScheduleRuleId { get; set; }
        public byte? TransportationTypeId { get; set; }
        public long? BusWayId { get; set; }
        public int? EmployeeYearlyTicketsDue { get; set; }
        public int? FamilyYearlyTicketsDue { get; set; }
        public long? AirplaneDestinationId { get; set; }
        public bool? HasCarYn { get; set; }
        public byte? WorkInGovernmentTypeId { get; set; }
        public bool? InsuranceYn { get; set; }
        public bool? CompanyDefrayInsuranceYn { get; set; }
        public long? InsuranceRuleId { get; set; }
        public long? InsuranceOfficeId { get; set; }
        public long? OrganizationLegalFormId { get; set; }
        public DateTime? InsuranceDate { get; set; }
        public string InsuranceNumber { get; set; }
        public double? FixedInsuranceValue { get; set; }
        public double? VariableInsuranceValue { get; set; }
        public DateTime? FirstInsuranceDate { get; set; }
        public string InsuranceNotes { get; set; }
        public long? CurrencyId { get; set; }
        public byte? SalaryCalculationWayId { get; set; }
        public double? DailySalary { get; set; }
        public long? TaxRuleId { get; set; }
        public bool? ManyCostCenterYn { get; set; }
        public bool? LifeInsuranceYn { get; set; }
        public double? LifeInsuranceAnnualValue { get; set; }
        public string AboutEmployee { get; set; }
        public double? GrossSalary { get; set; }
        public byte? EmployeeStatusId { get; set; }
        public string EmployeePhotoFileName { get; set; }
        public string EmployeePhotoPath { get; set; }
        public string EmployeePhoto { get; set; }
        public bool? SharedEmployeeYn { get; set; }
        public bool? CreateLoginDetailYn { get; set; }
        public string LoginPassword { get; set; }
        public DateTime? TerminationDate { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public int? ChildrenYearlyTicketsDue { get; set; }
        public bool? TicketsPerTwoYearsYn { get; set; }
        public int? DPaymentModeMonth { get; set; }
        public int? DPaymentModeYear { get; set; }
        public int? PreviousInsuranceMonths { get; set; }
        public string HandicappedCertificateNumber { get; set; }
        public DateTime? HandicappedCertificateDate { get; set; }

        public virtual AirplaneDestinationTbl AirplaneDestination { get; set; }
        public virtual AttendanceRuleTbl AttendanceMachineScheduleRule { get; set; }
        public virtual BloodTypeTbl BloodType { get; set; }
        public virtual BusWayTbl BusWay { get; set; }
        public virtual CivilIdTypeTbl CivilIdType { get; set; }
        public virtual ContractTbl Contract { get; set; }
        public virtual CurrencyTbl Currency { get; set; }
        public virtual DepartmentTbl Department { get; set; }
        public virtual DivisionTbl Division { get; set; }
        public virtual EmploymentTypeTbl EmploymentType { get; set; }
        public virtual GenderTbl Gender { get; set; }
        public virtual GovernorateTbl Governorate { get; set; }
        public virtual HandicappedLevelTbl HandicappedLevel { get; set; }
        public virtual HandicappedTypeTbl HandicappedType { get; set; }
        public virtual HousingTypeTbl HousingType { get; set; }
        public virtual InsuranceOfficeTbl InsuranceOffice { get; set; }
        public virtual InsuranceRuleTbl InsuranceRule { get; set; }
        public virtual MaritalStatusTbl MaritalStatus { get; set; }
        public virtual MilitaryStatusTbl MilitaryStatus { get; set; }
        public virtual NationalityTbl Nationality { get; set; }
        public virtual OrganizationLegalFormTbl OrganizationLegalForm { get; set; }
        public virtual PositionTbl Position { get; set; }
        public virtual PrefixTbl Prefix { get; set; }
        public virtual PropertyTbl Property { get; set; }
        public virtual ReligionTbl Religion { get; set; }
        public virtual ResidencyTypeTbl ResidencyType { get; set; }
        public virtual SalaryCalculationWayTbl SalaryCalculationWay { get; set; }
        public virtual SectionTbl Section { get; set; }
        public virtual SecurityLevelTbl SecurityLevel { get; set; }
        public virtual SponsorTbl Sponsor { get; set; }
        public virtual TaxRuleTbl TaxRule { get; set; }
        public virtual TransportationTypeTbl TransportationType { get; set; }
        public virtual VacationRuleTbl VacationRule { get; set; }
        public virtual WorkInGovernmentTypeTbl WorkInGovernmentType { get; set; }
        public virtual ICollection<AbsenceTransactionTbl> AbsenceTransactionTbl { get; set; }
        public virtual ICollection<AdditionalPaymentTransactionDetailsTbl> AdditionalPaymentTransactionDetailsTbl { get; set; }
        public virtual ICollection<AttendanceExceptionsTbl> AttendanceExceptionsTbl { get; set; }
        public virtual ICollection<AttendanceMachineLogTbl> AttendanceMachineLogTbl { get; set; }
        public virtual ICollection<BenefitTransactionTbl> BenefitTransactionTbl { get; set; }
        public virtual ICollection<BonusTransactionDetailsTbl> BonusTransactionDetailsTbl { get; set; }
        public virtual ICollection<CertificateTransactionTbl> CertificateTransactionTbl { get; set; }
        public virtual ICollection<ChangeOfStatusTransactionTbl> ChangeOfStatusTransactionTbl { get; set; }
        public virtual ICollection<ContractRenewalTransactionTbl> ContractRenewalTransactionTbl { get; set; }
        public virtual ICollection<CourseTransactionTbl> CourseTransactionTbl { get; set; }
        public virtual ICollection<CustodyTransactionTbl> CustodyTransactionTbl { get; set; }
        public virtual ICollection<DailyEmploymentAttendanceTransactionTbl> DailyEmploymentAttendanceTransactionTbl { get; set; }
        public virtual ICollection<DeductionTransactionTbl> DeductionTransactionTbl { get; set; }
        public virtual ICollection<DocumentBorrowingTransactionTbl> DocumentBorrowingTransactionTbl { get; set; }
        public virtual ICollection<EmployeeAddressTbl> EmployeeAddressTbl { get; set; }
        public virtual ICollection<EmployeeCommunicationTbl> EmployeeCommunicationTbl { get; set; }
        public virtual ICollection<EmployeeCostCenterTbl> EmployeeCostCenterTbl { get; set; }
        public virtual ICollection<EmployeeEmailTbl> EmployeeEmailTbl { get; set; }
        public virtual ICollection<EmployeeFeesTbl> EmployeeFeesTbl { get; set; }
        public virtual ICollection<EmployeeGroupTbl> EmployeeGroupTbl { get; set; }
        public virtual ICollection<EmployeeLanguageTbl> EmployeeLanguageTbl { get; set; }
        public virtual ICollection<EmployeeMonthlySalaryTbl> EmployeeMonthlySalaryTbl { get; set; }
        public virtual ICollection<EmployeePaymentModeTbl> EmployeePaymentModeTbl { get; set; }
        public virtual ICollection<EmployeeQualificationTbl> EmployeeQualificationTbl { get; set; }
        public virtual ICollection<EmployeeRelativeTbl> EmployeeRelativeTbl { get; set; }
        public virtual ICollection<EmployeeSharedPropertyTbl> EmployeeSharedPropertyTbl { get; set; }
        public virtual ICollection<EosBenifitTransactionTbl> EosBenifitTransactionTbl { get; set; }
        public virtual ICollection<HiringDocumentTransactionTbl> HiringDocumentTransactionTbl { get; set; }
        public virtual ICollection<HolidayAllowanceTransactionDetailsTbl> HolidayAllowanceTransactionDetailsTbl { get; set; }
        public virtual ICollection<LateTransactionTbl> LateTransactionTbl { get; set; }
        public virtual ICollection<LoanTransactionTbl> LoanTransactionTbl { get; set; }
        public virtual ICollection<MedicalCardsTransactionTbl> MedicalCardsTransactionTbl { get; set; }
        public virtual ICollection<MedicalFamilyCardsTransactionTbl> MedicalFamilyCardsTransactionTbl { get; set; }
        public virtual ICollection<MedicalFamilyInvoiceTransactionTbl> MedicalFamilyInvoiceTransactionTbl { get; set; }
        public virtual ICollection<MedicalFamilyMonthlyMedicineTransactionTbl> MedicalFamilyMonthlyMedicineTransactionTbl { get; set; }
        public virtual ICollection<MedicalFamilyVisitTransactionTbl> MedicalFamilyVisitTransactionTbl { get; set; }
        public virtual ICollection<MedicalInvoiceTransactionTbl> MedicalInvoiceTransactionTbl { get; set; }
        public virtual ICollection<MedicalVisitTransactionTbl> MedicalVisitTransactionTbl { get; set; }
        public virtual ICollection<MissionTransactionTbl> MissionTransactionTbl { get; set; }
        public virtual ICollection<MonthlyWorkingHoursTransactionTbl> MonthlyWorkingHoursTransactionTbl { get; set; }
        public virtual ICollection<OverTimeTransactionTbl> OverTimeTransactionTbl { get; set; }
        public virtual ICollection<PastExperienceTransactionTbl> PastExperienceTransactionTbl { get; set; }
        public virtual ICollection<PaymentTransactionTbl> PaymentTransactionTbl { get; set; }
        public virtual ICollection<PenaltyTransactionTbl> PenaltyTransactionTbl { get; set; }
        public virtual ICollection<PermissionTransactionTbl> PermissionTransactionTbl { get; set; }
        public virtual ICollection<RehireTransactionTbl> RehireTransactionTbl { get; set; }
        public virtual ICollection<ResidencyRenewalTransactionTbl> ResidencyRenewalTransactionTbl { get; set; }
        public virtual ICollection<SelfServiceApprovalTbl> SelfServiceApprovalTbl { get; set; }
        public virtual ICollection<SelfServiceRequestTbl> SelfServiceRequestTbl { get; set; }
        public virtual ICollection<ServiceChargeTransactionDetailsTbl> ServiceChargeTransactionDetailsTbl { get; set; }
        public virtual ICollection<TaxBalanceTransactionDetailsTbl> TaxBalanceTransactionDetailsTbl { get; set; }
        public virtual ICollection<TerminationTransactionTbl> TerminationTransactionTbl { get; set; }
        public virtual ICollection<TicketTransactionTbl> TicketTransactionTbl { get; set; }
        public virtual ICollection<VacationBalanceTbl> VacationBalanceTbl { get; set; }
        public virtual ICollection<VacationRangeDeductionTbl> VacationRangeDeductionTbl { get; set; }
        public virtual ICollection<VacationTransactionTbl> VacationTransactionTbl { get; set; }
        public virtual ICollection<WorkPermissionTransactionTbl> WorkPermissionTransactionTbl { get; set; }
    }
}
