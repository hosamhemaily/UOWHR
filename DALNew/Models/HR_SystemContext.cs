using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DALNew.Models
{
    public partial class HR_SystemContext : identitydbcontext
    {
        public HR_SystemContext()
        {
        }

        public HR_SystemContext(DbContextOptions<HR_SystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AbsenceTransactionTbl> AbsenceTransactionTbl { get; set; }
        public virtual DbSet<AccountNumberTbl> AccountNumberTbl { get; set; }
        public virtual DbSet<AdditionalPaymentTransactionDetailsTbl> AdditionalPaymentTransactionDetailsTbl { get; set; }
        public virtual DbSet<AdditionalPaymentTransactionTbl> AdditionalPaymentTransactionTbl { get; set; }
        public virtual DbSet<AirplaneDestinationTbl> AirplaneDestinationTbl { get; set; }
        public virtual DbSet<AirplaneTicketBalanceReportTbl> AirplaneTicketBalanceReportTbl { get; set; }
        public virtual DbSet<AppDetailsLogTbl> AppDetailsLogTbl { get; set; }
        public virtual DbSet<AppMasterLogTbl> AppMasterLogTbl { get; set; }
        public virtual DbSet<AppMenuReportTbl> AppMenuReportTbl { get; set; }
        public virtual DbSet<AppMenuTbl> AppMenuTbl { get; set; }
        public virtual DbSet<AppSettingsMasterTbl> AppSettingsMasterTbl { get; set; }
        public virtual DbSet<AppSettingsTbl> AppSettingsTbl { get; set; }
        
        public virtual DbSet<AttendanceAbsencePenaltyTbl> AttendanceAbsencePenaltyTbl { get; set; }
        public virtual DbSet<AttendanceActionTypeTbl> AttendanceActionTypeTbl { get; set; }
        public virtual DbSet<AttendanceCalculatedDataDetailsTbl> AttendanceCalculatedDataDetailsTbl { get; set; }
        public virtual DbSet<AttendanceCalculatedDataTbl> AttendanceCalculatedDataTbl { get; set; }
        public virtual DbSet<AttendanceDetailsTbl> AttendanceDetailsTbl { get; set; }
        public virtual DbSet<AttendanceExceptionsTbl> AttendanceExceptionsTbl { get; set; }
        public virtual DbSet<AttendanceLatePenaltyTbl> AttendanceLatePenaltyTbl { get; set; }
        public virtual DbSet<AttendanceLateTransactionTbl> AttendanceLateTransactionTbl { get; set; }
        public virtual DbSet<AttendanceMachineDetailsTbl> AttendanceMachineDetailsTbl { get; set; }
        public virtual DbSet<AttendanceMachineLogTbl> AttendanceMachineLogTbl { get; set; }
        public virtual DbSet<AttendanceMachineTbl> AttendanceMachineTbl { get; set; }
        public virtual DbSet<AttendanceOverTimeTransactionTbl> AttendanceOverTimeTransactionTbl { get; set; }
        public virtual DbSet<AttendanceRuleTbl> AttendanceRuleTbl { get; set; }
        public virtual DbSet<AttendanceSheetDataTbl> AttendanceSheetDataTbl { get; set; }
        public virtual DbSet<AttendanceSheetHeaderTbl> AttendanceSheetHeaderTbl { get; set; }
        public virtual DbSet<AttendanceTransactionFlagTbl> AttendanceTransactionFlagTbl { get; set; }
        public virtual DbSet<AutoNotificationTbl> AutoNotificationTbl { get; set; }
        public virtual DbSet<BankFileConfigurationDetailsTbl> BankFileConfigurationDetailsTbl { get; set; }
        public virtual DbSet<BankFileConfigurationSerialTbl> BankFileConfigurationSerialTbl { get; set; }
        public virtual DbSet<BankFileConfigurationTbl> BankFileConfigurationTbl { get; set; }
        public virtual DbSet<BankReportDetailsTbl> BankReportDetailsTbl { get; set; }
        public virtual DbSet<BankTbl> BankTbl { get; set; }
        public virtual DbSet<BenefitTbl> BenefitTbl { get; set; }
        public virtual DbSet<BenefitTransactionTbl> BenefitTransactionTbl { get; set; }
        public virtual DbSet<BloodTypeTbl> BloodTypeTbl { get; set; }
        public virtual DbSet<BonusDeductionsTbl> BonusDeductionsTbl { get; set; }
        public virtual DbSet<BonusPaymentsTbl> BonusPaymentsTbl { get; set; }
        public virtual DbSet<BonusRangesTbl> BonusRangesTbl { get; set; }
        public virtual DbSet<BonusTransactionDetailsTbl> BonusTransactionDetailsTbl { get; set; }
        public virtual DbSet<BonusTransactionTbl> BonusTransactionTbl { get; set; }
        public virtual DbSet<BonusTypeTbl> BonusTypeTbl { get; set; }
        public virtual DbSet<BonusWayTbl> BonusWayTbl { get; set; }
        public virtual DbSet<BusWayTbl> BusWayTbl { get; set; }
        public virtual DbSet<CalculationsLockTbl> CalculationsLockTbl { get; set; }
        public virtual DbSet<CashReportDetailsTbl> CashReportDetailsTbl { get; set; }
        public virtual DbSet<CertificateTbl> CertificateTbl { get; set; }
        public virtual DbSet<CertificateTransactionTbl> CertificateTransactionTbl { get; set; }
        public virtual DbSet<CertificateTypeTbl> CertificateTypeTbl { get; set; }
        public virtual DbSet<ChainTbl> ChainTbl { get; set; }
        public virtual DbSet<ChangeOfCostCenterDetailsTbl> ChangeOfCostCenterDetailsTbl { get; set; }
        public virtual DbSet<ChangeOfSalaryDetailsTbl> ChangeOfSalaryDetailsTbl { get; set; }
        public virtual DbSet<ChangeOfStatusDetailsTbl> ChangeOfStatusDetailsTbl { get; set; }
        public virtual DbSet<ChangeOfStatusReasonTbl> ChangeOfStatusReasonTbl { get; set; }
        public virtual DbSet<ChangeOfStatusTransactionTbl> ChangeOfStatusTransactionTbl { get; set; }
        public virtual DbSet<ChangeTypeTbl> ChangeTypeTbl { get; set; }
        public virtual DbSet<ChangeableFieldTbl> ChangeableFieldTbl { get; set; }
        public virtual DbSet<CivilIdTypeTbl> CivilIdTypeTbl { get; set; }
        public virtual DbSet<CommunicationTypeTbl> CommunicationTypeTbl { get; set; }
        public virtual DbSet<ComparisionReportDetailsTbl> ComparisionReportDetailsTbl { get; set; }
        public virtual DbSet<ComponentComparisionAnalysisReportDetailsTbl> ComponentComparisionAnalysisReportDetailsTbl { get; set; }
        public virtual DbSet<ComponentComparisionReportDetailsTbl> ComponentComparisionReportDetailsTbl { get; set; }
        public virtual DbSet<ContractRenewalTransactionTbl> ContractRenewalTransactionTbl { get; set; }
        public virtual DbSet<ContractTbl> ContractTbl { get; set; }
        public virtual DbSet<CountryTbl> CountryTbl { get; set; }
        public virtual DbSet<CourseTbl> CourseTbl { get; set; }
        public virtual DbSet<CourseTransactionTbl> CourseTransactionTbl { get; set; }
        public virtual DbSet<CurrencyTbl> CurrencyTbl { get; set; }
        public virtual DbSet<CustodyTbl> CustodyTbl { get; set; }
        public virtual DbSet<CustodyTransactionTbl> CustodyTransactionTbl { get; set; }
        public virtual DbSet<DailyEmploymentAttendanceTransactionTbl> DailyEmploymentAttendanceTransactionTbl { get; set; }
        public virtual DbSet<DailyHeadCountReportDetailsTbl> DailyHeadCountReportDetailsTbl { get; set; }
        public virtual DbSet<DayOfTheWeekTbl> DayOfTheWeekTbl { get; set; }
        public virtual DbSet<DaysTbl> DaysTbl { get; set; }
        public virtual DbSet<DeductionDetailsTbl> DeductionDetailsTbl { get; set; }
        public virtual DbSet<DeductionTbl> DeductionTbl { get; set; }
        public virtual DbSet<DeductionTransactionTbl> DeductionTransactionTbl { get; set; }
        public virtual DbSet<DeductionTypeTbl> DeductionTypeTbl { get; set; }
        public virtual DbSet<DepartmentTbl> DepartmentTbl { get; set; }
        public virtual DbSet<DeportedPenaltyTbl> DeportedPenaltyTbl { get; set; }
        public virtual DbSet<DiseaseTbl> DiseaseTbl { get; set; }
        public virtual DbSet<DivisionTbl> DivisionTbl { get; set; }
        public virtual DbSet<DocumentArchiveTbl> DocumentArchiveTbl { get; set; }
        public virtual DbSet<DocumentBorrowingTransactionTbl> DocumentBorrowingTransactionTbl { get; set; }
        public virtual DbSet<EmailConfigurationTbl> EmailConfigurationTbl { get; set; }
        public virtual DbSet<EmailTypeTbl> EmailTypeTbl { get; set; }
        public virtual DbSet<EmployeeAddressTbl> EmployeeAddressTbl { get; set; }
        public virtual DbSet<EmployeeCommunicationTbl> EmployeeCommunicationTbl { get; set; }
        public virtual DbSet<EmployeeCostCenterTbl> EmployeeCostCenterTbl { get; set; }
        public virtual DbSet<EmployeeDailySchedulesTbl> EmployeeDailySchedulesTbl { get; set; }
        public virtual DbSet<EmployeeEmailTbl> EmployeeEmailTbl { get; set; }
        public virtual DbSet<EmployeeFeesTbl> EmployeeFeesTbl { get; set; }
        public virtual DbSet<EmployeeGroupTbl> EmployeeGroupTbl { get; set; }
        public virtual DbSet<EmployeeLanguageTbl> EmployeeLanguageTbl { get; set; }
        public virtual DbSet<EmployeeMonthlySalaryTbl> EmployeeMonthlySalaryTbl { get; set; }
        public virtual DbSet<EmployeePaymentModeTbl> EmployeePaymentModeTbl { get; set; }
        public virtual DbSet<EmployeePaymentsReportTbl> EmployeePaymentsReportTbl { get; set; }
        public virtual DbSet<EmployeeQualificationTbl> EmployeeQualificationTbl { get; set; }
        public virtual DbSet<EmployeeRelativeTbl> EmployeeRelativeTbl { get; set; }
        public virtual DbSet<EmployeeSharedPropertyTbl> EmployeeSharedPropertyTbl { get; set; }
        public virtual DbSet<EmployeeStatusTbl> EmployeeStatusTbl { get; set; }
        public virtual DbSet<EmployeeTbl> EmployeeTbl { get; set; }
        public virtual DbSet<EmployeeVacationBalanceTbl> EmployeeVacationBalanceTbl { get; set; }
        public virtual DbSet<EmploymentTypeTbl> EmploymentTypeTbl { get; set; }
        public virtual DbSet<EosBenefitAccrualReportTbl> EosBenefitAccrualReportTbl { get; set; }
        public virtual DbSet<EosBenifitTransactionTbl> EosBenifitTransactionTbl { get; set; }
        public virtual DbSet<EosRuleDetailsTbl> EosRuleDetailsTbl { get; set; }
        public virtual DbSet<EosRuleTbl> EosRuleTbl { get; set; }
        public virtual DbSet<ExpiredFieldTbl> ExpiredFieldTbl { get; set; }
        public virtual DbSet<FacultyTbl> FacultyTbl { get; set; }
        public virtual DbSet<GenderTbl> GenderTbl { get; set; }
        public virtual DbSet<GovernorateTbl> GovernorateTbl { get; set; }
        public virtual DbSet<GradeTbl> GradeTbl { get; set; }
        public virtual DbSet<GroupTbl> GroupTbl { get; set; }
        public virtual DbSet<HandicappedLevelTbl> HandicappedLevelTbl { get; set; }
        public virtual DbSet<HandicappedTypeTbl> HandicappedTypeTbl { get; set; }
        public virtual DbSet<HiringDocumentTbl> HiringDocumentTbl { get; set; }
        public virtual DbSet<HiringDocumentTransactionTbl> HiringDocumentTransactionTbl { get; set; }
        public virtual DbSet<HolidayAllowanceTransactionDetailsTbl> HolidayAllowanceTransactionDetailsTbl { get; set; }
        public virtual DbSet<HolidayAllowanceTransactionTbl> HolidayAllowanceTransactionTbl { get; set; }
        public virtual DbSet<HolidayAllowanceTypeTbl> HolidayAllowanceTypeTbl { get; set; }
        public virtual DbSet<HousingTypeTbl> HousingTypeTbl { get; set; }
        public virtual DbSet<InsuranceOfficeTbl> InsuranceOfficeTbl { get; set; }
        public virtual DbSet<InsuranceRuleTbl> InsuranceRuleTbl { get; set; }
        public virtual DbSet<InsuranceStatusTbl> InsuranceStatusTbl { get; set; }
        public virtual DbSet<InterfaceTbl> InterfaceTbl { get; set; }
        public virtual DbSet<JobDescriptionTbl> JobDescriptionTbl { get; set; }
        public virtual DbSet<JobLanguageSkillsTbl> JobLanguageSkillsTbl { get; set; }
        public virtual DbSet<JobResponsibilityTbl> JobResponsibilityTbl { get; set; }
        public virtual DbSet<JobTechnicalSkillsTbl> JobTechnicalSkillsTbl { get; set; }
        public virtual DbSet<JvCalculationTbl> JvCalculationTbl { get; set; }
        public virtual DbSet<JvConfigurationTbl> JvConfigurationTbl { get; set; }
        public virtual DbSet<JvReportDetailsTbl> JvReportDetailsTbl { get; set; }
        public virtual DbSet<LanguageDegreeTbl> LanguageDegreeTbl { get; set; }
        public virtual DbSet<LanguageTbl> LanguageTbl { get; set; }
        public virtual DbSet<LateTransactionTbl> LateTransactionTbl { get; set; }
        public virtual DbSet<LateTypeTbl> LateTypeTbl { get; set; }
        public virtual DbSet<LicenseTypeTbl> LicenseTypeTbl { get; set; }
        public virtual DbSet<LoanTbl> LoanTbl { get; set; }
        public virtual DbSet<LoanTransactionDetailsTbl> LoanTransactionDetailsTbl { get; set; }
        public virtual DbSet<LoanTransactionTbl> LoanTransactionTbl { get; set; }
        public virtual DbSet<LockedRecordTbl> LockedRecordTbl { get; set; }
        public virtual DbSet<MachineTbl> MachineTbl { get; set; }
        public virtual DbSet<MaritalStatusTbl> MaritalStatusTbl { get; set; }
        public virtual DbSet<MaritalStatusTypeTbl> MaritalStatusTypeTbl { get; set; }
        public virtual DbSet<MedicalBenefitTbl> MedicalBenefitTbl { get; set; }
        public virtual DbSet<MedicalBenefitTransactionTbl> MedicalBenefitTransactionTbl { get; set; }
        public virtual DbSet<MedicalCardsTransactionTbl> MedicalCardsTransactionTbl { get; set; }
        public virtual DbSet<MedicalDegreeDetailsTbl> MedicalDegreeDetailsTbl { get; set; }
        public virtual DbSet<MedicalDegreeTbl> MedicalDegreeTbl { get; set; }
        public virtual DbSet<MedicalFamilyCardsTransactionTbl> MedicalFamilyCardsTransactionTbl { get; set; }
        public virtual DbSet<MedicalFamilyInvoiceTransactionDetailsTbl> MedicalFamilyInvoiceTransactionDetailsTbl { get; set; }
        public virtual DbSet<MedicalFamilyInvoiceTransactionTbl> MedicalFamilyInvoiceTransactionTbl { get; set; }
        public virtual DbSet<MedicalFamilyMonthlyMedicineTransactionTbl> MedicalFamilyMonthlyMedicineTransactionTbl { get; set; }
        public virtual DbSet<MedicalFamilyVisitTransactionTbl> MedicalFamilyVisitTransactionTbl { get; set; }
        public virtual DbSet<MedicalInvoiceTransactionDetailsTbl> MedicalInvoiceTransactionDetailsTbl { get; set; }
        public virtual DbSet<MedicalInvoiceTransactionTbl> MedicalInvoiceTransactionTbl { get; set; }
        public virtual DbSet<MedicalMonthlyMedicineTransactionTbl> MedicalMonthlyMedicineTransactionTbl { get; set; }
        public virtual DbSet<MedicalTypeTbl> MedicalTypeTbl { get; set; }
        public virtual DbSet<MedicalVisitTransactionTbl> MedicalVisitTransactionTbl { get; set; }
        public virtual DbSet<MedicineTbl> MedicineTbl { get; set; }
        public virtual DbSet<MilitaryStatusTbl> MilitaryStatusTbl { get; set; }
        public virtual DbSet<MissionExpensesTransactionTbl> MissionExpensesTransactionTbl { get; set; }
        public virtual DbSet<MissionExpensesTypeTbl> MissionExpensesTypeTbl { get; set; }
        public virtual DbSet<MissionTransactionTbl> MissionTransactionTbl { get; set; }
        public virtual DbSet<ModuleGenericEmailTbl> ModuleGenericEmailTbl { get; set; }
        public virtual DbSet<MonthTbl> MonthTbl { get; set; }
        public virtual DbSet<MonthlyActualAttendanceTbl> MonthlyActualAttendanceTbl { get; set; }
        public virtual DbSet<MonthlyCalculationsTbl> MonthlyCalculationsTbl { get; set; }
        public virtual DbSet<MonthlyCurrencyRateTbl> MonthlyCurrencyRateTbl { get; set; }
        public virtual DbSet<MonthlyTicketRateTbl> MonthlyTicketRateTbl { get; set; }
        public virtual DbSet<MonthlyWorkingHoursTransactionTbl> MonthlyWorkingHoursTransactionTbl { get; set; }
        public virtual DbSet<NationalityTbl> NationalityTbl { get; set; }
        public virtual DbSet<NotificationConfigurationTbl> NotificationConfigurationTbl { get; set; }
        public virtual DbSet<OrganizationLegalFormTbl> OrganizationLegalFormTbl { get; set; }
        public virtual DbSet<OverTimeTransactionTbl> OverTimeTransactionTbl { get; set; }
        public virtual DbSet<OverTimeTypeTbl> OverTimeTypeTbl { get; set; }
        public virtual DbSet<PastExperiencePlaceTbl> PastExperiencePlaceTbl { get; set; }
        public virtual DbSet<PastExperienceTransactionTbl> PastExperienceTransactionTbl { get; set; }
        public virtual DbSet<PaymentDetailsTbl> PaymentDetailsTbl { get; set; }
        public virtual DbSet<PaymentFunctionTbl> PaymentFunctionTbl { get; set; }
        public virtual DbSet<PaymentGroupDetailsTbl> PaymentGroupDetailsTbl { get; set; }
        public virtual DbSet<PaymentGroupTbl> PaymentGroupTbl { get; set; }
        public virtual DbSet<PaymentModeTypeTbl> PaymentModeTypeTbl { get; set; }
        public virtual DbSet<PaymentStatusTbl> PaymentStatusTbl { get; set; }
        public virtual DbSet<PaymentTbl> PaymentTbl { get; set; }
        public virtual DbSet<PaymentTransactionTbl> PaymentTransactionTbl { get; set; }
        public virtual DbSet<PaymentTypeTbl> PaymentTypeTbl { get; set; }
        public virtual DbSet<PenaltyRepeatTbl> PenaltyRepeatTbl { get; set; }
        public virtual DbSet<PenaltyTbl> PenaltyTbl { get; set; }
        public virtual DbSet<PenaltyTransactionTbl> PenaltyTransactionTbl { get; set; }
        public virtual DbSet<PenaltyTypeTbl> PenaltyTypeTbl { get; set; }
        public virtual DbSet<PermissionTransactionTbl> PermissionTransactionTbl { get; set; }
        public virtual DbSet<PermissionTypeTbl> PermissionTypeTbl { get; set; }
        public virtual DbSet<PositionConfigurationTbl> PositionConfigurationTbl { get; set; }
        public virtual DbSet<PositionTbl> PositionTbl { get; set; }
        public virtual DbSet<PositionTypeTbl> PositionTypeTbl { get; set; }
        public virtual DbSet<PrefixTbl> PrefixTbl { get; set; }
        public virtual DbSet<PropertyTbl> PropertyTbl { get; set; }
        public virtual DbSet<PublicHolidayTbl> PublicHolidayTbl { get; set; }
        public virtual DbSet<QualificationGradeTbl> QualificationGradeTbl { get; set; }
        public virtual DbSet<QualificationTbl> QualificationTbl { get; set; }
        public virtual DbSet<QualificationTypeTbl> QualificationTypeTbl { get; set; }
        public virtual DbSet<RehireTransactionTbl> RehireTransactionTbl { get; set; }
        public virtual DbSet<RelativeDegreeTbl> RelativeDegreeTbl { get; set; }
        public virtual DbSet<RelativeDegreeTypeTbl> RelativeDegreeTypeTbl { get; set; }
        public virtual DbSet<ReligionTbl> ReligionTbl { get; set; }
        public virtual DbSet<ReportGeneratorFieldTbl> ReportGeneratorFieldTbl { get; set; }
        public virtual DbSet<ReportGeneratorFilterTbl> ReportGeneratorFilterTbl { get; set; }
        public virtual DbSet<ReportGeneratorGroupTbl> ReportGeneratorGroupTbl { get; set; }
        public virtual DbSet<ReportGeneratorTbl> ReportGeneratorTbl { get; set; }
        public virtual DbSet<ReportSignatureTbl> ReportSignatureTbl { get; set; }
        public virtual DbSet<ReportToTbl> ReportToTbl { get; set; }
        public virtual DbSet<ResidencyRenewalTransactionTbl> ResidencyRenewalTransactionTbl { get; set; }
        public virtual DbSet<ResidencyTypeTbl> ResidencyTypeTbl { get; set; }
        public virtual DbSet<SalaryCalculationWayTbl> SalaryCalculationWayTbl { get; set; }
        public virtual DbSet<ScheduleTbl> ScheduleTbl { get; set; }
        public virtual DbSet<SectionTbl> SectionTbl { get; set; }
        public virtual DbSet<SecurityLevelTbl> SecurityLevelTbl { get; set; }
        public virtual DbSet<SelfServiceApprovalTbl> SelfServiceApprovalTbl { get; set; }
        public virtual DbSet<SelfServiceDelegationTbl> SelfServiceDelegationTbl { get; set; }
        public virtual DbSet<SelfServiceEffectsApprovalTbl> SelfServiceEffectsApprovalTbl { get; set; }
        public virtual DbSet<SelfServiceRequestDetailsTbl> SelfServiceRequestDetailsTbl { get; set; }
        public virtual DbSet<SelfServiceRequestTbl> SelfServiceRequestTbl { get; set; }
        public virtual DbSet<SelfServicesAttendanceApprovalTbl> SelfServicesAttendanceApprovalTbl { get; set; }
        public virtual DbSet<ServiceChargeConfigurationTbl> ServiceChargeConfigurationTbl { get; set; }
        public virtual DbSet<ServiceChargeStatusTbl> ServiceChargeStatusTbl { get; set; }
        public virtual DbSet<ServiceChargeTransactionDetailsTbl> ServiceChargeTransactionDetailsTbl { get; set; }
        public virtual DbSet<ServiceChargeTransactionTbl> ServiceChargeTransactionTbl { get; set; }
        public virtual DbSet<SmsConfigurationTbl> SmsConfigurationTbl { get; set; }
        public virtual DbSet<SpecialHolidayTbl> SpecialHolidayTbl { get; set; }
        public virtual DbSet<SpecialityTbl> SpecialityTbl { get; set; }
        public virtual DbSet<SponsorTbl> SponsorTbl { get; set; }
        public virtual DbSet<SponsorTypeTbl> SponsorTypeTbl { get; set; }
        public virtual DbSet<SummaryReportConfigurationTbl> SummaryReportConfigurationTbl { get; set; }
        public virtual DbSet<SysAttendanceMachineSdkTbl> SysAttendanceMachineSdkTbl { get; set; }
        public virtual DbSet<SysBankFileDetailsFieldTbl> SysBankFileDetailsFieldTbl { get; set; }
        public virtual DbSet<SysColorTbl> SysColorTbl { get; set; }
        public virtual DbSet<SysDateFormatTbl> SysDateFormatTbl { get; set; }
        public virtual DbSet<SysDbScriptsTbl> SysDbScriptsTbl { get; set; }
        public virtual DbSet<SysDocumentTypeTbl> SysDocumentTypeTbl { get; set; }
        public virtual DbSet<SysEmailSetupTypeTbl> SysEmailSetupTypeTbl { get; set; }
        public virtual DbSet<SysEmailTypeTbl> SysEmailTypeTbl { get; set; }
        public virtual DbSet<SysExchangeTypeTbl> SysExchangeTypeTbl { get; set; }
        public virtual DbSet<SysFieldNameTbl> SysFieldNameTbl { get; set; }
        public virtual DbSet<SysMedicalVacationTypeTbl> SysMedicalVacationTypeTbl { get; set; }
        public virtual DbSet<SysMessageTypeTbl> SysMessageTypeTbl { get; set; }
        public virtual DbSet<SysNotificationCcTypeTbl> SysNotificationCcTypeTbl { get; set; }
        public virtual DbSet<SysNotificationFieldTbl> SysNotificationFieldTbl { get; set; }
        public virtual DbSet<SysPeriodTbl> SysPeriodTbl { get; set; }
        public virtual DbSet<SysReportFilterTbl> SysReportFilterTbl { get; set; }
        public virtual DbSet<SysReportGeneratorFieldNameTbl> SysReportGeneratorFieldNameTbl { get; set; }
        public virtual DbSet<SysReportGeneratorTbl> SysReportGeneratorTbl { get; set; }
        public virtual DbSet<SysReportParameterTbl> SysReportParameterTbl { get; set; }
        public virtual DbSet<SysReportTbl> SysReportTbl { get; set; }
        public virtual DbSet<SysReportToTypeTbl> SysReportToTypeTbl { get; set; }
        public virtual DbSet<SysRequestStatusTbl> SysRequestStatusTbl { get; set; }
        public virtual DbSet<SysRequestTypeTbl> SysRequestTypeTbl { get; set; }
        public virtual DbSet<SysSalaryCalculationWayTbl> SysSalaryCalculationWayTbl { get; set; }
        public virtual DbSet<SysSmsCategoryTbl> SysSmsCategoryTbl { get; set; }
        public virtual DbSet<SysSmsTypeTbl> SysSmsTypeTbl { get; set; }
        public virtual DbSet<SysTableTbl> SysTableTbl { get; set; }
        public virtual DbSet<SysTranslationLangTbl> SysTranslationLangTbl { get; set; }
        public virtual DbSet<TaxBalanceConfigurationTbl> TaxBalanceConfigurationTbl { get; set; }
        public virtual DbSet<TaxBalanceTransactionDetailsTbl> TaxBalanceTransactionDetailsTbl { get; set; }
        public virtual DbSet<TaxBalanceTransactionTbl> TaxBalanceTransactionTbl { get; set; }
        public virtual DbSet<TaxFormulaTbl> TaxFormulaTbl { get; set; }
        public virtual DbSet<TaxGrossUpFormulaTbl> TaxGrossUpFormulaTbl { get; set; }
        public virtual DbSet<TaxRuleTbl> TaxRuleTbl { get; set; }
        public virtual DbSet<TaxSliceTbl> TaxSliceTbl { get; set; }
        public virtual DbSet<TempPayrollData5Tbl> TempPayrollData5Tbl { get; set; }
        public virtual DbSet<TerminationReasonTbl> TerminationReasonTbl { get; set; }
        public virtual DbSet<TerminationTransactionTbl> TerminationTransactionTbl { get; set; }
        public virtual DbSet<TicketTransactionTbl> TicketTransactionTbl { get; set; }
        public virtual DbSet<TransactionTypeTbl> TransactionTypeTbl { get; set; }
        public virtual DbSet<TransportationTypeTbl> TransportationTypeTbl { get; set; }
        public virtual DbSet<UniversityTbl> UniversityTbl { get; set; }
        public virtual DbSet<UnlockTransactionTbl> UnlockTransactionTbl { get; set; }
        public virtual DbSet<UserFavoriteReportTbl> UserFavoriteReportTbl { get; set; }
        public virtual DbSet<UserFormSecurityTbl> UserFormSecurityTbl { get; set; }
        public virtual DbSet<UserGeneralFunctionSecurityTbl> UserGeneralFunctionSecurityTbl { get; set; }
        public virtual DbSet<UserGeneralFunctionTbl> UserGeneralFunctionTbl { get; set; }
        public virtual DbSet<UserGeneratedReportSecurityTbl> UserGeneratedReportSecurityTbl { get; set; }
        public virtual DbSet<UserGroupFormSecurityTbl> UserGroupFormSecurityTbl { get; set; }
        public virtual DbSet<UserGroupModuleTbl> UserGroupModuleTbl { get; set; }
        public virtual DbSet<UserGroupReportSecurityTbl> UserGroupReportSecurityTbl { get; set; }
        public virtual DbSet<UserGroupRightsTbl> UserGroupRightsTbl { get; set; }
        public virtual DbSet<UserGroupTbl> UserGroupTbl { get; set; }
        public virtual DbSet<UserModuleTbl> UserModuleTbl { get; set; }
        public virtual DbSet<UserReportSecurityTbl> UserReportSecurityTbl { get; set; }
        public virtual DbSet<UserTbl> UserTbl { get; set; }
        public virtual DbSet<VacationBalanceDetailsTbl> VacationBalanceDetailsTbl { get; set; }
        public virtual DbSet<VacationBalanceTbl> VacationBalanceTbl { get; set; }
        public virtual DbSet<VacationCategoryTbl> VacationCategoryTbl { get; set; }
        public virtual DbSet<VacationDeductionInterfaceTbl> VacationDeductionInterfaceTbl { get; set; }
        public virtual DbSet<VacationPaymentInterfaceTbl> VacationPaymentInterfaceTbl { get; set; }
        public virtual DbSet<VacationRangeDeductionTbl> VacationRangeDeductionTbl { get; set; }
        public virtual DbSet<VacationRangeSliceTbl> VacationRangeSliceTbl { get; set; }
        public virtual DbSet<VacationRuleAgeYearsTbl> VacationRuleAgeYearsTbl { get; set; }
        public virtual DbSet<VacationRuleTbl> VacationRuleTbl { get; set; }
        public virtual DbSet<VacationRuleWorkingMonthTbl> VacationRuleWorkingMonthTbl { get; set; }
        public virtual DbSet<VacationTransactionTbl> VacationTransactionTbl { get; set; }
        public virtual DbSet<VacationTypeTbl> VacationTypeTbl { get; set; }
        public virtual DbSet<WorkInGovernmentTypeTbl> WorkInGovernmentTypeTbl { get; set; }
        public virtual DbSet<WorkPermissionTransactionTbl> WorkPermissionTransactionTbl { get; set; }
        public virtual DbSet<YearTbl> YearTbl { get; set; }
        public virtual DbSet<YearlyHeadCountReportDetailsTbl> YearlyHeadCountReportDetailsTbl { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AbsenceTransactionTbl>(entity =>
            {
                entity.HasKey(e => new { e.AbsenceTransactionId, e.AttendanceTypeId });

                entity.ToTable("Absence_Transaction_Tbl");

                entity.Property(e => e.AbsenceTransactionId)
                    .HasColumnName("Absence_Transaction_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AttendanceTypeId)
                    .HasColumnName("Attendance_Type_ID")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.DaysNumber).HasColumnName("Days_Number");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.FromDate)
                    .HasColumnName("From_Date")
                    .HasColumnType("date");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.PenaltyTransactionId).HasColumnName("Penalty_Transaction_ID");

                entity.Property(e => e.PenaltyYn).HasColumnName("Penalty_YN");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.SysRequestStatusId).HasColumnName("Sys_Request_Status_ID");

                entity.Property(e => e.ThrowMachineYn).HasColumnName("Throw_Machine_YN");

                entity.Property(e => e.ToDate)
                    .HasColumnName("To_Date")
                    .HasColumnType("date");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.Property(e => e.WithoutPermissionYn).HasColumnName("Without_Permission_YN");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.AbsenceTransactionTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Absence_Transaction_Tbl_Employee_Tbl");

                entity.HasOne(d => d.SysRequestStatus)
                    .WithMany(p => p.AbsenceTransactionTbl)
                    .HasForeignKey(d => d.SysRequestStatusId)
                    .HasConstraintName("FK_Absence_Transaction_Tbl_Sys_Request_Status_ID");
            });

            modelBuilder.Entity<AccountNumberTbl>(entity =>
            {
                entity.HasKey(e => e.AccountNumberId);

                entity.ToTable("Account_Number_Tbl");

                entity.Property(e => e.AccountNumberId).HasColumnName("Account_Number_ID");

                entity.Property(e => e.AccountNumberArName)
                    .HasColumnName("Account_Number_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.AccountNumberArNameShadow)
                    .HasColumnName("Account_Number_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.AccountNumberCode)
                    .HasColumnName("Account_Number_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.AccountNumberEnName)
                    .HasColumnName("Account_Number_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.AccountNumberJvDescription)
                    .HasColumnName("Account_Number_JV_Description")
                    .HasMaxLength(100);

                entity.Property(e => e.AnalyticalYn).HasColumnName("Analytical_YN");

                entity.Property(e => e.ClearanceAccountNumber)
                    .HasColumnName("Clearance_Account_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.ForeignersAccountNumber)
                    .HasColumnName("Foreigners_Account_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.GeneralAccountNumber)
                    .HasColumnName("General_Account_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.GuestContactAccountNumber)
                    .HasColumnName("Guest_Contact_Account_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.HandicappedAccountNumber)
                    .HasColumnName("Handicapped_Account_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.ManagersAccountNumber)
                    .HasColumnName("Managers_Account_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.NonGuestContactAccountNumber)
                    .HasColumnName("Non_Guest_Contact_Account_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.OtherGuestContactAccountNumber)
                    .HasColumnName("Other_Guest_Contact_Account_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<AdditionalPaymentTransactionDetailsTbl>(entity =>
            {
                entity.HasKey(e => e.AdditionalPaymentTransactionDetailsId);

                entity.ToTable("Additional_Payment_Transaction_Details_Tbl");

                entity.Property(e => e.AdditionalPaymentTransactionDetailsId).HasColumnName("Additional_Payment_Transaction_Details_ID");

                entity.Property(e => e.ActiveYn)
                    .HasColumnName("Active_YN")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AdditionalPaymentTransactionId).HasColumnName("Additional_Payment_Transaction_ID");

                entity.Property(e => e.CurrencyId).HasColumnName("Currency_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PaymentNetValue).HasColumnName("Payment_Net_Value");

                entity.Property(e => e.PaymentTax).HasColumnName("Payment_Tax");

                entity.Property(e => e.PaymentValueAfterCalc).HasColumnName("Payment_Value_After_Calc");

                entity.Property(e => e.PaymentValueBeforeCalc).HasColumnName("Payment_Value_Before_Calc");

                entity.Property(e => e.TaxableYn).HasColumnName("Taxable_YN");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.AdditionalPaymentTransaction)
                    .WithMany(p => p.AdditionalPaymentTransactionDetailsTbl)
                    .HasForeignKey(d => d.AdditionalPaymentTransactionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Additional_Payment_Transaction_Details_Tbl_Additional_Payment_Transaction_Tbl");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.AdditionalPaymentTransactionDetailsTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Additional_Payment_Transaction_Details_Tbl_Employee_Tbl");
            });

            modelBuilder.Entity<AdditionalPaymentTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.AdditionalPaymentTransactionId);

                entity.ToTable("Additional_Payment_Transaction_Tbl");

                entity.Property(e => e.AdditionalPaymentTransactionId).HasColumnName("Additional_Payment_Transaction_ID");

                entity.Property(e => e.AdditionalPaymentDate)
                    .HasColumnName("Additional_Payment_Date")
                    .HasColumnType("date");

                entity.Property(e => e.DescriptionAr)
                    .HasColumnName("Description_Ar")
                    .HasMaxLength(200);

                entity.Property(e => e.DescriptionEn)
                    .HasColumnName("Description_En")
                    .HasMaxLength(200);

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PaidYn)
                    .HasColumnName("Paid_YN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PayWay).HasColumnName("Pay_Way");

                entity.Property(e => e.PaymentId).HasColumnName("Payment_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.TaxableYn).HasColumnName("Taxable_YN");

                entity.Property(e => e.TheMonth).HasColumnName("The_Month");

                entity.Property(e => e.TheYear).HasColumnName("The_Year");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.AdditionalPaymentTransactionTbl)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_Additional_Payment_Transaction_Tbl_Payment_Tbl");
            });

            modelBuilder.Entity<AirplaneDestinationTbl>(entity =>
            {
                entity.HasKey(e => e.AirplaneDestinationId);

                entity.ToTable("Airplane_Destination_Tbl");

                entity.Property(e => e.AirplaneDestinationId).HasColumnName("Airplane_Destination_ID");

                entity.Property(e => e.AirplaneDestinationArName)
                    .HasColumnName("Airplane_Destination_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.AirplaneDestinationArNameShadow)
                    .HasColumnName("Airplane_Destination_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.AirplaneDestinationCode)
                    .HasColumnName("Airplane_Destination_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.AirplaneDestinationEnName)
                    .HasColumnName("Airplane_Destination_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<AirplaneTicketBalanceReportTbl>(entity =>
            {
                entity.HasKey(e => e.AirplaneTicketBalanceReportId);

                entity.ToTable("Airplane_Ticket_Balance_Report_Tbl");

                entity.Property(e => e.AirplaneTicketBalanceReportId).HasColumnName("Airplane_Ticket_Balance_Report_ID");

                entity.Property(e => e.ChildRate).HasColumnName("Child_Rate");

                entity.Property(e => e.ChildrenTicketsConsumed).HasColumnName("Children_Tickets_Consumed");

                entity.Property(e => e.ChildrenYearlyTicketsDue).HasColumnName("Children_Yearly_Tickets_Due");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.EmployeeTicketsConsumed).HasColumnName("Employee_Tickets_Consumed");

                entity.Property(e => e.EmployeeYearlyTicketsDue).HasColumnName("Employee_Yearly_Tickets_Due");

                entity.Property(e => e.FamilyTicketsConsumed).HasColumnName("Family_Tickets_Consumed");

                entity.Property(e => e.FamilyYearlyTicketsDue).HasColumnName("Family_Yearly_Tickets_Due");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.TicketRate).HasColumnName("Ticket_Rate");

                entity.Property(e => e.UserId).HasColumnName("User_ID");
            });

            modelBuilder.Entity<AppDetailsLogTbl>(entity =>
            {
                entity.HasKey(e => e.DetailsLogId);

                entity.ToTable("App_Details_Log_Tbl");

                entity.Property(e => e.DetailsLogId).HasColumnName("Details_Log_ID");

                entity.Property(e => e.FieldName)
                    .HasColumnName("Field_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MasterLogId).HasColumnName("Master_Log_ID");

                entity.Property(e => e.NewArValue)
                    .HasColumnName("New_Ar_Value")
                    .IsUnicode(false);

                entity.Property(e => e.NewEnValue)
                    .HasColumnName("New_En_Value")
                    .IsUnicode(false);

                entity.Property(e => e.OldArValue)
                    .HasColumnName("Old_Ar_Value")
                    .IsUnicode(false);

                entity.Property(e => e.OldEnValue)
                    .HasColumnName("Old_En_Value")
                    .IsUnicode(false);

                entity.HasOne(d => d.MasterLog)
                    .WithMany(p => p.AppDetailsLogTbl)
                    .HasForeignKey(d => d.MasterLogId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_App_Details_Log_Tbl_App_Master_Log_Tbl");
            });

            modelBuilder.Entity<AppMasterLogTbl>(entity =>
            {
                entity.HasKey(e => e.MasterLogId);

                entity.ToTable("App_Master_Log_Tbl");

                entity.Property(e => e.MasterLogId).HasColumnName("Master_Log_ID");

                entity.Property(e => e.ActionDate)
                    .HasColumnName("Action_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ActionType)
                    .HasColumnName("Action_Type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AppUserId).HasColumnName("App_User_ID");

                entity.Property(e => e.DescriptionAr)
                    .HasColumnName("Description_Ar")
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionEn)
                    .HasColumnName("Description_En")
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.RecId).HasColumnName("Rec_ID");

                entity.Property(e => e.UserGroupId).HasColumnName("User_Group_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");
            });

            modelBuilder.Entity<AppMenuReportTbl>(entity =>
            {
                entity.HasKey(e => e.AppMenuReportId);

                entity.ToTable("App_Menu_Report_Tbl");

                entity.Property(e => e.AppMenuReportId).HasColumnName("App_Menu_Report_ID");

                entity.Property(e => e.AppMenuId).HasColumnName("App_Menu_ID");

                entity.Property(e => e.ReportLanguageEnAr)
                    .HasColumnName("Report_Language_EN_AR")
                    .HasMaxLength(2);

                entity.Property(e => e.ReportType)
                    .HasColumnName("Report_Type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SysReportId).HasColumnName("Sys_Report_ID");
            });

            modelBuilder.Entity<AppMenuTbl>(entity =>
            {
                entity.HasKey(e => e.AppMenuId);

                entity.ToTable("App_Menu_Tbl");

                entity.Property(e => e.AppMenuId)
                    .HasColumnName("App_Menu_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppMenuArName)
                    .HasColumnName("App_Menu_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.AppMenuEnName)
                    .HasColumnName("App_Menu_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.AppMenuTableName)
                    .HasColumnName("App_Menu_Table_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.AppMenuType)
                    .HasColumnName("App_Menu_Type")
                    .HasMaxLength(20);

                entity.Property(e => e.AppMenuValuePath)
                    .HasColumnName("App_Menu_Value_Path")
                    .HasMaxLength(50);

                entity.Property(e => e.AppSettingId).HasColumnName("App_Setting_ID");

                entity.Property(e => e.DeleteYn).HasColumnName("Delete_YN");

                entity.Property(e => e.DisplayOrder).HasColumnName("Display_Order");

                entity.Property(e => e.DisplayYn).HasColumnName("Display_YN");

                entity.Property(e => e.InsertYn).HasColumnName("Insert_YN");

                entity.Property(e => e.LicenseTypeId).HasColumnName("License_Type_ID");

                entity.Property(e => e.ModuleId).HasColumnName("Module_ID");

                entity.Property(e => e.ParentId).HasColumnName("Parent_ID");

                entity.Property(e => e.ScreenImgAr)
                    .HasColumnName("ScreenImg_Ar")
                    .HasMaxLength(100);

                entity.Property(e => e.ScreenImgEn)
                    .HasColumnName("ScreenImg_En")
                    .HasMaxLength(255);

                entity.Property(e => e.ScreenUrlAr)
                    .HasColumnName("ScreenUrl_Ar")
                    .HasMaxLength(255);

                entity.Property(e => e.ScreenUrlEn)
                    .HasColumnName("ScreenUrl_EN")
                    .HasMaxLength(255);

                entity.Property(e => e.SubordinateYn)
                    .HasColumnName("Subordinate_YN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateYn).HasColumnName("Update_YN");

                entity.Property(e => e.ViewYn).HasColumnName("View_YN");

                entity.HasOne(d => d.LicenseType)
                    .WithMany(p => p.AppMenuTbl)
                    .HasForeignKey(d => d.LicenseTypeId)
                    .HasConstraintName("FK_App_Menu_Tbl_License_Type_Tbl");
            });

            modelBuilder.Entity<AppSettingsMasterTbl>(entity =>
            {
                entity.HasKey(e => e.AppSettingMasterId);

                entity.ToTable("App_Settings_Master_Tbl");

                entity.Property(e => e.AppSettingMasterId)
                    .HasColumnName("App_Setting_Master_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppActiveRule)
                    .HasColumnName("App_Active_Rule")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AppCode)
                    .IsRequired()
                    .HasColumnName("App_Code")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AppControl)
                    .HasColumnName("App_Control")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AppControlType)
                    .HasColumnName("App_Control_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AppDisplayOrder).HasColumnName("App_Display_Order");

                entity.Property(e => e.AppDisplayYn)
                    .IsRequired()
                    .HasColumnName("App_Display_YN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.AppGroup)
                    .IsRequired()
                    .HasColumnName("App_Group")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AppGroupAr)
                    .HasColumnName("App_Group_Ar")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AppGroupType)
                    .HasColumnName("App_Group_Type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AppLongDescription)
                    .IsRequired()
                    .HasColumnName("App_Long_Description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AppLongDescriptionAr)
                    .HasColumnName("App_Long_Description_Ar")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AppMenuId).HasColumnName("App_Menu_ID");

                entity.Property(e => e.AppParaValue)
                    .HasColumnName("App_Para_Value")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AppShortDescription)
                    .IsRequired()
                    .HasColumnName("App_Short_Description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AppShortDescriptionAr)
                    .HasColumnName("App_Short_Description_Ar")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FieldLength).HasColumnName("Field_Length");

                entity.Property(e => e.FromTableName)
                    .HasColumnName("From_Table_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyRelatedYn)
                    .HasColumnName("Property_Related_YN")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AppSettingsTbl>(entity =>
            {
                entity.HasKey(e => new { e.AppSettingId, e.PropertyId });

                entity.ToTable("App_Settings_Tbl");

                entity.Property(e => e.AppSettingId).HasColumnName("App_Setting_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.AppActiveRule)
                    .HasColumnName("App_Active_Rule")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AppCode)
                    .IsRequired()
                    .HasColumnName("App_Code")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AppControl)
                    .HasColumnName("App_Control")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AppControlType)
                    .HasColumnName("App_Control_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AppDisplayOrder).HasColumnName("App_Display_Order");

                entity.Property(e => e.AppDisplayYn)
                    .HasColumnName("App_Display_YN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.AppGroup)
                    .IsRequired()
                    .HasColumnName("App_Group")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AppGroupAr)
                    .HasColumnName("App_Group_Ar")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AppGroupType)
                    .HasColumnName("App_Group_Type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AppLongDescription)
                    .IsRequired()
                    .HasColumnName("App_Long_Description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AppLongDescriptionAr)
                    .HasColumnName("App_Long_Description_Ar")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AppMenuId).HasColumnName("App_Menu_ID");

                entity.Property(e => e.AppParaValue)
                    .HasColumnName("App_Para_Value")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AppShortDescription)
                    .IsRequired()
                    .HasColumnName("App_Short_Description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AppShortDescriptionAr)
                    .HasColumnName("App_Short_Description_Ar")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FieldLength).HasColumnName("Field_Length");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.FromTableName)
                    .HasColumnName("From_Table_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyRelatedYn)
                    .HasColumnName("Property_Related_YN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.AppSetting)
                    .WithMany(p => p.AppSettingsTbl)
                    .HasForeignKey(d => d.AppSettingId)
                    .HasConstraintName("FK_App_Settings_Tbl_App_Settings_Master_Tbl");
            });

            //modelBuilder.Entity<AspUsers>(entity =>
            //{
            //    entity.ToTable("aspUsers");

            //    entity.Property(e => e.Id).ValueGeneratedNever();

            //    entity.Property(e => e.Email).HasMaxLength(256);

            //    entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

            //    entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

            //    entity.Property(e => e.UserName).HasMaxLength(256);
            //});

            modelBuilder.Entity<AttendanceAbsencePenaltyTbl>(entity =>
            {
                entity.HasKey(e => e.AttendanceAbsencePenaltyId);

                entity.ToTable("Attendance_Absence_Penalty_Tbl");

                entity.Property(e => e.AttendanceAbsencePenaltyId).HasColumnName("Attendance_Absence_Penalty_ID");

                entity.Property(e => e.AttendanceRuleId).HasColumnName("Attendance_Rule_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.FromDay).HasColumnName("From_Day");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PenaltyDays).HasColumnName("Penalty_Days");

                entity.Property(e => e.ToDay).HasColumnName("To_Day");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.AttendanceRule)
                    .WithMany(p => p.AttendanceAbsencePenaltyTbl)
                    .HasForeignKey(d => d.AttendanceRuleId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Attendance_Absence_Penalty_Tbl_Attendance_Rule_Tbl");
            });

            modelBuilder.Entity<AttendanceActionTypeTbl>(entity =>
            {
                entity.HasKey(e => e.AttendanceActionTypeId);

                entity.ToTable("Attendance_Action_Type_Tbl");

                entity.Property(e => e.AttendanceActionTypeId)
                    .HasColumnName("Attendance_Action_Type_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AttendanceActionTypeArName)
                    .HasColumnName("Attendance_Action_Type_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.AttendanceActionTypeEnName)
                    .HasColumnName("Attendance_Action_Type_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<AttendanceCalculatedDataDetailsTbl>(entity =>
            {
                entity.HasKey(e => e.AttendanceCalculatedDataDetailsId)
                    .HasName("PK_Attendance_Calculated_Data_Details_لإلام");

                entity.ToTable("Attendance_Calculated_Data_Details_Tbl");

                entity.Property(e => e.AttendanceCalculatedDataDetailsId).HasColumnName("Attendance_Calculated_Data_Details_ID");

                entity.Property(e => e.AttendanceCalculatedDataId).HasColumnName("Attendance_Calculated_Data_ID");

                entity.Property(e => e.BusDelayYn).HasColumnName("Bus_Delay_YN");

                entity.Property(e => e.EarlyArrivalH).HasColumnName("Early_Arrival_H");

                entity.Property(e => e.EarlyArrivalM).HasColumnName("Early_Arrival_M");

                entity.Property(e => e.EarlyArrivalYn).HasColumnName("Early_Arrival_YN");

                entity.Property(e => e.EarlyDepartureH).HasColumnName("Early_Departure_H");

                entity.Property(e => e.EarlyDepartureM).HasColumnName("Early_Departure_M");

                entity.Property(e => e.EarlyDepartureYn).HasColumnName("Early_Departure_YN");

                entity.Property(e => e.EarlyMissionYn).HasColumnName("Early_Mission_YN");

                entity.Property(e => e.ExceptionHours).HasColumnName("Exception_Hours");

                entity.Property(e => e.ExceptionMinutes).HasColumnName("Exception_Minutes");

                entity.Property(e => e.InWithoutOutYn).HasColumnName("In_Without_Out_YN");

                entity.Property(e => e.LateMissionYn).HasColumnName("Late_Mission_YN");

                entity.Property(e => e.LatePermissionYn).HasColumnName("Late_Permission_YN");

                entity.Property(e => e.LateTimeH).HasColumnName("Late_Time_H");

                entity.Property(e => e.LateTimeM).HasColumnName("Late_Time_M");

                entity.Property(e => e.LateTimeYn).HasColumnName("Late_Time_YN");

                entity.Property(e => e.LeavePermissionYn).HasColumnName("Leave_Permission_YN");

                entity.Property(e => e.OutWithoutInYn).HasColumnName("Out_Without_In_YN");

                entity.Property(e => e.OverTimeH).HasColumnName("Over_Time_H");

                entity.Property(e => e.OverTimeM).HasColumnName("Over_Time_M");

                entity.Property(e => e.OverTimeYn).HasColumnName("Over_Time_YN");

                entity.Property(e => e.ShiftOrder).HasColumnName("Shift_Order");

                entity.Property(e => e.ShiftStatus)
                    .HasColumnName("Shift_Status")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TimeIn).HasColumnName("Time_In");

                entity.Property(e => e.TimeOut).HasColumnName("Time_Out");

                entity.Property(e => e.TotalHours).HasColumnName("Total_Hours");

                entity.Property(e => e.TotalMinutes).HasColumnName("Total_Minutes");

                entity.HasOne(d => d.AttendanceCalculatedData)
                    .WithMany(p => p.AttendanceCalculatedDataDetailsTbl)
                    .HasForeignKey(d => d.AttendanceCalculatedDataId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Attendance_Calculated_Data_Details_Tbl_Attendance_Calculated_Data_Tbl");
            });

            modelBuilder.Entity<AttendanceCalculatedDataTbl>(entity =>
            {
                entity.HasKey(e => e.AttendanceCalculatedDataId);

                entity.ToTable("Attendance_Calculated_Data_Tbl");

                entity.Property(e => e.AttendanceCalculatedDataId).HasColumnName("Attendance_Calculated_Data_ID");

                entity.Property(e => e.Abbreviation)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DayStatus)
                    .HasColumnName("Day_Status")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FromMachineYn).HasColumnName("From_Machine_YN");

                entity.Property(e => e.HrDayStatus)
                    .HasColumnName("HR_Day_Status")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.RequiredHours).HasColumnName("Required_Hours");

                entity.Property(e => e.RequiredMinutes).HasColumnName("Required_Minutes");

                entity.Property(e => e.TheDate)
                    .HasColumnName("The_Date")
                    .HasColumnType("date");

                entity.Property(e => e.TotalHours).HasColumnName("Total_Hours");

                entity.Property(e => e.TotalMinutes).HasColumnName("Total_Minutes");
            });

            modelBuilder.Entity<AttendanceDetailsTbl>(entity =>
            {
                entity.HasKey(e => e.AttendanceDetailsId);

                entity.ToTable("Attendance_Details_Tbl");

                entity.Property(e => e.AttendanceDetailsId).HasColumnName("Attendance_Details_ID");

                entity.Property(e => e.Abbreviation).HasMaxLength(5);

                entity.Property(e => e.AlternativeHolidayYn).HasColumnName("Alternative_Holiday_YN");

                entity.Property(e => e.AnnualConsumption).HasColumnName("Annual_Consumption");

                entity.Property(e => e.AttendanceDate)
                    .HasColumnName("Attendance_Date")
                    .HasColumnType("date");

                entity.Property(e => e.AttendanceTypeId)
                    .HasColumnName("Attendance_Type_ID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DayOffConsumption).HasColumnName("Day_Off_Consumption");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.HolidayConsumption).HasColumnName("Holiday_Consumption");

                entity.Property(e => e.HolidayId).HasColumnName("Holiday_ID");

                entity.Property(e => e.MasterId).HasColumnName("Master_ID");

                entity.Property(e => e.RemoteConsumption).HasColumnName("Remote_Consumption");

                entity.Property(e => e.SecondDayOffOtherConsumption).HasColumnName("Second_Day_Off_Other_Consumption");

                entity.Property(e => e.VacationTypeId).HasColumnName("Vacation_Type_ID");
            });

            modelBuilder.Entity<AttendanceExceptionsTbl>(entity =>
            {
                entity.HasKey(e => e.AttendanceExceptionsId);

                entity.ToTable("Attendance_Exceptions_Tbl");

                entity.Property(e => e.AttendanceExceptionsId).HasColumnName("Attendance_Exceptions_ID");

                entity.Property(e => e.ActionTypeId).HasColumnName("Action_Type_ID");

                entity.Property(e => e.ApprovedYn).HasColumnName("Approved_YN");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.ShiftOrder).HasColumnName("Shift_Order");

                entity.Property(e => e.SupervisorEmployeeId).HasColumnName("Supervisor_Employee_ID");

                entity.Property(e => e.TheDate)
                    .HasColumnName("The_Date")
                    .HasColumnType("date");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.AttendanceExceptionsTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Attendance_Exceptions_Tbl_Employee_Tbl");
            });

            modelBuilder.Entity<AttendanceLatePenaltyTbl>(entity =>
            {
                entity.HasKey(e => e.AttendanceLatePenaltyId);

                entity.ToTable("Attendance_Late_Penalty_Tbl");

                entity.Property(e => e.AttendanceLatePenaltyId).HasColumnName("Attendance_Late_Penalty_ID");

                entity.Property(e => e.AttendanceRuleId).HasColumnName("Attendance_Rule_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.FromMinute).HasColumnName("From_Minute");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PenaltyDays).HasColumnName("Penalty_Days");

                entity.Property(e => e.ToMinute).HasColumnName("To_Minute");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.AttendanceRule)
                    .WithMany(p => p.AttendanceLatePenaltyTbl)
                    .HasForeignKey(d => d.AttendanceRuleId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Attendance_Late_Penalty_Tbl_Attendance_Rule_Tbl");
            });

            modelBuilder.Entity<AttendanceLateTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.AttendanceLateTransactionId);

                entity.ToTable("Attendance_Late_Transaction_Tbl");

                entity.Property(e => e.AttendanceLateTransactionId).HasColumnName("Attendance_Late_Transaction_ID");

                entity.Property(e => e.AttendanceRuleId).HasColumnName("Attendance_Rule_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.FromMinute).HasColumnName("From_Minute");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.LateTypeId).HasColumnName("Late_Type_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.ToMinute).HasColumnName("To_Minute");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.AttendanceRule)
                    .WithMany(p => p.AttendanceLateTransactionTbl)
                    .HasForeignKey(d => d.AttendanceRuleId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Attendance_Late_Transaction_Tbl_Attendance_Rule_Tbl");

                entity.HasOne(d => d.LateType)
                    .WithMany(p => p.AttendanceLateTransactionTbl)
                    .HasForeignKey(d => d.LateTypeId)
                    .HasConstraintName("FK_Attendance_Late_Transaction_Tbl_Late_Type_Tbl");
            });

            modelBuilder.Entity<AttendanceMachineDetailsTbl>(entity =>
            {
                entity.HasKey(e => e.AttendanceMachineDetailsId)
                    .HasName("PK_Attendance_Machine_Detail_Tbl");

                entity.ToTable("Attendance_Machine_Details_Tbl");

                entity.Property(e => e.AttendanceMachineDetailsId).HasColumnName("Attendance_Machine_Details_ID");

                entity.Property(e => e.AttendanceMachineId).HasColumnName("Attendance_Machine_ID");

                entity.Property(e => e.CommunicationType)
                    .HasColumnName("Communication_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.ConnectionPassword)
                    .HasColumnName("Connection_Password")
                    .HasMaxLength(100);

                entity.Property(e => e.DateLength).HasColumnName("Date_Length");

                entity.Property(e => e.DateOrder)
                    .HasColumnName("Date_Order")
                    .HasMaxLength(200);

                entity.Property(e => e.EmployeeCodeLength).HasColumnName("Employee_Code_Length");

                entity.Property(e => e.EmployeeCodeOrder)
                    .HasColumnName("Employee_Code_Order")
                    .HasMaxLength(200);

                entity.Property(e => e.FileDateFormat)
                    .HasColumnName("File_Date_Format")
                    .HasMaxLength(10);

                entity.Property(e => e.FileDelimiter)
                    .HasColumnName("File_Delimiter")
                    .HasMaxLength(5);

                entity.Property(e => e.FileDelimiterYn).HasColumnName("File_Delimiter_YN");

                entity.Property(e => e.FileHeaderFirstRowYn).HasColumnName("File_Header_First_Row_YN");

                entity.Property(e => e.FlagLength).HasColumnName("Flag_Length");

                entity.Property(e => e.FlagOrder)
                    .HasColumnName("Flag_Order")
                    .HasMaxLength(200);

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.MarkAsReadOrder)
                    .HasColumnName("Mark_As_Read_Order")
                    .HasMaxLength(200);

                entity.Property(e => e.MarkAsReadYn).HasColumnName("Mark_As_Read_YN");

                entity.Property(e => e.SeparateDateTimeYn).HasColumnName("Separate_Date_Time_YN");

                entity.Property(e => e.SysAttendanceMachineSdkId).HasColumnName("Sys_Attendance_Machine_Sdk_ID");

                entity.Property(e => e.TableName)
                    .HasColumnName("Table_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.TcpIp)
                    .HasColumnName("Tcp_IP")
                    .HasMaxLength(50);

                entity.Property(e => e.TcpIpPort)
                    .HasColumnName("Tcp_IP_Port")
                    .HasMaxLength(100);

                entity.Property(e => e.TimeLength).HasColumnName("Time_Length");

                entity.Property(e => e.TimeOrder)
                    .HasColumnName("Time_Order")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.AttendanceMachine)
                    .WithMany(p => p.AttendanceMachineDetailsTbl)
                    .HasForeignKey(d => d.AttendanceMachineId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Attendance_Machine_Details_Tbl_Attendance_Machine_Tbl");
            });

            modelBuilder.Entity<AttendanceMachineLogTbl>(entity =>
            {
                entity.HasKey(e => e.AttendanceMachineLogId)
                    .HasName("PK_Attendance_Machine_Log");

                entity.ToTable("Attendance_Machine_Log_Tbl");

                entity.Property(e => e.AttendanceMachineLogId).HasColumnName("Attendance_Machine_Log_ID");

                entity.Property(e => e.AttendanceMachineId).HasColumnName("Attendance_Machine_ID");

                entity.Property(e => e.AttendanceTransactionFlagId).HasColumnName("Attendance_Transaction_Flag_ID");

                entity.Property(e => e.EmployeeClockNumber)
                    .HasColumnName("Employee_Clock_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.SourceType)
                    .HasColumnName("Source_Type")
                    .HasMaxLength(20);

                entity.Property(e => e.TransactionDate)
                    .HasColumnName("Transaction_Date")
                    .HasColumnType("date");

                entity.Property(e => e.TransactionFlag)
                    .HasColumnName("Transaction_Flag")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionHour).HasColumnName("Transaction_Hour");

                entity.Property(e => e.TransactionMinute).HasColumnName("Transaction_Minute");

                entity.Property(e => e.TransactionTime).HasColumnName("Transaction_Time");

                entity.HasOne(d => d.AttendanceTransactionFlag)
                    .WithMany(p => p.AttendanceMachineLogTbl)
                    .HasForeignKey(d => d.AttendanceTransactionFlagId)
                    .HasConstraintName("FK_Attendance_Machine_Log_Tbl_Attendance_Transaction_Flag_Tbl");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.AttendanceMachineLogTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Attendance_Machine_Log_Tbl_Employee_Tbl");
            });

            modelBuilder.Entity<AttendanceMachineTbl>(entity =>
            {
                entity.HasKey(e => e.AttendanceMachineId);

                entity.ToTable("Attendance_Machine_Tbl");

                entity.Property(e => e.AttendanceMachineId).HasColumnName("Attendance_Machine_ID");

                entity.Property(e => e.AttendanceMachineArName)
                    .HasColumnName("Attendance_Machine_Ar_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.AttendanceMachineArNameShadow)
                    .HasColumnName("Attendance_Machine_Ar_Name_Shadow")
                    .HasMaxLength(200);

                entity.Property(e => e.AttendanceMachineCode)
                    .HasColumnName("Attendance_Machine_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.AttendanceMachineEnName)
                    .HasColumnName("Attendance_Machine_En_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.AttendanceMachineTerminalId).HasColumnName("Attendance_Machine_Terminal_ID");

                entity.Property(e => e.BreakInFlag)
                    .HasColumnName("Break_In_Flag")
                    .HasMaxLength(10);

                entity.Property(e => e.BreakOutFlag)
                    .HasColumnName("Break_Out_Flag")
                    .HasMaxLength(10);

                entity.Property(e => e.CheckInFlag)
                    .HasColumnName("Check_In_Flag")
                    .HasMaxLength(10);

                entity.Property(e => e.CheckOutFlag)
                    .HasColumnName("Check_Out_Flag")
                    .HasMaxLength(10);

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.MissionInFlag)
                    .HasColumnName("Mission_In_Flag")
                    .HasMaxLength(10);

                entity.Property(e => e.MissionOutFlag)
                    .HasColumnName("Mission_Out_Flag")
                    .HasMaxLength(10);

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.Property(e => e.UseBreakYn).HasColumnName("Use_Break_YN");

                entity.Property(e => e.UseMissionYn).HasColumnName("Use_Mission_YN");
            });

            modelBuilder.Entity<AttendanceOverTimeTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.AttendanceOverTimeTransactionId);

                entity.ToTable("Attendance_Over_Time_Transaction_Tbl");

                entity.Property(e => e.AttendanceOverTimeTransactionId).HasColumnName("Attendance_Over_Time_Transaction_ID");

                entity.Property(e => e.AttendanceRuleId).HasColumnName("Attendance_Rule_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.FromMinute).HasColumnName("From_Minute");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.OverTimeTypeId).HasColumnName("Over_Time_Type_ID");

                entity.Property(e => e.ToMinute).HasColumnName("To_Minute");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.AttendanceRule)
                    .WithMany(p => p.AttendanceOverTimeTransactionTbl)
                    .HasForeignKey(d => d.AttendanceRuleId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Attendance_Over_Time_Transaction_Tbl_Attendance_Rule_Tbl");

                entity.HasOne(d => d.OverTimeType)
                    .WithMany(p => p.AttendanceOverTimeTransactionTbl)
                    .HasForeignKey(d => d.OverTimeTypeId)
                    .HasConstraintName("FK_Attendance_Over_Time_Transaction_Tbl_Over_Time_Type_Tbl");
            });

            modelBuilder.Entity<AttendanceRuleTbl>(entity =>
            {
                entity.HasKey(e => e.AttendanceRuleId)
                    .HasName("PK_Schedule_Rule_Tbl");

                entity.ToTable("Attendance_Rule_Tbl");

                entity.Property(e => e.AttendanceRuleId).HasColumnName("Attendance_Rule_ID");

                entity.Property(e => e.AbsencePenaltyDays).HasColumnName("Absence_Penalty_Days");

                entity.Property(e => e.AttendanceRuleArName)
                    .HasColumnName("Attendance_Rule_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.AttendanceRuleArNameShadow)
                    .HasColumnName("Attendance_Rule_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.AttendanceRuleCode)
                    .HasColumnName("Attendance_Rule_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.AttendanceRuleEnName)
                    .HasColumnName("Attendance_Rule_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.AttendanceType).HasColumnName("Attendance_Type");

                entity.Property(e => e.CalculationWay).HasColumnName("Calculation_Way");

                entity.Property(e => e.DailyHours).HasColumnName("Daily_Hours");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InWithoutOutAbsencePenalty).HasColumnName("In_Without_Out_Absence_Penalty");

                entity.Property(e => e.InWithoutOutPenaltyDays).HasColumnName("In_Without_Out_Penalty_Days");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.LatePenaltySlicesDailyMonthly).HasColumnName("Late_Penalty_Slices_Daily_Monthly");

                entity.Property(e => e.LateTransactionSlicesDailyMonthly).HasColumnName("Late_Transaction_Slices_Daily_Monthly");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.MinShiftsForPresent).HasColumnName("Min_Shifts_For_Present");

                entity.Property(e => e.OutWithoutInAbsencePenalty).HasColumnName("Out_Without_In_Absence_Penalty");

                entity.Property(e => e.OutWithoutInPenaltyDays).HasColumnName("Out_Without_In_Penalty_Days");

                entity.Property(e => e.OverTimeSlicesDailyMonthly).HasColumnName("Over_Time_Slices_Daily_Monthly");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.ScheduleId).HasColumnName("Schedule_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.Property(e => e.UseAbsencePenaltyYn).HasColumnName("Use_Absence_Penalty_YN");

                entity.Property(e => e.UseAbsenceTransactionYn).HasColumnName("Use_Absence_Transaction_YN");

                entity.Property(e => e.UseLatePenaltyYn).HasColumnName("Use_Late_Penalty_YN");

                entity.Property(e => e.UseLateTransactionYn).HasColumnName("Use_Late_Transaction_YN");

                entity.Property(e => e.UseOverTimeTransactionYn).HasColumnName("Use_Over_Time_Transaction_YN");

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.AttendanceRuleTbl)
                    .HasForeignKey(d => d.ScheduleId)
                    .HasConstraintName("FK_Attendance_Rule_Tbl_Schedule_Tbl");
            });

            modelBuilder.Entity<AttendanceSheetDataTbl>(entity =>
            {
                entity.HasKey(e => e.AttendanceSheetDataId);

                entity.ToTable("Attendance_Sheet_Data_Tbl");

                entity.Property(e => e.AttendanceSheetDataId).HasColumnName("Attendance_Sheet_Data_ID");

                entity.Property(e => e.Day1)
                    .HasColumnName("Day_1")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day10)
                    .HasColumnName("Day_10")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day11)
                    .HasColumnName("Day_11")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day12)
                    .HasColumnName("Day_12")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day13)
                    .HasColumnName("Day_13")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day14)
                    .HasColumnName("Day_14")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day15)
                    .HasColumnName("Day_15")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day16)
                    .HasColumnName("Day_16")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day17)
                    .HasColumnName("Day_17")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day18)
                    .HasColumnName("Day_18")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day19)
                    .HasColumnName("Day_19")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day2)
                    .HasColumnName("Day_2")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day20)
                    .HasColumnName("Day_20")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day21)
                    .HasColumnName("Day_21")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day22)
                    .HasColumnName("Day_22")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day23)
                    .HasColumnName("Day_23")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day24)
                    .HasColumnName("Day_24")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day25)
                    .HasColumnName("Day_25")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day26)
                    .HasColumnName("Day_26")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day27)
                    .HasColumnName("Day_27")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day28)
                    .HasColumnName("Day_28")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day29)
                    .HasColumnName("Day_29")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day3)
                    .HasColumnName("Day_3")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day30)
                    .HasColumnName("Day_30")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day31)
                    .HasColumnName("Day_31")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day4)
                    .HasColumnName("Day_4")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day5)
                    .HasColumnName("Day_5")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day6)
                    .HasColumnName("Day_6")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day7)
                    .HasColumnName("Day_7")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day8)
                    .HasColumnName("Day_8")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day9)
                    .HasColumnName("Day_9")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.ReportType).HasColumnName("Report_Type");

                entity.Property(e => e.TheMonth).HasColumnName("The_Month");

                entity.Property(e => e.TheYear).HasColumnName("The_Year");

                entity.Property(e => e.UserId).HasColumnName("User_ID");
            });

            modelBuilder.Entity<AttendanceSheetHeaderTbl>(entity =>
            {
                entity.HasKey(e => e.AttendanceSheetHeaderId);

                entity.ToTable("Attendance_Sheet_Header_Tbl");

                entity.Property(e => e.AttendanceSheetHeaderId).HasColumnName("Attendance_Sheet_Header_ID");

                entity.Property(e => e.Day1)
                    .HasColumnName("Day_1")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day10)
                    .HasColumnName("Day_10")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day10Name)
                    .HasColumnName("Day_10_Name")
                    .HasMaxLength(10);

                entity.Property(e => e.Day11)
                    .HasColumnName("Day_11")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day11Name)
                    .HasColumnName("Day_11_Name")
                    .HasMaxLength(10);

                entity.Property(e => e.Day12)
                    .HasColumnName("Day_12")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day12Name)
                    .HasColumnName("Day_12_Name")
                    .HasMaxLength(10);

                entity.Property(e => e.Day13)
                    .HasColumnName("Day_13")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day13Name)
                    .HasColumnName("Day_13_Name")
                    .HasMaxLength(10);

                entity.Property(e => e.Day14)
                    .HasColumnName("Day_14")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day14Name)
                    .HasColumnName("Day_14_Name")
                    .HasMaxLength(10);

                entity.Property(e => e.Day15)
                    .HasColumnName("Day_15")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day15Name)
                    .HasColumnName("Day_15_Name")
                    .HasMaxLength(10);

                entity.Property(e => e.Day16)
                    .HasColumnName("Day_16")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day16Name)
                    .HasColumnName("Day_16_Name")
                    .HasMaxLength(10);

                entity.Property(e => e.Day17)
                    .HasColumnName("Day_17")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day17Name)
                    .HasColumnName("Day_17_Name")
                    .HasMaxLength(10);

                entity.Property(e => e.Day18)
                    .HasColumnName("Day_18")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day18Name)
                    .HasColumnName("Day_18_Name")
                    .HasMaxLength(10);

                entity.Property(e => e.Day19)
                    .HasColumnName("Day_19")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day19Name)
                    .HasColumnName("Day_19_Name")
                    .HasMaxLength(10);

                entity.Property(e => e.Day1Name)
                    .HasColumnName("Day_1_Name")
                    .HasMaxLength(10);

                entity.Property(e => e.Day2)
                    .HasColumnName("Day_2")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day20)
                    .HasColumnName("Day_20")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day20Name)
                    .HasColumnName("Day_20_Name")
                    .HasMaxLength(10);

                entity.Property(e => e.Day21)
                    .HasColumnName("Day_21")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day21Name)
                    .HasColumnName("Day_21_Name")
                    .HasMaxLength(10);

                entity.Property(e => e.Day22)
                    .HasColumnName("Day_22")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day22Name)
                    .HasColumnName("Day_22_Name")
                    .HasMaxLength(10);

                entity.Property(e => e.Day23)
                    .HasColumnName("Day_23")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day23Name)
                    .HasColumnName("Day_23_Name")
                    .HasMaxLength(10);

                entity.Property(e => e.Day24)
                    .HasColumnName("Day_24")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day24Name)
                    .HasColumnName("Day_24_Name")
                    .HasMaxLength(10);

                entity.Property(e => e.Day25)
                    .HasColumnName("Day_25")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day25Name)
                    .HasColumnName("Day_25_Name")
                    .HasMaxLength(10);

                entity.Property(e => e.Day26)
                    .HasColumnName("Day_26")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day26Name)
                    .HasColumnName("Day_26_Name")
                    .HasMaxLength(10);

                entity.Property(e => e.Day27)
                    .HasColumnName("Day_27")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day27Name)
                    .HasColumnName("Day_27_Name")
                    .HasMaxLength(10);

                entity.Property(e => e.Day28)
                    .HasColumnName("Day_28")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day28Name)
                    .HasColumnName("Day_28_Name")
                    .HasMaxLength(10);

                entity.Property(e => e.Day29)
                    .HasColumnName("Day_29")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day29Name)
                    .HasColumnName("Day_29_Name")
                    .HasMaxLength(10);

                entity.Property(e => e.Day2Name)
                    .HasColumnName("Day_2_Name")
                    .HasMaxLength(10);

                entity.Property(e => e.Day3)
                    .HasColumnName("Day_3")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day30)
                    .HasColumnName("Day_30")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day30Name)
                    .HasColumnName("Day_30_Name")
                    .HasMaxLength(10);

                entity.Property(e => e.Day31)
                    .HasColumnName("Day_31")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day31Name)
                    .HasColumnName("Day_31_Name")
                    .HasMaxLength(10);

                entity.Property(e => e.Day3Name)
                    .HasColumnName("Day_3_Name")
                    .HasMaxLength(10);

                entity.Property(e => e.Day4)
                    .HasColumnName("Day_4")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day4Name)
                    .HasColumnName("Day_4_Name")
                    .HasMaxLength(10);

                entity.Property(e => e.Day5)
                    .HasColumnName("Day_5")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day5Name)
                    .HasColumnName("Day_5_Name")
                    .HasMaxLength(10);

                entity.Property(e => e.Day6)
                    .HasColumnName("Day_6")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day6Name)
                    .HasColumnName("Day_6_Name")
                    .HasMaxLength(10);

                entity.Property(e => e.Day7)
                    .HasColumnName("Day_7")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day7Name)
                    .HasColumnName("Day_7_Name")
                    .HasMaxLength(10);

                entity.Property(e => e.Day8)
                    .HasColumnName("Day_8")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day8Name)
                    .HasColumnName("Day_8_Name")
                    .HasMaxLength(10);

                entity.Property(e => e.Day9)
                    .HasColumnName("Day_9")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Day9Name)
                    .HasColumnName("Day_9_Name")
                    .HasMaxLength(10);

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.ReportType).HasColumnName("Report_Type");

                entity.Property(e => e.TheMonth).HasColumnName("The_Month");

                entity.Property(e => e.TheYear).HasColumnName("The_Year");

                entity.Property(e => e.UserId).HasColumnName("User_ID");
            });

            modelBuilder.Entity<AttendanceTransactionFlagTbl>(entity =>
            {
                entity.HasKey(e => e.AttendanceTransactionFlagId);

                entity.ToTable("Attendance_Transaction_Flag_Tbl");

                entity.Property(e => e.AttendanceTransactionFlagId).HasColumnName("Attendance_Transaction_Flag_ID");

                entity.Property(e => e.AttendanceTransactionFlagArName)
                    .HasColumnName("Attendance_Transaction_Flag_Ar_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.AttendanceTransactionFlagEnName)
                    .HasColumnName("Attendance_Transaction_Flag_En_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AutoNotificationTbl>(entity =>
            {
                entity.HasKey(e => e.AutoNotificationId);

                entity.ToTable("Auto_Notification_Tbl");

                entity.Property(e => e.AutoNotificationId).HasColumnName("Auto_Notification_ID");

                entity.Property(e => e.Action).HasMaxLength(10);

                entity.Property(e => e.ActionDate)
                    .HasColumnName("Action_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SysMessageTypeId).HasColumnName("Sys_Message_Type_ID");

                entity.Property(e => e.SysNotificationFieldId).HasColumnName("Sys_Notification_Field_ID");
            });

            modelBuilder.Entity<BankFileConfigurationDetailsTbl>(entity =>
            {
                entity.HasKey(e => e.BankFileConfigurationDetailsId);

                entity.ToTable("Bank_File_Configuration_Details_Tbl");

                entity.Property(e => e.BankFileConfigurationDetailsId).HasColumnName("Bank_File_Configuration_Details_ID");

                entity.Property(e => e.BankFileConfigurationId).HasColumnName("Bank_File_Configuration_ID");

                entity.Property(e => e.DetailsBlankCharacter)
                    .HasColumnName("Details_Blank_Character")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsBlankFillPlace)
                    .HasColumnName("Details_Blank_Fill_Place")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsColumnHeader)
                    .HasColumnName("Details_Column_Header")
                    .HasMaxLength(200);

                entity.Property(e => e.DetailsId).HasColumnName("Details_ID");

                entity.Property(e => e.DetailsNoDecimals).HasColumnName("Details_No_Decimals");

                entity.Property(e => e.DetailsOrder).HasColumnName("Details_Order");

                entity.Property(e => e.DetailsSeprator)
                    .HasColumnName("Details_Seprator")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsSpaceNumber).HasColumnName("Details_Space_Number");

                entity.Property(e => e.DetailsType)
                    .HasColumnName("Details_Type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsValue)
                    .HasColumnName("Details_Value")
                    .HasMaxLength(200);

                entity.Property(e => e.DetailsWidth).HasColumnName("Details_Width");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.BankFileConfiguration)
                    .WithMany(p => p.BankFileConfigurationDetailsTbl)
                    .HasForeignKey(d => d.BankFileConfigurationId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Bank_File_Configuration_Details_Tbl_Bank_File_Configuration_Tbl");
            });

            modelBuilder.Entity<BankFileConfigurationSerialTbl>(entity =>
            {
                entity.HasKey(e => e.BankFileSerialId);

                entity.ToTable("Bank_File_Configuration_Serial_Tbl");

                entity.Property(e => e.BankFileSerialId).HasColumnName("Bank_File_Serial_ID");

                entity.Property(e => e.BankFileConfigurationId).HasColumnName("Bank_File_Configuration_ID");

                entity.Property(e => e.CurrencyId).HasColumnName("Currency_ID");

                entity.Property(e => e.PayrollType).HasColumnName("Payroll_Type");

                entity.Property(e => e.SerialEndThisMonth).HasColumnName("Serial_End_This_Month");

                entity.Property(e => e.SerialStartThisMonth).HasColumnName("Serial_Start_This_Month");

                entity.Property(e => e.TheMonth).HasColumnName("The_Month");

                entity.Property(e => e.TheYear).HasColumnName("The_Year");
            });

            modelBuilder.Entity<BankFileConfigurationTbl>(entity =>
            {
                entity.HasKey(e => e.BankFileConfigurationId);

                entity.ToTable("Bank_File_Configuration_Tbl");

                entity.Property(e => e.BankFileConfigurationId).HasColumnName("Bank_File_Configuration_ID");

                entity.Property(e => e.BankId).HasColumnName("Bank_ID");

                entity.Property(e => e.BankWbs).HasColumnName("Bank_WBS");

                entity.Property(e => e.DisplayColumnsHeadersYn).HasColumnName("Display_Columns_Headers_YN");

                entity.Property(e => e.FileTypeExcelText).HasColumnName("File_Type_Excel_Text");

                entity.Property(e => e.FooterReferenceCode)
                    .HasColumnName("Footer_Reference_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.FooterReferenceCodeOrder).HasColumnName("Footer_Reference_Code_Order");

                entity.Property(e => e.FooterReferenceCodeSeprator)
                    .HasColumnName("Footer_Reference_Code_Seprator")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FooterReferenceCodeSpaceNumber).HasColumnName("Footer_Reference_Code_Space_Number");

                entity.Property(e => e.FooterReferenceCodeWidth).HasColumnName("Footer_Reference_Code_Width");

                entity.Property(e => e.FooterTotalAmountBlankCharacter)
                    .HasColumnName("Footer_Total_Amount_Blank_Character")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FooterTotalAmountDecimal).HasColumnName("Footer_Total_Amount_Decimal");

                entity.Property(e => e.FooterTotalAmountFillPlace)
                    .HasColumnName("Footer_Total_Amount_Fill_Place")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FooterTotalAmountOrder).HasColumnName("Footer_Total_Amount_Order");

                entity.Property(e => e.FooterTotalAmountSeprator)
                    .HasColumnName("Footer_Total_Amount_Seprator")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FooterTotalAmountSpaceNumber).HasColumnName("Footer_Total_Amount_Space_Number");

                entity.Property(e => e.FooterTotalAmountWidth).HasColumnName("Footer_Total_Amount_Width");

                entity.Property(e => e.FooterTotalEmpBlankCharacter)
                    .HasColumnName("Footer_Total_Emp_Blank_Character")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FooterTotalEmpFillPlace)
                    .HasColumnName("Footer_Total_Emp_Fill_Place")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FooterTotalEmployeesNumberOrder).HasColumnName("Footer_Total_Employees_Number_Order");

                entity.Property(e => e.FooterTotalEmployeesNumberSeprator)
                    .HasColumnName("Footer_Total_Employees_Number_Seprator")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FooterTotalEmployeesNumberSpaceNumber).HasColumnName("Footer_Total_Employees_Number_Space_Number");

                entity.Property(e => e.FooterTotalEmployeesNumberWidth).HasColumnName("Footer_Total_Employees_Number_Width");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.HeaderActionDateFormatId).HasColumnName("Header_Action_Date_Format_ID");

                entity.Property(e => e.HeaderActionDateOrder).HasColumnName("Header_Action_Date_Order");

                entity.Property(e => e.HeaderActionDateSeprator)
                    .HasColumnName("Header_Action_Date_Seprator")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderActionDateSpaceNumber).HasColumnName("Header_Action_Date_Space_Number");

                entity.Property(e => e.HeaderActionDateWidth).HasColumnName("Header_Action_Date_Width");

                entity.Property(e => e.HeaderDateFormatId).HasColumnName("Header_Date_Format_ID");

                entity.Property(e => e.HeaderDateOrder).HasColumnName("Header_Date_Order");

                entity.Property(e => e.HeaderDateSeprator)
                    .HasColumnName("Header_Date_Seprator")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderDateSpaceNumber).HasColumnName("Header_Date_Space_Number");

                entity.Property(e => e.HeaderDateWidth).HasColumnName("Header_Date_Width");

                entity.Property(e => e.HeaderPropertyAccountNumber)
                    .HasColumnName("Header_Property_Account_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.HeaderPropertyAccountNumberBlankCharacter)
                    .HasColumnName("Header_Property_Account_Number_Blank_Character")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderPropertyAccountNumberFillPlace)
                    .HasColumnName("Header_Property_Account_Number_Fill_Place")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderPropertyAccountNumberOrder).HasColumnName("Header_Property_Account_Number_Order");

                entity.Property(e => e.HeaderPropertyAccountNumberSeprator)
                    .HasColumnName("Header_Property_Account_Number_Seprator")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderPropertyAccountNumberSpaceNumber).HasColumnName("Header_Property_Account_Number_Space_Number");

                entity.Property(e => e.HeaderPropertyAccountNumberWidth).HasColumnName("Header_Property_Account_Number_Width");

                entity.Property(e => e.HeaderPropertyNameOrder).HasColumnName("Header_Property_Name_Order");

                entity.Property(e => e.HeaderPropertyNameSeprator)
                    .HasColumnName("Header_Property_Name_Seprator")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderPropertyNameSpaceNumber).HasColumnName("Header_Property_Name_Space_Number");

                entity.Property(e => e.HeaderPropertyNameWidth).HasColumnName("Header_Property_Name_Width");

                entity.Property(e => e.HeaderReferenceCode)
                    .HasColumnName("Header_Reference_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.HeaderReferenceCodeOrder).HasColumnName("Header_Reference_Code_Order");

                entity.Property(e => e.HeaderReferenceCodeSeprator)
                    .HasColumnName("Header_Reference_Code_Seprator")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderReferenceCodeSpaceNumber).HasColumnName("Header_Reference_Code_Space_Number");

                entity.Property(e => e.HeaderReferenceCodeWidth).HasColumnName("Header_Reference_Code_Width");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.Property(e => e.UseFooterReferenceCodeYn).HasColumnName("Use_Footer_Reference_Code_YN");

                entity.Property(e => e.UseFooterTotalAmountYn).HasColumnName("Use_Footer_Total_Amount_YN");

                entity.Property(e => e.UseFooterTotalEmployeesNumberYn).HasColumnName("Use_Footer_Total_Employees_Number_YN");

                entity.Property(e => e.UseHeaderActionDateYn).HasColumnName("Use_Header_Action_Date_YN");

                entity.Property(e => e.UseHeaderDateYn).HasColumnName("Use_Header_Date_YN");

                entity.Property(e => e.UseHeaderPropertyAccountNumberYn).HasColumnName("Use_Header_Property_Account_Number_YN");

                entity.Property(e => e.UseHeaderPropertyNameYn).HasColumnName("Use_Header_Property_Name_YN");

                entity.Property(e => e.UseHeaderReferenceCodeYn).HasColumnName("Use_Header_Reference_Code_YN");
            });

            modelBuilder.Entity<BankReportDetailsTbl>(entity =>
            {
                entity.HasKey(e => e.BankReportDetailsId);

                entity.ToTable("Bank_Report_Details_Tbl");

                entity.Property(e => e.BankReportDetailsId).HasColumnName("Bank_Report_Details_ID");

                entity.Property(e => e.BankAccountNumber)
                    .HasColumnName("Bank_Account_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.BankBranchNumber)
                    .HasColumnName("Bank_Branch_Number")
                    .HasMaxLength(10);

                entity.Property(e => e.BankEmployeeNumber)
                    .HasColumnName("Bank_Employee_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.BankId).HasColumnName("Bank_ID");

                entity.Property(e => e.CurrencyId).HasColumnName("Currency_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.TheMonth).HasColumnName("The_Month");

                entity.Property(e => e.TheYear).HasColumnName("The_Year");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.Property(e => e.WbsYn).HasColumnName("WBS_YN");
            });

            modelBuilder.Entity<BankTbl>(entity =>
            {
                entity.HasKey(e => e.BankId);

                entity.ToTable("Bank_Tbl");

                entity.Property(e => e.BankId).HasColumnName("Bank_ID");

                entity.Property(e => e.BankAccountNumber)
                    .HasColumnName("Bank_Account_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.BankArName)
                    .HasColumnName("Bank_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.BankArNameShadow)
                    .HasColumnName("Bank_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.BankCode)
                    .HasColumnName("Bank_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.BankEnName)
                    .HasColumnName("Bank_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<BenefitTbl>(entity =>
            {
                entity.HasKey(e => e.BenefitId);

                entity.ToTable("Benefit_Tbl");

                entity.Property(e => e.BenefitId).HasColumnName("Benefit_ID");

                entity.Property(e => e.BenefitArName)
                    .HasColumnName("Benefit_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.BenefitArNameShadow)
                    .HasColumnName("Benefit_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.BenefitCode)
                    .HasColumnName("Benefit_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.BenefitEnName)
                    .HasColumnName("Benefit_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.HasValueYn).HasColumnName("Has_Value_YN");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.RepeatEveryMonths).HasColumnName("Repeat_Every_Months");

                entity.Property(e => e.RepeatableYn).HasColumnName("Repeatable_YN");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<BenefitTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.BenefitTransactionId);

                entity.ToTable("Benefit_Transaction_Tbl");

                entity.Property(e => e.BenefitTransactionId).HasColumnName("Benefit_Transaction_ID");

                entity.Property(e => e.BenefitDate)
                    .HasColumnName("Benefit_Date")
                    .HasColumnType("date");

                entity.Property(e => e.BenefitId).HasColumnName("Benefit_ID");

                entity.Property(e => e.BenefitValue).HasColumnName("Benefit_Value");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.RepeateDate)
                    .HasColumnName("Repeate_Date")
                    .HasColumnType("date");

                entity.Property(e => e.SysRequestStatusId).HasColumnName("Sys_Request_Status_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Benefit)
                    .WithMany(p => p.BenefitTransactionTbl)
                    .HasForeignKey(d => d.BenefitId)
                    .HasConstraintName("FK_Benefit_Transaction_Tbl_Benefit_Tbl");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.BenefitTransactionTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Benefit_Transaction_Tbl_Employee_Tbl");

                entity.HasOne(d => d.SysRequestStatus)
                    .WithMany(p => p.BenefitTransactionTbl)
                    .HasForeignKey(d => d.SysRequestStatusId)
                    .HasConstraintName("FK_Benefit_Transaction_Tbl_Sys_Request_Status_ID");
            });

            modelBuilder.Entity<BloodTypeTbl>(entity =>
            {
                entity.HasKey(e => e.BloodTypeId);

                entity.ToTable("Blood_Type_Tbl");

                entity.Property(e => e.BloodTypeId).HasColumnName("Blood_Type_ID");

                entity.Property(e => e.BloodTypeArName)
                    .HasColumnName("Blood_Type_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.BloodTypeEnName)
                    .HasColumnName("Blood_Type_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<BonusDeductionsTbl>(entity =>
            {
                entity.HasKey(e => e.BonusDeductionsId);

                entity.ToTable("Bonus_Deductions_Tbl");

                entity.Property(e => e.BonusDeductionsId).HasColumnName("Bonus_Deductions_ID");

                entity.Property(e => e.BonusTransactionId).HasColumnName("Bonus_Transaction_ID");

                entity.Property(e => e.DeductionId).HasColumnName("Deduction_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.BonusTransaction)
                    .WithMany(p => p.BonusDeductionsTbl)
                    .HasForeignKey(d => d.BonusTransactionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Bonus_Deductions_Tbl_Bonus_Transaction_Tbl");

                entity.HasOne(d => d.Deduction)
                    .WithMany(p => p.BonusDeductionsTbl)
                    .HasForeignKey(d => d.DeductionId)
                    .HasConstraintName("FK_Bonus_Deductions_Tbl_Deduction_Tbl");
            });

            modelBuilder.Entity<BonusPaymentsTbl>(entity =>
            {
                entity.HasKey(e => e.BonusPaymentsId);

                entity.ToTable("Bonus_Payments_Tbl");

                entity.Property(e => e.BonusPaymentsId).HasColumnName("Bonus_Payments_ID");

                entity.Property(e => e.BonusTransactionId).HasColumnName("Bonus_Transaction_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PaymentId).HasColumnName("Payment_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.BonusTransaction)
                    .WithMany(p => p.BonusPaymentsTbl)
                    .HasForeignKey(d => d.BonusTransactionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Bonus_Payments_Tbl_Bonus_Transaction_Tbl");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.BonusPaymentsTbl)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_Bonus_Payments_Tbl_Payment_Tbl");
            });

            modelBuilder.Entity<BonusRangesTbl>(entity =>
            {
                entity.HasKey(e => e.BonusRangesId);

                entity.ToTable("Bonus_Ranges_Tbl");

                entity.Property(e => e.BonusRangesId).HasColumnName("Bonus_Ranges_ID");

                entity.Property(e => e.BonusTransactionId).HasColumnName("Bonus_Transaction_ID");

                entity.Property(e => e.BonusValue).HasColumnName("Bonus_Value");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.FromValue).HasColumnName("From_Value");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.ToValue).HasColumnName("To_Value");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.BonusTransaction)
                    .WithMany(p => p.BonusRangesTbl)
                    .HasForeignKey(d => d.BonusTransactionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Bonus_Ranges_Tbl_Bonus_Transaction_Tbl");
            });

            modelBuilder.Entity<BonusTransactionDetailsTbl>(entity =>
            {
                entity.HasKey(e => e.BonusTransactionDetailsId);

                entity.ToTable("Bonus_Transaction_Details_Tbl");

                entity.Property(e => e.BonusTransactionDetailsId).HasColumnName("Bonus_Transaction_Details_ID");

                entity.Property(e => e.ActiveYn).HasColumnName("Active_YN");

                entity.Property(e => e.BonusNet).HasColumnName("Bonus_Net");

                entity.Property(e => e.BonusTax).HasColumnName("Bonus_Tax");

                entity.Property(e => e.BonusTransactionId).HasColumnName("Bonus_Transaction_ID");

                entity.Property(e => e.BonusValueAfterCalc).HasColumnName("Bonus_Value_After_Calc");

                entity.Property(e => e.BonusValueBeforeCalc).HasColumnName("Bonus_Value_Before_Calc");

                entity.Property(e => e.CurrencyId).HasColumnName("Currency_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.BonusTransaction)
                    .WithMany(p => p.BonusTransactionDetailsTbl)
                    .HasForeignKey(d => d.BonusTransactionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Bonus_Transaction_Details_Tbl_Bonus_Transaction_Tbl");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.BonusTransactionDetailsTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Bonus_Transaction_Details_Tbl_Employee_Tbl");
            });

            modelBuilder.Entity<BonusTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.BonusTransactionId);

                entity.ToTable("Bonus_Transaction_Tbl");

                entity.Property(e => e.BonusTransactionId).HasColumnName("Bonus_Transaction_ID");

                entity.Property(e => e.BonusDate)
                    .HasColumnName("Bonus_Date")
                    .HasColumnType("date");

                entity.Property(e => e.BonusEvaluationType).HasColumnName("Bonus_Evaluation_Type");

                entity.Property(e => e.BonusRatio).HasColumnName("Bonus_Ratio");

                entity.Property(e => e.BonusTypeId).HasColumnName("Bonus_Type_ID");

                entity.Property(e => e.BonusWayId).HasColumnName("Bonus_Way_ID");

                entity.Property(e => e.DescriptionAr)
                    .HasColumnName("Description_Ar")
                    .HasMaxLength(200);

                entity.Property(e => e.DescriptionEn)
                    .HasColumnName("Description_En")
                    .HasMaxLength(200);

                entity.Property(e => e.EvaluationYn).HasColumnName("Evaluation_YN");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.GroupPaymentNet).HasColumnName("Group_Payment_Net");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.MaximumAmount).HasColumnName("Maximum_Amount");

                entity.Property(e => e.MinimumAmount).HasColumnName("Minimum_Amount");

                entity.Property(e => e.PaidYn)
                    .HasColumnName("Paid_YN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PayWay).HasColumnName("Pay_Way");

                entity.Property(e => e.PaymentDeductionNet).HasColumnName("Payment_Deduction_Net");

                entity.Property(e => e.PaymentGroupId).HasColumnName("Payment_Group_ID");

                entity.Property(e => e.PaymentId).HasColumnName("Payment_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.RangeForMonth).HasColumnName("Range_For_Month");

                entity.Property(e => e.RangeForYear).HasColumnName("Range_For_Year");

                entity.Property(e => e.RateFormula)
                    .HasColumnName("Rate_Formula")
                    .HasMaxLength(500);

                entity.Property(e => e.RateRatio).HasColumnName("Rate_Ratio");

                entity.Property(e => e.TaxableYn).HasColumnName("Taxable_YN");

                entity.Property(e => e.TheMonth).HasColumnName("The_Month");

                entity.Property(e => e.TheYear).HasColumnName("The_Year");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.PaymentGroup)
                    .WithMany(p => p.BonusTransactionTbl)
                    .HasForeignKey(d => d.PaymentGroupId)
                    .HasConstraintName("FK_Bonus_Transaction_Tbl_Payment_Group_Tbl");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.BonusTransactionTbl)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_Bonus_Transaction_Tbl_Payment_Tbl");
            });

            modelBuilder.Entity<BonusTypeTbl>(entity =>
            {
                entity.HasKey(e => e.BonusTypeId);

                entity.ToTable("Bonus_Type_Tbl");

                entity.Property(e => e.BonusTypeId).HasColumnName("Bonus_Type_ID");

                entity.Property(e => e.BonusTypeArName)
                    .HasColumnName("Bonus_Type_Ar_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.BonusTypeEnName)
                    .HasColumnName("Bonus_Type_En_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BonusWayTbl>(entity =>
            {
                entity.HasKey(e => e.BonusWayId);

                entity.ToTable("Bonus_Way_Tbl");

                entity.Property(e => e.BonusWayId).HasColumnName("Bonus_Way_ID");

                entity.Property(e => e.BonusWayArName)
                    .HasColumnName("Bonus_Way_Ar_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.BonusWayEnName)
                    .HasColumnName("Bonus_Way_En_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BusWayTbl>(entity =>
            {
                entity.HasKey(e => e.BusWayId);

                entity.ToTable("Bus_Way_Tbl");

                entity.Property(e => e.BusWayId).HasColumnName("Bus_Way_ID");

                entity.Property(e => e.BusWayArName)
                    .HasColumnName("Bus_Way_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.BusWayArNameShadow)
                    .HasColumnName("Bus_Way_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.BusWayCode)
                    .HasColumnName("Bus_Way_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.BusWayEnName)
                    .HasColumnName("Bus_Way_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<CalculationsLockTbl>(entity =>
            {
                entity.HasKey(e => e.CalculationsLockId);

                entity.ToTable("Calculations_Lock_Tbl");

                entity.Property(e => e.CalculationsLockId).HasColumnName("Calculations_Lock_ID");

                entity.Property(e => e.AttendanceCalculationYn).HasColumnName("Attendance_Calculation_YN");

                entity.Property(e => e.ExportJvLockYn).HasColumnName("Export_JV_Lock_YN");

                entity.Property(e => e.NewMonthLockYn).HasColumnName("New_Month_Lock_YN");

                entity.Property(e => e.PercentileCalculationYn).HasColumnName("Percentile_Calculation_YN");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.SalaryCalculationLockYn).HasColumnName("Salary_Calculation_Lock_YN");

                entity.Property(e => e.ServiceChargeCalculationLockYn).HasColumnName("Service_Charge_Calculation_Lock_YN");

                entity.Property(e => e.TaxBalanceLockYn).HasColumnName("Tax_Balance_Lock_YN");

                entity.Property(e => e.TransferAttendanceDataYn).HasColumnName("Transfer_Attendance_Data_YN");

                entity.Property(e => e.TransferLockYn).HasColumnName("Transfer_Lock_YN");

                entity.Property(e => e.VacationCalculationLockYn).HasColumnName("Vacation_Calculation_Lock_YN");
            });

            modelBuilder.Entity<CashReportDetailsTbl>(entity =>
            {
                entity.HasKey(e => e.CashReportDetailsId);

                entity.ToTable("Cash_Report_Details_Tbl");

                entity.Property(e => e.CashReportDetailsId).HasColumnName("Cash_Report_Details_ID");

                entity.Property(e => e.CurrencyId).HasColumnName("Currency_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.TheMonth).HasColumnName("The_Month");

                entity.Property(e => e.TheYear).HasColumnName("The_Year");

                entity.Property(e => e.UserId).HasColumnName("User_ID");
            });

            modelBuilder.Entity<CertificateTbl>(entity =>
            {
                entity.HasKey(e => e.CertificateId);

                entity.ToTable("Certificate_Tbl");

                entity.Property(e => e.CertificateId).HasColumnName("Certificate_ID");

                entity.Property(e => e.CertificateArName)
                    .HasColumnName("Certificate_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.CertificateArNameShadow)
                    .HasColumnName("Certificate_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.CertificateCode)
                    .HasColumnName("Certificate_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.CertificateEnName)
                    .HasColumnName("Certificate_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.ExpireMonths).HasColumnName("Expire_Months");

                entity.Property(e => e.ExpireYn).HasColumnName("Expire_YN");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.HasTypeYn).HasColumnName("Has_Type_YN");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<CertificateTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.CertificateTransactionId);

                entity.ToTable("Certificate_Transaction_Tbl");

                entity.Property(e => e.CertificateTransactionId).HasColumnName("Certificate_Transaction_ID");

                entity.Property(e => e.CertificateId).HasColumnName("Certificate_ID");

                entity.Property(e => e.CertificateNumber)
                    .HasColumnName("Certificate_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.CertificateTypeId).HasColumnName("Certificate_Type_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.ExpireDate)
                    .HasColumnName("Expire_Date")
                    .HasColumnType("date");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.IssueDate)
                    .HasColumnName("Issue_Date")
                    .HasColumnType("date");

                entity.Property(e => e.IssuePlace)
                    .HasColumnName("Issue_Place")
                    .HasMaxLength(50);

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Certificate)
                    .WithMany(p => p.CertificateTransactionTbl)
                    .HasForeignKey(d => d.CertificateId)
                    .HasConstraintName("FK_Certificate_Transaction_Tbl_Certificate_Tbl");

                entity.HasOne(d => d.CertificateType)
                    .WithMany(p => p.CertificateTransactionTbl)
                    .HasForeignKey(d => d.CertificateTypeId)
                    .HasConstraintName("FK_Certificate_Transaction_Tbl_Certificate_Type_Tbl");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.CertificateTransactionTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Certificate_Transaction_Tbl_Employee_Tbl");
            });

            modelBuilder.Entity<CertificateTypeTbl>(entity =>
            {
                entity.HasKey(e => e.CertificateTypeId);

                entity.ToTable("Certificate_Type_Tbl");

                entity.Property(e => e.CertificateTypeId).HasColumnName("Certificate_Type_ID");

                entity.Property(e => e.CertificateId).HasColumnName("Certificate_ID");

                entity.Property(e => e.CertificateTypeArName)
                    .HasColumnName("Certificate_Type_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.CertificateTypeArNameShadow)
                    .HasColumnName("Certificate_Type_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.CertificateTypeCode)
                    .HasColumnName("Certificate_Type_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.CertificateTypeEnName)
                    .HasColumnName("Certificate_Type_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<ChainTbl>(entity =>
            {
                entity.HasKey(e => e.ChainId);

                entity.ToTable("Chain_Tbl");

                entity.Property(e => e.ChainId)
                    .HasColumnName("Chain_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ChainArName)
                    .HasColumnName("Chain_Ar_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.ChainEnName)
                    .HasColumnName("Chain_En_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ChangeOfCostCenterDetailsTbl>(entity =>
            {
                entity.HasKey(e => e.ChangeOfCostCenterDetailsId);

                entity.ToTable("Change_Of_Cost_Center_Details_Tbl");

                entity.Property(e => e.ChangeOfCostCenterDetailsId).HasColumnName("Change_Of_Cost_Center_Details_ID");

                entity.Property(e => e.BranchId).HasColumnName("Branch_ID");

                entity.Property(e => e.ChangeOfStatusDetailsId).HasColumnName("Change_Of_Status_Details_ID");

                entity.Property(e => e.DeductionsRate).HasColumnName("Deductions_Rate");

                entity.Property(e => e.DepartmentId).HasColumnName("Department_ID");

                entity.Property(e => e.DivisionId).HasColumnName("Division_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PaymentsRate).HasColumnName("Payments_Rate");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.RecordTypeOldNew).HasColumnName("Record_Type_Old_New");

                entity.Property(e => e.SectionId).HasColumnName("Section_ID");

                entity.Property(e => e.UnitId).HasColumnName("Unit_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.ChangeOfStatusDetails)
                    .WithMany(p => p.ChangeOfCostCenterDetailsTbl)
                    .HasForeignKey(d => d.ChangeOfStatusDetailsId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Change_Of_Cost_Center_Details_Tbl_Change_Of_Status_Details_Tbl");
            });

            modelBuilder.Entity<ChangeOfSalaryDetailsTbl>(entity =>
            {
                entity.HasKey(e => e.ChangeOfSalaryDetailsId);

                entity.ToTable("Change_Of_Salary_Details_Tbl");

                entity.Property(e => e.ChangeOfSalaryDetailsId).HasColumnName("Change_Of_Salary_Details_ID");

                entity.Property(e => e.ApplyRetroactivelyYn).HasColumnName("Apply_Retroactively_YN");

                entity.Property(e => e.ChangeAmount).HasColumnName("Change_Amount");

                entity.Property(e => e.ChangeOfStatusTransactionId).HasColumnName("Change_Of_Status_Transaction_ID");

                entity.Property(e => e.ChangeTypeId).HasColumnName("Change_Type_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.NewNetYn).HasColumnName("New_Net_YN");

                entity.Property(e => e.NewValue).HasColumnName("New_Value");

                entity.Property(e => e.NewValueAfterCalc).HasColumnName("New_Value_After_Calc");

                entity.Property(e => e.OldNetYn).HasColumnName("Old_Net_YN");

                entity.Property(e => e.OldValue).HasColumnName("Old_Value");

                entity.Property(e => e.OldValueAfterCalc).HasColumnName("Old_Value_After_Calc");

                entity.Property(e => e.PaymentId).HasColumnName("Payment_ID");

                entity.Property(e => e.PercentageDeductedValue).HasColumnName("Percentage_Deducted_Value");

                entity.Property(e => e.RetroactiveMonthId).HasColumnName("Retroactive_Month_ID");

                entity.Property(e => e.RetroactivePaymentId).HasColumnName("Retroactive_Payment_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.ChangeOfStatusTransaction)
                    .WithMany(p => p.ChangeOfSalaryDetailsTbl)
                    .HasForeignKey(d => d.ChangeOfStatusTransactionId)
                    .HasConstraintName("FK_Change_Of_Salary_Details_Tbl_Change_Of_Status_Transaction_Tbl");

                entity.HasOne(d => d.ChangeType)
                    .WithMany(p => p.ChangeOfSalaryDetailsTbl)
                    .HasForeignKey(d => d.ChangeTypeId)
                    .HasConstraintName("FK_Change_Of_Salary_Details_Tbl_Change_Type_Tbl");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.ChangeOfSalaryDetailsTbl)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_Change_Of_Salary_Details_Tbl_Payment_Tbl");
            });

            modelBuilder.Entity<ChangeOfStatusDetailsTbl>(entity =>
            {
                entity.HasKey(e => e.ChangeOfStatusDetailsId);

                entity.ToTable("Change_Of_Status_Details_Tbl");

                entity.Property(e => e.ChangeOfStatusDetailsId).HasColumnName("Change_Of_Status_Details_ID");

                entity.Property(e => e.ChangeOfStatusTransactionId).HasColumnName("Change_Of_Status_Transaction_ID");

                entity.Property(e => e.ChangeableFieldId).HasColumnName("Changeable_Field_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.InsuranceDate)
                    .HasColumnName("Insurance_Date")
                    .HasColumnType("date");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.NewValue)
                    .HasColumnName("New_Value")
                    .HasMaxLength(200);

                entity.Property(e => e.NewValueArName)
                    .HasColumnName("New_Value_Ar_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.NewValueEnName)
                    .HasColumnName("New_Value_En_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.OldValue)
                    .HasColumnName("Old_Value")
                    .HasMaxLength(200);

                entity.Property(e => e.OldValueArName)
                    .HasColumnName("Old_Value_Ar_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.OldValueEnName)
                    .HasColumnName("Old_Value_En_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.ChangeOfStatusTransaction)
                    .WithMany(p => p.ChangeOfStatusDetailsTbl)
                    .HasForeignKey(d => d.ChangeOfStatusTransactionId)
                    .HasConstraintName("FK_Change_Of_Status_Details_Tbl_Change_Of_Status_Transaction_Tbl");

                entity.HasOne(d => d.ChangeableField)
                    .WithMany(p => p.ChangeOfStatusDetailsTbl)
                    .HasForeignKey(d => d.ChangeableFieldId)
                    .HasConstraintName("FK_Change_Of_Status_Details_Tbl_Changeable_Field_Tbl");
            });

            modelBuilder.Entity<ChangeOfStatusReasonTbl>(entity =>
            {
                entity.HasKey(e => e.ChangeOfStatusReasonId);

                entity.ToTable("Change_Of_Status_Reason_Tbl");

                entity.Property(e => e.ChangeOfStatusReasonId).HasColumnName("Change_Of_Status_Reason_ID");

                entity.Property(e => e.ChangeOfStatusReasonArName)
                    .HasColumnName("Change_Of_Status_Reason_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.ChangeOfStatusReasonArNameShadow)
                    .HasColumnName("Change_Of_Status_Reason_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.ChangeOfStatusReasonCode)
                    .HasColumnName("Change_Of_Status_Reason_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ChangeOfStatusReasonEnName)
                    .HasColumnName("Change_Of_Status_Reason_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<ChangeOfStatusTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.ChangeOfStatusTransactionId);

                entity.ToTable("Change_Of_Status_Transaction_Tbl");

                entity.Property(e => e.ChangeOfStatusTransactionId).HasColumnName("Change_Of_Status_Transaction_ID");

                entity.Property(e => e.ApprovedYn).HasColumnName("Approved_YN");

                entity.Property(e => e.ChangeDate)
                    .HasColumnName("Change_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ChangeOfStatusReasonId).HasColumnName("Change_Of_Status_Reason_ID");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnName("Effective_Date")
                    .HasColumnType("date");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.PayrollTransactionYn).HasColumnName("Payroll_Transaction_YN");

                entity.Property(e => e.PersentageYn).HasColumnName("Persentage_YN");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.SysRequestStatusId).HasColumnName("Sys_Request_Status_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.ChangeOfStatusReason)
                    .WithMany(p => p.ChangeOfStatusTransactionTbl)
                    .HasForeignKey(d => d.ChangeOfStatusReasonId)
                    .HasConstraintName("FK_Change_Of_Status_Transaction_Tbl_Change_Of_Status_Reason_Tbl");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.ChangeOfStatusTransactionTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Change_Of_Status_Transaction_Tbl_Employee_Tbl");
            });

            modelBuilder.Entity<ChangeTypeTbl>(entity =>
            {
                entity.HasKey(e => e.ChangeTypeId);

                entity.ToTable("Change_Type_Tbl");

                entity.Property(e => e.ChangeTypeId).HasColumnName("Change_Type_ID");

                entity.Property(e => e.ChangeTypeArName)
                    .HasColumnName("Change_Type_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.ChangeTypeEnName)
                    .HasColumnName("Change_Type_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ChangeableFieldTbl>(entity =>
            {
                entity.HasKey(e => e.ChangeableFieldId)
                    .HasName("PK_Changeable_Field_Tbl_1");

                entity.ToTable("Changeable_Field_Tbl");

                entity.Property(e => e.ChangeableFieldId)
                    .HasColumnName("Changeable_Field_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppSettingId).HasColumnName("App_Setting_ID");

                entity.Property(e => e.BatchStatus)
                    .HasColumnName("Batch_Status")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeableControlName)
                    .HasColumnName("Changeable_Control_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.ChangeableControlType)
                    .HasColumnName("Changeable_Control_Type")
                    .HasMaxLength(100);

                entity.Property(e => e.ChangeableFieldArName)
                    .HasColumnName("Changeable_Field_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.ChangeableFieldCode)
                    .HasColumnName("Changeable_Field_Code")
                    .HasMaxLength(100);

                entity.Property(e => e.ChangeableFieldEnName)
                    .HasColumnName("Changeable_Field_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.SelfServiceYn).HasColumnName("Self_Service_YN");

                entity.Property(e => e.SortId).HasColumnName("Sort_ID");
            });

            modelBuilder.Entity<CivilIdTypeTbl>(entity =>
            {
                entity.HasKey(e => e.CivilIdTypeId);

                entity.ToTable("Civil_ID_Type_Tbl");

                entity.Property(e => e.CivilIdTypeId).HasColumnName("Civil_ID_Type_ID");

                entity.Property(e => e.CivilIdTypeArName)
                    .HasColumnName("Civil_ID_Type_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.CivilIdTypeEnName)
                    .HasColumnName("Civil_ID_Type_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CommunicationTypeTbl>(entity =>
            {
                entity.HasKey(e => e.CommunicationTypeId);

                entity.ToTable("Communication_Type_Tbl");

                entity.Property(e => e.CommunicationTypeId).HasColumnName("Communication_Type_ID");

                entity.Property(e => e.CommunicationTypeArName)
                    .HasColumnName("Communication_Type_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.CommunicationTypeEnName)
                    .HasColumnName("Communication_Type_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ComparisionReportDetailsTbl>(entity =>
            {
                entity.HasKey(e => e.ComparisionReportDetailsId);

                entity.ToTable("Comparision_Report_Details_Tbl");

                entity.Property(e => e.ComparisionReportDetailsId).HasColumnName("Comparision_Report_Details_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FirstInsurance).HasColumnName("First_Insurance");

                entity.Property(e => e.FirstInsuranceAdjustment).HasColumnName("First_Insurance_Adjustment");

                entity.Property(e => e.FirstMonth).HasColumnName("First_Month");

                entity.Property(e => e.FirstNet).HasColumnName("First_Net");

                entity.Property(e => e.FirstSalaryTax).HasColumnName("First_Salary_Tax");

                entity.Property(e => e.FirstServiceChargeNet).HasColumnName("First_Service_Charge_Net");

                entity.Property(e => e.FirstServiceChargeTax).HasColumnName("First_Service_Charge_Tax");

                entity.Property(e => e.FirstServiceChargeValue).HasColumnName("First_Service_Charge_Value");

                entity.Property(e => e.FirstTaxAdjustment).HasColumnName("First_Tax_Adjustment");

                entity.Property(e => e.FirstTotalDeductions).HasColumnName("First_Total_Deductions");

                entity.Property(e => e.FirstTotalPayments).HasColumnName("First_Total_Payments");

                entity.Property(e => e.FirstYear).HasColumnName("First_Year");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.SecondInsurance).HasColumnName("Second_Insurance");

                entity.Property(e => e.SecondInsuranceAdjustment).HasColumnName("Second_Insurance_Adjustment");

                entity.Property(e => e.SecondMonth).HasColumnName("Second_Month");

                entity.Property(e => e.SecondNet).HasColumnName("Second_Net");

                entity.Property(e => e.SecondSalaryTax).HasColumnName("Second_Salary_Tax");

                entity.Property(e => e.SecondServiceChargeNet).HasColumnName("Second_Service_Charge_Net");

                entity.Property(e => e.SecondServiceChargeTax).HasColumnName("Second_Service_Charge_Tax");

                entity.Property(e => e.SecondServiceChargeValue).HasColumnName("Second_Service_Charge_Value");

                entity.Property(e => e.SecondTaxAdjustment).HasColumnName("Second_Tax_Adjustment");

                entity.Property(e => e.SecondTotalDeductions).HasColumnName("Second_Total_Deductions");

                entity.Property(e => e.SecondTotalPayments).HasColumnName("Second_Total_Payments");

                entity.Property(e => e.SecondYear).HasColumnName("Second_Year");

                entity.Property(e => e.UserId).HasColumnName("User_ID");
            });

            modelBuilder.Entity<ComponentComparisionAnalysisReportDetailsTbl>(entity =>
            {
                entity.HasKey(e => e.ComponentComparisionAnalysisReportDetailsId);

                entity.ToTable("Component_Comparision_Analysis_Report_Details_Tbl");

                entity.Property(e => e.ComponentComparisionAnalysisReportDetailsId).HasColumnName("Component_Comparision_Analysis_Report_Details_ID");

                entity.Property(e => e.ComparisonFieldId).HasColumnName("Comparison_Field_ID");

                entity.Property(e => e.ComponentArName)
                    .HasColumnName("Component_Ar_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.ComponentEnName)
                    .HasColumnName("Component_En_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.ComponentId).HasColumnName("Component_ID");

                entity.Property(e => e.ComponentTypeArName)
                    .HasColumnName("Component_Type_Ar_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.ComponentTypeEnName)
                    .HasColumnName("Component_Type_En_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.ComponentTypeId).HasColumnName("Component_Type_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.TheValue).HasColumnName("The_Value");

                entity.Property(e => e.UserId).HasColumnName("User_ID");
            });

            modelBuilder.Entity<ComponentComparisionReportDetailsTbl>(entity =>
            {
                entity.HasKey(e => e.ComponentComparisionReportDetailsId);

                entity.ToTable("Component_Comparision_Report_Details_Tbl");

                entity.Property(e => e.ComponentComparisionReportDetailsId).HasColumnName("Component_Comparision_Report_Details_ID");

                entity.Property(e => e.ComponentArName)
                    .HasColumnName("Component_Ar_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.ComponentEnName)
                    .HasColumnName("Component_En_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.ComponentId).HasColumnName("Component_ID");

                entity.Property(e => e.ComponentTypeArName)
                    .HasColumnName("Component_Type_Ar_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.ComponentTypeEnName)
                    .HasColumnName("Component_Type_En_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.ComponentTypeId).HasColumnName("Component_Type_ID");

                entity.Property(e => e.FirstMonth).HasColumnName("First_Month");

                entity.Property(e => e.FirstValue).HasColumnName("First_Value");

                entity.Property(e => e.FirstYear).HasColumnName("First_Year");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.SecondMonth).HasColumnName("Second_Month");

                entity.Property(e => e.SecondValue).HasColumnName("Second_Value");

                entity.Property(e => e.SecondYear).HasColumnName("Second_Year");

                entity.Property(e => e.UserId).HasColumnName("User_ID");
            });

            modelBuilder.Entity<ContractRenewalTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.ContractRenewalTransactionId);

                entity.ToTable("Contract_Renewal_Transaction_Tbl");

                entity.Property(e => e.ContractRenewalTransactionId).HasColumnName("Contract_Renewal_Transaction_ID");

                entity.Property(e => e.ContractNumber).HasColumnName("Contract_Number");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.NewContractDate)
                    .HasColumnName("New_Contract_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NewContractExpireDate)
                    .HasColumnName("New_Contract_Expire_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NewContractId).HasColumnName("New_Contract_ID");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.OldContractDate)
                    .HasColumnName("Old_Contract_Date")
                    .HasColumnType("date");

                entity.Property(e => e.OldContractExpireDate)
                    .HasColumnName("Old_Contract_Expire_Date")
                    .HasColumnType("date");

                entity.Property(e => e.OldContractId).HasColumnName("Old_Contract_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.RenewalDate)
                    .HasColumnName("Renewal_Date")
                    .HasColumnType("date");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.ContractRenewalTransactionTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Contract_Renewal_Transaction_Tbl_Employee_Tbl");

                entity.HasOne(d => d.NewContract)
                    .WithMany(p => p.ContractRenewalTransactionTblNewContract)
                    .HasForeignKey(d => d.NewContractId)
                    .HasConstraintName("FK_Contract_Renewal_Transaction_Tbl_Contract_Tbl1");

                entity.HasOne(d => d.OldContract)
                    .WithMany(p => p.ContractRenewalTransactionTblOldContract)
                    .HasForeignKey(d => d.OldContractId)
                    .HasConstraintName("FK_Contract_Renewal_Transaction_Tbl_Contract_Tbl");
            });

            modelBuilder.Entity<ContractTbl>(entity =>
            {
                entity.HasKey(e => e.ContractId);

                entity.ToTable("Contract_Tbl");

                entity.Property(e => e.ContractId).HasColumnName("Contract_ID");

                entity.Property(e => e.ContractArName)
                    .HasColumnName("Contract_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.ContractArNameShadow)
                    .HasColumnName("Contract_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.ContractCode)
                    .HasColumnName("Contract_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ContractEnName)
                    .HasColumnName("Contract_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.ContractMonths).HasColumnName("Contract_Months");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<CountryTbl>(entity =>
            {
                entity.HasKey(e => e.CountryId)
                    .HasName("PK_Country_Tbl_1");

                entity.ToTable("Country_Tbl");

                entity.Property(e => e.CountryId).HasColumnName("Country_ID");

                entity.Property(e => e.CountryArName)
                    .HasColumnName("Country_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.CountryArNameShadow)
                    .HasColumnName("Country_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.CountryCode)
                    .HasColumnName("Country_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.CountryEnName)
                    .HasColumnName("Country_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<CourseTbl>(entity =>
            {
                entity.HasKey(e => e.CourseId);

                entity.ToTable("Course_Tbl");

                entity.Property(e => e.CourseId).HasColumnName("Course_ID");

                entity.Property(e => e.CourseArName)
                    .HasColumnName("Course_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.CourseArNameShadow)
                    .HasColumnName("Course_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.CourseCode)
                    .HasColumnName("Course_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.CourseEnName)
                    .HasColumnName("Course_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<CourseTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.CourseTransactionId);

                entity.ToTable("Course_Transaction_Tbl");

                entity.Property(e => e.CourseTransactionId).HasColumnName("Course_Transaction_ID");

                entity.Property(e => e.CourseCenter)
                    .HasColumnName("Course_Center")
                    .HasMaxLength(100);

                entity.Property(e => e.CourseDetails)
                    .HasColumnName("Course_Details")
                    .HasMaxLength(200);

                entity.Property(e => e.CourseId).HasColumnName("Course_ID");

                entity.Property(e => e.EmployeeDegree)
                    .HasColumnName("Employee_Degree")
                    .HasMaxLength(100);

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.FromDate)
                    .HasColumnName("From_Date")
                    .HasColumnType("date");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.ToDate)
                    .HasColumnName("To_Date")
                    .HasColumnType("date");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.CourseTransactionTbl)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_Course_Transaction_Tbl_Course_Tbl");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.CourseTransactionTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Course_Transaction_Tbl_Employee_Tbl");
            });

            modelBuilder.Entity<CurrencyTbl>(entity =>
            {
                entity.HasKey(e => e.CurrencyId);

                entity.ToTable("Currency_Tbl");

                entity.Property(e => e.CurrencyId).HasColumnName("Currency_ID");

                entity.Property(e => e.CurrencyAbbreviation)
                    .HasColumnName("Currency_Abbreviation")
                    .HasMaxLength(20);

                entity.Property(e => e.CurrencyArName)
                    .HasColumnName("Currency_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.CurrencyArNameShadow)
                    .HasColumnName("Currency_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("Currency_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.CurrencyConversion)
                    .HasColumnName("Currency_Conversion")
                    .HasMaxLength(20);

                entity.Property(e => e.CurrencyEnName)
                    .HasColumnName("Currency_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.NoOfDecimal).HasColumnName("No_Of_Decimal");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<CustodyTbl>(entity =>
            {
                entity.HasKey(e => e.CustodyId);

                entity.ToTable("Custody_Tbl");

                entity.Property(e => e.CustodyId).HasColumnName("Custody_ID");

                entity.Property(e => e.CustodyArName)
                    .HasColumnName("Custody_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.CustodyArNameShadow)
                    .HasColumnName("Custody_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.CustodyCode)
                    .HasColumnName("Custody_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.CustodyEnName)
                    .HasColumnName("Custody_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.ExpireMonths).HasColumnName("Expire_Months");

                entity.Property(e => e.ExpireYn).HasColumnName("Expire_YN");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.HasNumberYn).HasColumnName("Has_Number_YN");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<CustodyTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.CustodyTransactionId);

                entity.ToTable("Custody_Transaction_Tbl");

                entity.Property(e => e.CustodyTransactionId).HasColumnName("Custody_Transaction_ID");

                entity.Property(e => e.CustodyId).HasColumnName("Custody_ID");

                entity.Property(e => e.CustodyNumber)
                    .HasColumnName("Custody_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.DeliveredDate)
                    .HasColumnName("Delivered_Date")
                    .HasColumnType("date");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.ExpireDate)
                    .HasColumnName("Expire_Date")
                    .HasColumnType("date");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.ReturnedYn).HasColumnName("Returned_YN");

                entity.Property(e => e.SysRequestStatusId).HasColumnName("Sys_Request_Status_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Custody)
                    .WithMany(p => p.CustodyTransactionTbl)
                    .HasForeignKey(d => d.CustodyId)
                    .HasConstraintName("FK_Custody_Transaction_Tbl_Custody_Tbl");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.CustodyTransactionTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Custody_Transaction_Tbl_Employee_Tbl");

                entity.HasOne(d => d.SysRequestStatus)
                    .WithMany(p => p.CustodyTransactionTbl)
                    .HasForeignKey(d => d.SysRequestStatusId)
                    .HasConstraintName("FK_Custody_Transaction_Tbl_Sys_Request_Status_ID");
            });

            modelBuilder.Entity<DailyEmploymentAttendanceTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.DailyEmploymentAttendanceTransactionId);

                entity.ToTable("Daily_Employment_Attendance_Transaction_Tbl");

                entity.Property(e => e.DailyEmploymentAttendanceTransactionId).HasColumnName("Daily_Employment_Attendance_Transaction_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.TheDate)
                    .HasColumnName("The_Date")
                    .HasColumnType("date");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.DailyEmploymentAttendanceTransactionTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Daily_Employment_Attendance_Transaction_Tbl_Employee_Tbl");
            });

            modelBuilder.Entity<DailyHeadCountReportDetailsTbl>(entity =>
            {
                entity.HasKey(e => e.DailyHeadCountReportDetailsId);

                entity.ToTable("Daily_Head_Count_Report_Details_Tbl");

                entity.Property(e => e.DailyHeadCountReportDetailsId).HasColumnName("Daily_Head_Count_Report_Details_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.Property(e => e.V1).HasColumnName("V_1");

                entity.Property(e => e.V10).HasColumnName("V_10");

                entity.Property(e => e.V11).HasColumnName("V_11");

                entity.Property(e => e.V12).HasColumnName("V_12");

                entity.Property(e => e.V13).HasColumnName("V_13");

                entity.Property(e => e.V14).HasColumnName("V_14");

                entity.Property(e => e.V15).HasColumnName("V_15");

                entity.Property(e => e.V2).HasColumnName("V_2");

                entity.Property(e => e.V3).HasColumnName("V_3");

                entity.Property(e => e.V4).HasColumnName("V_4");

                entity.Property(e => e.V5).HasColumnName("V_5");

                entity.Property(e => e.V6).HasColumnName("V_6");

                entity.Property(e => e.V7).HasColumnName("V_7");

                entity.Property(e => e.V8).HasColumnName("V_8");

                entity.Property(e => e.V9).HasColumnName("V_9");
            });

            modelBuilder.Entity<DayOfTheWeekTbl>(entity =>
            {
                entity.HasKey(e => e.DayOfTheWeekId);

                entity.ToTable("Day_Of_The_Week_Tbl");

                entity.Property(e => e.DayOfTheWeekId).HasColumnName("Day_Of_The_Week_ID");

                entity.Property(e => e.DayOfTheWeekArName)
                    .HasColumnName("Day_Of_The_Week_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.DayOfTheWeekEnName)
                    .HasColumnName("Day_Of_The_Week_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DaysTbl>(entity =>
            {
                entity.ToTable("Days_Tbl");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DayId)
                    .HasColumnName("DayID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DeductionDetailsTbl>(entity =>
            {
                entity.HasKey(e => new { e.DeductionId, e.PaymentId })
                    .HasName("PK_Deduction_Details_Tbl_1");

                entity.ToTable("Deduction_Details_Tbl");

                entity.Property(e => e.DeductionId).HasColumnName("Deduction_ID");

                entity.Property(e => e.PaymentId).HasColumnName("Payment_ID");

                entity.HasOne(d => d.Deduction)
                    .WithMany(p => p.DeductionDetailsTbl)
                    .HasForeignKey(d => d.DeductionId)
                    .HasConstraintName("FK_Deduction_Details_Tbl_Deduction_Tbl");
            });

            modelBuilder.Entity<DeductionTbl>(entity =>
            {
                entity.HasKey(e => e.DeductionId);

                entity.ToTable("Deduction_Tbl");

                entity.Property(e => e.DeductionId).HasColumnName("Deduction_ID");

                entity.Property(e => e.AccountNumberId).HasColumnName("Account_Number_ID");

                entity.Property(e => e.ActiveYn).HasColumnName("Active_YN");

                entity.Property(e => e.DaysHoursFactor).HasColumnName("Days_Hours_Factor");

                entity.Property(e => e.DeductionArName)
                    .HasColumnName("Deduction_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.DeductionArNameShadow)
                    .HasColumnName("Deduction_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.DeductionArShortName)
                    .HasColumnName("Deduction_Ar_Short_Name")
                    .HasMaxLength(20);

                entity.Property(e => e.DeductionCode)
                    .HasColumnName("Deduction_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.DeductionContinuity).HasColumnName("Deduction_Continuity");

                entity.Property(e => e.DeductionEnName)
                    .HasColumnName("Deduction_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.DeductionEnShortName)
                    .HasColumnName("Deduction_En_Short_Name")
                    .HasMaxLength(20);

                entity.Property(e => e.DeductionStatusId).HasColumnName("Deduction_Status_ID");

                entity.Property(e => e.DeductionTypeId).HasColumnName("Deduction_Type_ID");

                entity.Property(e => e.EffectInServiceChargeYn).HasColumnName("Effect_In_Service_Charge_YN");

                entity.Property(e => e.FixedAmountYn).HasColumnName("Fixed_Amount_YN");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.InterfaceYn).HasColumnName("Interface_YN");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.MaximumAmount).HasColumnName("Maximum_Amount");

                entity.Property(e => e.MinimumAmount).HasColumnName("Minimum_Amount");

                entity.Property(e => e.PaymentGroupId).HasColumnName("Payment_Group_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.SelectionGroupPayment).HasColumnName("Selection_Group_Payment");

                entity.Property(e => e.TaxableYn).HasColumnName("Taxable_YN");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.AccountNumber)
                    .WithMany(p => p.DeductionTbl)
                    .HasForeignKey(d => d.AccountNumberId)
                    .HasConstraintName("FK_Deduction_Tbl_Account_Number_Tbl");

                entity.HasOne(d => d.PaymentGroup)
                    .WithMany(p => p.DeductionTbl)
                    .HasForeignKey(d => d.PaymentGroupId)
                    .HasConstraintName("FK_Deduction_Tbl_Payment_Group_Tbl");
            });

            modelBuilder.Entity<DeductionTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.DeductionTransactionId);

                entity.ToTable("Deduction_Transaction_Tbl");

                entity.Property(e => e.DeductionTransactionId).HasColumnName("Deduction_Transaction_ID");

                entity.Property(e => e.ActiveYn).HasColumnName("Active_YN");

                entity.Property(e => e.CalculateFromValueNonSc).HasColumnName("Calculate_From_Value_Non_SC");

                entity.Property(e => e.CalculateFromValueNonTaxable).HasColumnName("Calculate_From_Value_Non_Taxable");

                entity.Property(e => e.CalculateFromValueSc).HasColumnName("Calculate_From_Value_SC");

                entity.Property(e => e.CalculateFromValueTaxable).HasColumnName("Calculate_From_Value_Taxable");

                entity.Property(e => e.DeductionId).HasColumnName("Deduction_ID");

                entity.Property(e => e.DeductionValueAfterCalc).HasColumnName("Deduction_Value_After_Calc");

                entity.Property(e => e.DeductionValueBeforeCalc).HasColumnName("Deduction_Value_Before_Calc");

                entity.Property(e => e.DeductionValueByLocalCurrency).HasColumnName("Deduction_Value_By_Local_Currency");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.TheMonth).HasColumnName("The_Month");

                entity.Property(e => e.TheYear).HasColumnName("The_Year");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Deduction)
                    .WithMany(p => p.DeductionTransactionTbl)
                    .HasForeignKey(d => d.DeductionId)
                    .HasConstraintName("FK_Deduction_Transaction_Tbl_Deduction_Tbl");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.DeductionTransactionTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Deduction_Transaction_Tbl_Employee_Tbl");
            });

            modelBuilder.Entity<DeductionTypeTbl>(entity =>
            {
                entity.ToTable("Deduction_Type_Tbl");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeductionTypeArName)
                    .HasColumnName("Deduction_Type_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.DeductionTypeEnName)
                    .HasColumnName("Deduction_Type_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.DeductionTypeId).HasColumnName("Deduction_Type_ID");
            });

            modelBuilder.Entity<DepartmentTbl>(entity =>
            {
                entity.HasKey(e => e.DepartmentId);

                entity.ToTable("Department_Tbl");

                entity.Property(e => e.DepartmentId).HasColumnName("Department_ID");

                entity.Property(e => e.DepartmentArName)
                    .HasColumnName("Department_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.DepartmentArNameShadow)
                    .HasColumnName("Department_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.DepartmentCode)
                    .HasColumnName("Department_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.DepartmentCostCenter)
                    .HasColumnName("Department_Cost_Center")
                    .HasMaxLength(20);

                entity.Property(e => e.DepartmentEnName)
                    .HasColumnName("Department_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.DepartmentMgrId).HasColumnName("Department_Mgr_ID");

                entity.Property(e => e.DepartmentSecId).HasColumnName("Department_Sec_ID");

                entity.Property(e => e.DivisionId).HasColumnName("Division_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<DeportedPenaltyTbl>(entity =>
            {
                entity.HasKey(e => e.DeportedPenaltyId);

                entity.ToTable("Deported_Penalty_Tbl");

                entity.Property(e => e.DeportedPenaltyId).HasColumnName("Deported_Penalty_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.PenaltyAmount).HasColumnName("Penalty_Amount");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.TheMonth).HasColumnName("The_Month");

                entity.Property(e => e.TheYear).HasColumnName("The_Year");
            });

            modelBuilder.Entity<DiseaseTbl>(entity =>
            {
                entity.HasKey(e => e.DiseaseId);

                entity.ToTable("Disease_Tbl");

                entity.Property(e => e.DiseaseId).HasColumnName("Disease_ID");

                entity.Property(e => e.DiseaseArName)
                    .HasColumnName("Disease_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.DiseaseArNameShadow)
                    .HasColumnName("Disease_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.DiseaseCode)
                    .HasColumnName("Disease_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.DiseaseEnName)
                    .HasColumnName("Disease_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<DivisionTbl>(entity =>
            {
                entity.HasKey(e => e.DivisionId);

                entity.ToTable("Division_Tbl");

                entity.Property(e => e.DivisionId).HasColumnName("Division_ID");

                entity.Property(e => e.DefaultYn)
                    .HasColumnName("Default_YN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DivisionArName)
                    .HasColumnName("Division_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.DivisionArNameShadow)
                    .HasColumnName("Division_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.DivisionCode)
                    .HasColumnName("Division_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.DivisionCostCenter)
                    .HasColumnName("Division_Cost_Center")
                    .HasMaxLength(20);

                entity.Property(e => e.DivisionEnName)
                    .HasColumnName("Division_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.DivisionMgrId).HasColumnName("Division_Mgr_ID");

                entity.Property(e => e.DivisionSecId).HasColumnName("Division_Sec_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<DocumentArchiveTbl>(entity =>
            {
                entity.HasKey(e => e.DocumentArchiveId);

                entity.ToTable("Document_Archive_Tbl");

                entity.Property(e => e.DocumentArchiveId).HasColumnName("Document_Archive_ID");

                entity.Property(e => e.DocumentFileName)
                    .HasColumnName("Document_File_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.DocumentPath)
                    .HasColumnName("Document_Path")
                    .HasMaxLength(500);

                entity.Property(e => e.DocumentTableName)
                    .HasColumnName("Document_Table_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.MasterId).HasColumnName("Master_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.SysDocumentTypeId).HasColumnName("Sys_Document_Type_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<DocumentBorrowingTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.DocumentBorrowingTransactionId);

                entity.ToTable("Document_Borrowing_Transaction_Tbl");

                entity.Property(e => e.DocumentBorrowingTransactionId).HasColumnName("Document_Borrowing_Transaction_ID");

                entity.Property(e => e.BorrowingDate)
                    .HasColumnName("Borrowing_Date")
                    .HasColumnType("date");

                entity.Property(e => e.BorrowingEmployeeId).HasColumnName("Borrowing_Employee_ID");

                entity.Property(e => e.BorrowingReason)
                    .HasColumnName("Borrowing_Reason")
                    .HasMaxLength(100);

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.HiringDocumentId).HasColumnName("Hiring_Document_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.ReturnDate)
                    .HasColumnName("Return_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReturnInDate)
                    .HasColumnName("Return_In_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReturnYn).HasColumnName("Return_YN");

                entity.Property(e => e.SameEmployeeYn).HasColumnName("Same_Employee_YN");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.DocumentBorrowingTransactionTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Document_Borrowing_Transaction_Tbl_Employee_Tbl");

                entity.HasOne(d => d.HiringDocument)
                    .WithMany(p => p.DocumentBorrowingTransactionTbl)
                    .HasForeignKey(d => d.HiringDocumentId)
                    .HasConstraintName("FK_Document_Borrowing_Transaction_Tbl_Hiring_Document_Tbl");
            });

            modelBuilder.Entity<EmailConfigurationTbl>(entity =>
            {
                entity.HasKey(e => e.EmailConfigurationId);

                entity.ToTable("Email_Configuration_Tbl");

                entity.Property(e => e.EmailConfigurationId).HasColumnName("Email_Configuration_ID");

                entity.Property(e => e.EmailExchangeUrl).HasColumnName("Email_Exchange_Url");

                entity.Property(e => e.EmailPortNo).HasColumnName("Email_Port_No");

                entity.Property(e => e.EmailSmtp).HasColumnName("Email_Smtp");

                entity.Property(e => e.EmailUseSslYn).HasColumnName("Email_Use_SSL_YN");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.SysEmailSetupTypeId).HasColumnName("Sys_Email_Setup_Type_ID");

                entity.Property(e => e.SysExchangeTypeId).HasColumnName("Sys_Exchange_Type_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.EmailConfigurationTbl)
                    .HasForeignKey(d => d.PropertyId)
                    .HasConstraintName("FK_Email_Configuration_Tbl_Property_Tbl");

                entity.HasOne(d => d.SysEmailSetupType)
                    .WithMany(p => p.EmailConfigurationTbl)
                    .HasForeignKey(d => d.SysEmailSetupTypeId)
                    .HasConstraintName("FK_Email_Configuration_Tbl_Sys_Email_Setup_Type_Tbl");

                entity.HasOne(d => d.SysExchangeType)
                    .WithMany(p => p.EmailConfigurationTbl)
                    .HasForeignKey(d => d.SysExchangeTypeId)
                    .HasConstraintName("FK_Email_Configuration_Tbl_Sys_Exchange_Type_Tbl");
            });

            modelBuilder.Entity<EmailTypeTbl>(entity =>
            {
                entity.HasKey(e => e.EmailTypeId);

                entity.ToTable("Email_Type_Tbl");

                entity.Property(e => e.EmailTypeId).HasColumnName("Email_Type_ID");

                entity.Property(e => e.EmailTypeArName)
                    .HasColumnName("Email_Type_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.EmailTypeEnName)
                    .HasColumnName("Email_Type_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<EmployeeAddressTbl>(entity =>
            {
                entity.HasKey(e => e.EmployeeAddressId);

                entity.ToTable("Employee_Address_Tbl");

                entity.Property(e => e.EmployeeAddressId).HasColumnName("Employee_Address_ID");

                entity.Property(e => e.AddressAr)
                    .HasColumnName("Address_Ar")
                    .HasMaxLength(100);

                entity.Property(e => e.AddressEn)
                    .HasColumnName("Address_En")
                    .HasMaxLength(100);

                entity.Property(e => e.AddressNotes)
                    .HasColumnName("Address_Notes")
                    .HasMaxLength(100);

                entity.Property(e => e.AreaAr)
                    .HasColumnName("Area_Ar")
                    .HasMaxLength(50);

                entity.Property(e => e.AreaEn)
                    .HasColumnName("Area_En")
                    .HasMaxLength(50);

                entity.Property(e => e.CountryId).HasColumnName("Country_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.GovernorateId).HasColumnName("Governorate_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PostalCode)
                    .HasColumnName("Postal_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PrimaryYn).HasColumnName("Primary_YN");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.EmployeeAddressTbl)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Employee_Address_Tbl_Country_Tbl");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeAddressTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Employee_Address_Tbl_Employee_Tbl");

                entity.HasOne(d => d.Governorate)
                    .WithMany(p => p.EmployeeAddressTbl)
                    .HasForeignKey(d => d.GovernorateId)
                    .HasConstraintName("FK_Employee_Address_Tbl_Governorate_Tbl");
            });

            modelBuilder.Entity<EmployeeCommunicationTbl>(entity =>
            {
                entity.HasKey(e => e.EmployeeCommunicationId)
                    .HasName("PK_Employee_Communications_Tbl");

                entity.ToTable("Employee_Communication_Tbl");

                entity.Property(e => e.EmployeeCommunicationId).HasColumnName("Employee_Communication_ID");

                entity.Property(e => e.CommunicationTypeId).HasColumnName("Communication_Type_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.Number).HasMaxLength(20);

                entity.Property(e => e.PrimaryYn).HasColumnName("Primary_YN");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.CommunicationType)
                    .WithMany(p => p.EmployeeCommunicationTbl)
                    .HasForeignKey(d => d.CommunicationTypeId)
                    .HasConstraintName("FK_Employee_Communication_Tbl_Communication_Type_Tbl");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeCommunicationTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Employee_Communication_Tbl_Employee_Tbl");
            });

            modelBuilder.Entity<EmployeeCostCenterTbl>(entity =>
            {
                entity.HasKey(e => e.EmployeeCostCenterId);

                entity.ToTable("Employee_Cost_Center_Tbl");

                entity.Property(e => e.EmployeeCostCenterId).HasColumnName("Employee_Cost_Center_ID");

                entity.Property(e => e.DeductionsRate).HasColumnName("Deductions_Rate");

                entity.Property(e => e.DepartmentId).HasColumnName("Department_ID");

                entity.Property(e => e.DivisionId).HasColumnName("Division_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PaymentsRate).HasColumnName("Payments_Rate");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.SectionId).HasColumnName("Section_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.EmployeeCostCenterTbl)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_Employee_Cost_Center_Tbl_Department_Tbl");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.EmployeeCostCenterTbl)
                    .HasForeignKey(d => d.DivisionId)
                    .HasConstraintName("FK_Employee_Cost_Center_Tbl_Division_Tbl");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeCostCenterTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Employee_Cost_Center_Tbl_Employee_Tbl");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.EmployeeCostCenterTbl)
                    .HasForeignKey(d => d.PropertyId)
                    .HasConstraintName("FK_Employee_Cost_Center_Tbl_Property_Tbl");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.EmployeeCostCenterTbl)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_Employee_Cost_Center_Tbl_Section_Tbl");
            });

            modelBuilder.Entity<EmployeeDailySchedulesTbl>(entity =>
            {
                entity.HasKey(e => e.EmployeeDailySchedulesId);

                entity.ToTable("Employee_Daily_Schedules_Tbl");

                entity.Property(e => e.EmployeeDailySchedulesId).HasColumnName("Employee_Daily_Schedules_ID");

                entity.Property(e => e.DayStatusWorkingDayoff).HasColumnName("Day_Status_Working_Dayoff");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.NightShiftYn).HasColumnName("Night_Shift_YN");

                entity.Property(e => e.OverTimeStart).HasColumnName("Over_Time_Start");

                entity.Property(e => e.PassIn).HasColumnName("Pass_In");

                entity.Property(e => e.ScheduleId).HasColumnName("Schedule_ID");

                entity.Property(e => e.ScheduleOrder).HasColumnName("Schedule_Order");

                entity.Property(e => e.TheDate)
                    .HasColumnName("The_Date")
                    .HasColumnType("date");

                entity.Property(e => e.TimeIn).HasColumnName("Time_In");

                entity.Property(e => e.TimeOut).HasColumnName("Time_Out");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<EmployeeEmailTbl>(entity =>
            {
                entity.HasKey(e => e.EmployeeEmailId);

                entity.ToTable("Employee_Email_Tbl");

                entity.Property(e => e.EmployeeEmailId).HasColumnName("Employee_Email_ID");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EmailTypeId).HasColumnName("Email_Type_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PrimaryYn).HasColumnName("Primary_YN");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.EmailType)
                    .WithMany(p => p.EmployeeEmailTbl)
                    .HasForeignKey(d => d.EmailTypeId)
                    .HasConstraintName("FK_Employee_Email_Tbl_Email_Type_Tbl");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeEmailTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Employee_Email_Tbl_Employee_Tbl");
            });

            modelBuilder.Entity<EmployeeFeesTbl>(entity =>
            {
                entity.HasKey(e => e.EmployeeFeesId);

                entity.ToTable("Employee_Fees_Tbl");

                entity.Property(e => e.EmployeeFeesId).HasColumnName("Employee_Fees_ID");

                entity.Property(e => e.BaladyaCard).HasColumnName("Baladya_Card");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.HealthInsurance).HasColumnName("Health_Insurance");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.LifeInsurance).HasColumnName("Life_Insurance");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.SchoolFees).HasColumnName("School_Fees");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeFeesTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Employee_Fees_Tbl_Employee_Tbl");
            });

            modelBuilder.Entity<EmployeeGroupTbl>(entity =>
            {
                entity.HasKey(e => e.EmployeeGroupId)
                    .HasName("PK_Employee_Group_Tbl_1");

                entity.ToTable("Employee_Group_Tbl");

                entity.Property(e => e.EmployeeGroupId).HasColumnName("Employee_Group_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.GroupId).HasColumnName("Group_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeGroupTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Employee_Group_Tbl_Employee_Tbl");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.EmployeeGroupTbl)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_Employee_Group_Tbl_Group_Tbl");
            });

            modelBuilder.Entity<EmployeeLanguageTbl>(entity =>
            {
                entity.HasKey(e => e.EmployeeLanguageId);

                entity.ToTable("Employee_Language_Tbl");

                entity.Property(e => e.EmployeeLanguageId).HasColumnName("Employee_Language_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.LanguageId).HasColumnName("Language_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.ReadDegreeId).HasColumnName("Read_Degree_ID");

                entity.Property(e => e.SpeakDegreeId).HasColumnName("Speak_Degree_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.Property(e => e.WriteDegreeId).HasColumnName("Write_Degree_ID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeLanguageTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Employee_Language_Tbl_Employee_Tbl");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.EmployeeLanguageTbl)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_Employee_Language_Tbl_Language_Tbl");

                entity.HasOne(d => d.ReadDegree)
                    .WithMany(p => p.EmployeeLanguageTblReadDegree)
                    .HasForeignKey(d => d.ReadDegreeId)
                    .HasConstraintName("FK_Employee_Language_Tbl_Language_Degree_Tbl");

                entity.HasOne(d => d.SpeakDegree)
                    .WithMany(p => p.EmployeeLanguageTblSpeakDegree)
                    .HasForeignKey(d => d.SpeakDegreeId)
                    .HasConstraintName("FK_Employee_Language_Tbl_Language_Degree_Tbl2");

                entity.HasOne(d => d.WriteDegree)
                    .WithMany(p => p.EmployeeLanguageTblWriteDegree)
                    .HasForeignKey(d => d.WriteDegreeId)
                    .HasConstraintName("FK_Employee_Language_Tbl_Language_Degree_Tbl1");
            });

            modelBuilder.Entity<EmployeeMonthlySalaryTbl>(entity =>
            {
                entity.HasKey(e => e.EmployeeMonthlySalaryId);

                entity.ToTable("Employee_Monthly_Salary_Tbl");

                entity.Property(e => e.EmployeeMonthlySalaryId).HasColumnName("Employee_Monthly_Salary_ID");

                entity.Property(e => e.ActiveYn).HasColumnName("Active_YN");

                entity.Property(e => e.AdditionalPaymentsTax).HasColumnName("Additional_Payments_Tax");

                entity.Property(e => e.AverageServiceChargeInPastYearAmount).HasColumnName("Average_Service_Charge_In_Past_Year_Amount");

                entity.Property(e => e.BonusTax).HasColumnName("Bonus_Tax");

                entity.Property(e => e.CompanyDefrayInsuranceYn).HasColumnName("Company_Defray_Insurance_YN");

                entity.Property(e => e.CompanyFixedHealthInsurance).HasColumnName("Company_Fixed_Health_Insurance");

                entity.Property(e => e.CompanyFixedInsurance).HasColumnName("Company_Fixed_Insurance");

                entity.Property(e => e.CompanyVariableHealthInsurance).HasColumnName("Company_Variable_Health_Insurance");

                entity.Property(e => e.CompanyVariableInsurance).HasColumnName("Company_Variable_Insurance");

                entity.Property(e => e.CurrencyId).HasColumnName("Currency_ID");

                entity.Property(e => e.DepartmentId).HasColumnName("Department_ID");

                entity.Property(e => e.DifferenceTax).HasColumnName("Difference_Tax");

                entity.Property(e => e.DivisionId).HasColumnName("Division_ID");

                entity.Property(e => e.EmployeeFixedHealthInsurance).HasColumnName("Employee_Fixed_Health_Insurance");

                entity.Property(e => e.EmployeeFixedHealthInsuranceByCurrency).HasColumnName("Employee_Fixed_Health_Insurance_By_Currency");

                entity.Property(e => e.EmployeeFixedInsurance).HasColumnName("Employee_Fixed_Insurance");

                entity.Property(e => e.EmployeeFixedInsuranceByCurrency).HasColumnName("Employee_Fixed_Insurance_By_Currency");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.EmployeeStatusId).HasColumnName("Employee_Status_ID");

                entity.Property(e => e.EmployeeVariableHealthInsurance).HasColumnName("Employee_Variable_Health_Insurance");

                entity.Property(e => e.EmployeeVariableHealthInsuranceByCurrency).HasColumnName("Employee_Variable_Health_Insurance_By_Currency");

                entity.Property(e => e.EmployeeVariableInsurance).HasColumnName("Employee_Variable_Insurance");

                entity.Property(e => e.EmployeeVariableInsuranceByCurrency).HasColumnName("Employee_Variable_Insurance_By_Currency");

                entity.Property(e => e.FixedInsuranceAmount).HasColumnName("Fixed_Insurance_Amount");

                entity.Property(e => e.InsuranceAdjustment).HasColumnName("Insurance_Adjustment");

                entity.Property(e => e.InsuranceRuleId).HasColumnName("Insurance_Rule_ID");

                entity.Property(e => e.InsuranceYn).HasColumnName("Insurance_YN");

                entity.Property(e => e.LifeInsuranceAmount).HasColumnName("Life_Insurance_Amount");

                entity.Property(e => e.LifeInsuranceYn).HasColumnName("Life_Insurance_YN");

                entity.Property(e => e.MaritalStatusId).HasColumnName("Marital_Status_ID");

                entity.Property(e => e.NetSalary).HasColumnName("Net_Salary");

                entity.Property(e => e.PositionId).HasColumnName("Position_ID");

                entity.Property(e => e.ProfitTax).HasColumnName("Profit_Tax");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.SalaryCalculationWayId).HasColumnName("Salary_Calculation_Way_ID");

                entity.Property(e => e.SalaryTax).HasColumnName("Salary_Tax");

                entity.Property(e => e.SectionId).HasColumnName("Section_ID");

                entity.Property(e => e.ServiceChargeStatusId).HasColumnName("Service_Charge_Status_ID");

                entity.Property(e => e.SpecialExcemption).HasColumnName("Special_Excemption");

                entity.Property(e => e.TaxAdjustment).HasColumnName("Tax_Adjustment");

                entity.Property(e => e.TaxExcemption).HasColumnName("Tax_Excemption");

                entity.Property(e => e.TaxPool).HasColumnName("Tax_Pool");

                entity.Property(e => e.TaxRuleId).HasColumnName("Tax_Rule_ID");

                entity.Property(e => e.TheMonth).HasColumnName("The_Month");

                entity.Property(e => e.TheYear).HasColumnName("The_Year");

                entity.Property(e => e.TotalCompanyInsurance).HasColumnName("Total_Company_Insurance");

                entity.Property(e => e.TotalDeductions).HasColumnName("Total_Deductions");

                entity.Property(e => e.TotalEmployeeInsurance).HasColumnName("Total_Employee_Insurance");

                entity.Property(e => e.TotalEmployeeInsuranceByCurrency).HasColumnName("Total_Employee_Insurance_By_Currency");

                entity.Property(e => e.TotalLoans).HasColumnName("Total_Loans");

                entity.Property(e => e.TotalPayments).HasColumnName("Total_Payments");

                entity.Property(e => e.TotalTaxableDeductions).HasColumnName("Total_Taxable_Deductions");

                entity.Property(e => e.TotalTaxablePayments).HasColumnName("Total_Taxable_Payments");

                entity.Property(e => e.VariableInsuranceAmount).HasColumnName("Variable_Insurance_Amount");

                entity.Property(e => e.WorkInGovernmentTypeId).HasColumnName("Work_In_Government_Type_ID");

                entity.Property(e => e.WorkingDays).HasColumnName("Working_Days");

                entity.Property(e => e.WorkingHours).HasColumnName("Working_Hours");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.EmployeeMonthlySalaryTbl)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_Employee_Monthly_Salary_Tbl_Currency_Tbl");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.EmployeeMonthlySalaryTbl)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_Employee_Monthly_Salary_Tbl_Department_Tbl");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.EmployeeMonthlySalaryTbl)
                    .HasForeignKey(d => d.DivisionId)
                    .HasConstraintName("FK_Employee_Monthly_Salary_Tbl_Division_Tbl");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeMonthlySalaryTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Employee_Monthly_Salary_Tbl_Employee_Tbl");

                entity.HasOne(d => d.InsuranceRule)
                    .WithMany(p => p.EmployeeMonthlySalaryTbl)
                    .HasForeignKey(d => d.InsuranceRuleId)
                    .HasConstraintName("FK_Employee_Monthly_Salary_Tbl_Insurance_Rule_Tbl");

                entity.HasOne(d => d.MaritalStatus)
                    .WithMany(p => p.EmployeeMonthlySalaryTbl)
                    .HasForeignKey(d => d.MaritalStatusId)
                    .HasConstraintName("FK_Employee_Monthly_Salary_Tbl_Marital_Status_Tbl");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.EmployeeMonthlySalaryTbl)
                    .HasForeignKey(d => d.PositionId)
                    .HasConstraintName("FK_Employee_Monthly_Salary_Tbl_Position_Tbl");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.EmployeeMonthlySalaryTbl)
                    .HasForeignKey(d => d.PropertyId)
                    .HasConstraintName("FK_Employee_Monthly_Salary_Tbl_Property_Tbl");

                entity.HasOne(d => d.SalaryCalculationWay)
                    .WithMany(p => p.EmployeeMonthlySalaryTbl)
                    .HasForeignKey(d => d.SalaryCalculationWayId)
                    .HasConstraintName("FK_Employee_Monthly_Salary_Tbl_Salary_Calculation_Way_Tbl");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.EmployeeMonthlySalaryTbl)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_Employee_Monthly_Salary_Tbl_Section_Tbl");

                entity.HasOne(d => d.ServiceChargeStatus)
                    .WithMany(p => p.EmployeeMonthlySalaryTbl)
                    .HasForeignKey(d => d.ServiceChargeStatusId)
                    .HasConstraintName("FK_Employee_Monthly_Salary_Tbl_Service_Charge_Status_Tbl");

                entity.HasOne(d => d.TaxRule)
                    .WithMany(p => p.EmployeeMonthlySalaryTbl)
                    .HasForeignKey(d => d.TaxRuleId)
                    .HasConstraintName("FK_Employee_Monthly_Salary_Tbl_Tax_Rule_Tbl");

                entity.HasOne(d => d.WorkInGovernmentType)
                    .WithMany(p => p.EmployeeMonthlySalaryTbl)
                    .HasForeignKey(d => d.WorkInGovernmentTypeId)
                    .HasConstraintName("FK_Employee_Monthly_Salary_Tbl_Work_In_Government_Type_Tbl");
            });

            modelBuilder.Entity<EmployeePaymentModeTbl>(entity =>
            {
                entity.HasKey(e => e.EmployeePaymentModeId);

                entity.ToTable("Employee_Payment_Mode_Tbl");

                entity.Property(e => e.EmployeePaymentModeId).HasColumnName("Employee_Payment_Mode_ID");

                entity.Property(e => e.BankAccountNumber)
                    .HasColumnName("Bank_Account_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.BankBranchNumber)
                    .HasColumnName("Bank_Branch_Number")
                    .HasMaxLength(10);

                entity.Property(e => e.BankEmployeeNumber)
                    .HasColumnName("Bank_Employee_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.BankId).HasColumnName("Bank_ID");

                entity.Property(e => e.CurrencyId).HasColumnName("Currency_ID");

                entity.Property(e => e.DefaultYn).HasColumnName("Default_YN");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PaymentFunctionId).HasColumnName("Payment_Function_ID");

                entity.Property(e => e.PaymentModeTypeId).HasColumnName("Payment_Mode_Type_ID");

                entity.Property(e => e.PaymentModeValue).HasColumnName("Payment_Mode_Value");

                entity.Property(e => e.ShowInWbsYn).HasColumnName("Show_In_WBS_YN");

                entity.Property(e => e.TheMonth).HasColumnName("The_Month");

                entity.Property(e => e.TheYear).HasColumnName("The_Year");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.EmployeePaymentModeTbl)
                    .HasForeignKey(d => d.BankId)
                    .HasConstraintName("FK_Employee_Payment_Mode_Tbl_Bank_Tbl");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.EmployeePaymentModeTbl)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_Employee_Payment_Mode_Tbl_Currency_Tbl");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeePaymentModeTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Employee_Payment_Mode_Tbl_Employee_Tbl1");

                entity.HasOne(d => d.PaymentFunction)
                    .WithMany(p => p.EmployeePaymentModeTbl)
                    .HasForeignKey(d => d.PaymentFunctionId)
                    .HasConstraintName("FK_Employee_Payment_Mode_Tbl_Payment_Function_Tbl");

                entity.HasOne(d => d.PaymentModeType)
                    .WithMany(p => p.EmployeePaymentModeTbl)
                    .HasForeignKey(d => d.PaymentModeTypeId)
                    .HasConstraintName("FK_Employee_Payment_Mode_Tbl_Payment_Mode_Type_Tbl");
            });

            modelBuilder.Entity<EmployeePaymentsReportTbl>(entity =>
            {
                entity.HasKey(e => e.EmployeePaymentsReportId);

                entity.ToTable("Employee_Payments_Report_Tbl");

                entity.Property(e => e.EmployeePaymentsReportId).HasColumnName("Employee_Payments_Report_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.Payment10Value).HasColumnName("Payment_10_Value");

                entity.Property(e => e.Payment11Value).HasColumnName("Payment_11_Value");

                entity.Property(e => e.Payment12Value).HasColumnName("Payment_12_Value");

                entity.Property(e => e.Payment13Value).HasColumnName("Payment_13_Value");

                entity.Property(e => e.Payment14Value).HasColumnName("Payment_14_Value");

                entity.Property(e => e.Payment15Value).HasColumnName("Payment_15_Value");

                entity.Property(e => e.Payment16Value).HasColumnName("Payment_16_Value");

                entity.Property(e => e.Payment17Value).HasColumnName("Payment_17_Value");

                entity.Property(e => e.Payment18Value).HasColumnName("Payment_18_Value");

                entity.Property(e => e.Payment19Value).HasColumnName("Payment_19_Value");

                entity.Property(e => e.Payment1Value).HasColumnName("Payment_1_Value");

                entity.Property(e => e.Payment20Value).HasColumnName("Payment_20_Value");

                entity.Property(e => e.Payment21Value).HasColumnName("Payment_21_Value");

                entity.Property(e => e.Payment22Value).HasColumnName("Payment_22_Value");

                entity.Property(e => e.Payment23Value).HasColumnName("Payment_23_Value");

                entity.Property(e => e.Payment24Value).HasColumnName("Payment_24_Value");

                entity.Property(e => e.Payment25Value).HasColumnName("Payment_25_Value");

                entity.Property(e => e.Payment26Value).HasColumnName("Payment_26_Value");

                entity.Property(e => e.Payment27Value).HasColumnName("Payment_27_Value");

                entity.Property(e => e.Payment28Value).HasColumnName("Payment_28_Value");

                entity.Property(e => e.Payment29Value).HasColumnName("Payment_29_Value");

                entity.Property(e => e.Payment2Value).HasColumnName("Payment_2_Value");

                entity.Property(e => e.Payment30Value).HasColumnName("Payment_30_Value");

                entity.Property(e => e.Payment3Value).HasColumnName("Payment_3_Value");

                entity.Property(e => e.Payment4Value).HasColumnName("Payment_4_Value");

                entity.Property(e => e.Payment5Value).HasColumnName("Payment_5_Value");

                entity.Property(e => e.Payment6Value).HasColumnName("Payment_6_Value");

                entity.Property(e => e.Payment7Value).HasColumnName("Payment_7_Value");

                entity.Property(e => e.Payment8Value).HasColumnName("Payment_8_Value");

                entity.Property(e => e.Payment9Value).HasColumnName("Payment_9_Value");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.TotalPayments).HasColumnName("Total_Payments");

                entity.Property(e => e.UserId).HasColumnName("User_ID");
            });

            modelBuilder.Entity<EmployeeQualificationTbl>(entity =>
            {
                entity.HasKey(e => e.EmployeeQualificationId);

                entity.ToTable("Employee_Qualification_Tbl");

                entity.Property(e => e.EmployeeQualificationId).HasColumnName("Employee_Qualification_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FacultyId).HasColumnName("Faculty_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.QualificationGradeId).HasColumnName("Qualification_Grade_ID");

                entity.Property(e => e.QualificationId).HasColumnName("Qualification_ID");

                entity.Property(e => e.QualificationNotes)
                    .HasColumnName("Qualification_Notes")
                    .HasMaxLength(100);

                entity.Property(e => e.QualificationYear).HasColumnName("Qualification_Year");

                entity.Property(e => e.Specialty).HasMaxLength(50);

                entity.Property(e => e.UniversityId).HasColumnName("University_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.Property(e => e.WorkingLicenseNumber)
                    .HasColumnName("Working_License_Number")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeQualificationTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Employee_Qualification_Tbl_Employee_Tbl");

                entity.HasOne(d => d.Faculty)
                    .WithMany(p => p.EmployeeQualificationTbl)
                    .HasForeignKey(d => d.FacultyId)
                    .HasConstraintName("FK_Employee_Qualification_Tbl_Faculty_Tbl");

                entity.HasOne(d => d.QualificationGrade)
                    .WithMany(p => p.EmployeeQualificationTbl)
                    .HasForeignKey(d => d.QualificationGradeId)
                    .HasConstraintName("FK_Employee_Qualification_Tbl_Qualification_Grade_Tbl");

                entity.HasOne(d => d.Qualification)
                    .WithMany(p => p.EmployeeQualificationTbl)
                    .HasForeignKey(d => d.QualificationId)
                    .HasConstraintName("FK_Employee_Qualification_Tbl_Qualification_Tbl");

                entity.HasOne(d => d.University)
                    .WithMany(p => p.EmployeeQualificationTbl)
                    .HasForeignKey(d => d.UniversityId)
                    .HasConstraintName("FK_Employee_Qualification_Tbl_University_Tbl");
            });

            modelBuilder.Entity<EmployeeRelativeTbl>(entity =>
            {
                entity.HasKey(e => e.EmployeeRelativeId);

                entity.ToTable("Employee_Relative_Tbl");

                entity.Property(e => e.EmployeeRelativeId).HasColumnName("Employee_Relative_ID");

                entity.Property(e => e.AddressAr)
                    .HasColumnName("Address_Ar")
                    .HasMaxLength(100);

                entity.Property(e => e.AddressEn)
                    .HasColumnName("Address_En")
                    .HasMaxLength(100);

                entity.Property(e => e.Birthdate).HasColumnType("date");

                entity.Property(e => e.BusinessEmail)
                    .HasColumnName("Business_Email")
                    .HasMaxLength(50);

                entity.Property(e => e.CivilIdExpireDate)
                    .HasColumnName("Civil_ID_Expire_Date")
                    .HasColumnType("date");

                entity.Property(e => e.CivilIdIssueDate)
                    .HasColumnName("Civil_ID_Issue_Date")
                    .HasColumnType("date");

                entity.Property(e => e.CivilIdNumber)
                    .HasColumnName("Civil_ID_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.CivilIdTypeId).HasColumnName("Civil_ID_Type_ID");

                entity.Property(e => e.CountryId).HasColumnName("Country_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.EmployeeIsSponsorYn).HasColumnName("Employee_Is_Sponsor_YN");

                entity.Property(e => e.FirstArName)
                    .HasColumnName("First_Ar_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.FirstEnName)
                    .HasColumnName("First_En_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.ForeignerYn).HasColumnName("Foreigner_YN");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.FullArName)
                    .HasColumnName("Full_Ar_Name")
                    .HasMaxLength(150);

                entity.Property(e => e.FullEnName)
                    .HasColumnName("Full_En_Name")
                    .HasMaxLength(150);

                entity.Property(e => e.GenderId).HasColumnName("Gender_ID");

                entity.Property(e => e.GovernorateId).HasColumnName("Governorate_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.InternalEmployeeYn).HasColumnName("Internal_Employee_YN");

                entity.Property(e => e.LastArName)
                    .HasColumnName("Last_Ar_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.LastEnName)
                    .HasColumnName("Last_En_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.MaritalStatusId).HasColumnName("Marital_Status_ID");

                entity.Property(e => e.MiddleArName)
                    .HasColumnName("Middle_Ar_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.MiddleEnName)
                    .HasColumnName("Middle_En_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.NationalityId).HasColumnName("Nationality_ID");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.PassportExpireDate)
                    .HasColumnName("Passport_Expire_Date")
                    .HasColumnType("date");

                entity.Property(e => e.PassportIssueDate)
                    .HasColumnName("Passport_Issue_Date")
                    .HasColumnType("date");

                entity.Property(e => e.PassportIssuePlace)
                    .HasColumnName("Passport_Issue_Place")
                    .HasMaxLength(50);

                entity.Property(e => e.PassportNumber)
                    .HasColumnName("Passport_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.PersonalEmail)
                    .HasColumnName("Personal_Email")
                    .HasMaxLength(50);

                entity.Property(e => e.Position).HasMaxLength(100);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("Postal_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PrefixId).HasColumnName("Prefix_ID");

                entity.Property(e => e.RelatedEmployeeId).HasColumnName("Related_Employee_ID");

                entity.Property(e => e.RelativeDegreeId).HasColumnName("Relative_Degree_ID");

                entity.Property(e => e.ReligionId).HasColumnName("Religion_ID");

                entity.Property(e => e.ResidencyExpireDate)
                    .HasColumnName("Residency_Expire_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ResidencyIssueDate)
                    .HasColumnName("Residency_Issue_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ResidencyIssuePlace)
                    .HasColumnName("Residency_Issue_Place")
                    .HasMaxLength(50);

                entity.Property(e => e.ResidencyNumber)
                    .HasColumnName("Residency_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.ResidencyTypeId).HasColumnName("Residency_Type_ID");

                entity.Property(e => e.ShadowArName)
                    .HasColumnName("Shadow_Ar_Name")
                    .HasMaxLength(150);

                entity.Property(e => e.SponsorId).HasColumnName("Sponsor_ID");

                entity.Property(e => e.Telephone).HasMaxLength(50);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.CivilIdType)
                    .WithMany(p => p.EmployeeRelativeTbl)
                    .HasForeignKey(d => d.CivilIdTypeId)
                    .HasConstraintName("FK_Employee_Relative_Tbl_Civil_ID_Type_Tbl");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.EmployeeRelativeTbl)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Employee_Relative_Tbl_Country_Tbl");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeRelativeTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Employee_Relative_Tbl_Employee_Tbl1");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.EmployeeRelativeTbl)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK_Employee_Relative_Tbl_Gender_Tbl");

                entity.HasOne(d => d.Governorate)
                    .WithMany(p => p.EmployeeRelativeTbl)
                    .HasForeignKey(d => d.GovernorateId)
                    .HasConstraintName("FK_Employee_Relative_Tbl_Governorate_Tbl");

                entity.HasOne(d => d.MaritalStatus)
                    .WithMany(p => p.EmployeeRelativeTbl)
                    .HasForeignKey(d => d.MaritalStatusId)
                    .HasConstraintName("FK_Employee_Relative_Tbl_Marital_Status_Tbl");

                entity.HasOne(d => d.Nationality)
                    .WithMany(p => p.EmployeeRelativeTbl)
                    .HasForeignKey(d => d.NationalityId)
                    .HasConstraintName("FK_Employee_Relative_Tbl_Nationality_Tbl");

                entity.HasOne(d => d.Prefix)
                    .WithMany(p => p.EmployeeRelativeTbl)
                    .HasForeignKey(d => d.PrefixId)
                    .HasConstraintName("FK_Employee_Relative_Tbl_Prefix_Tbl");

                entity.HasOne(d => d.RelativeDegree)
                    .WithMany(p => p.EmployeeRelativeTbl)
                    .HasForeignKey(d => d.RelativeDegreeId)
                    .HasConstraintName("FK_Employee_Relative_Tbl_Relative_Degree_Tbl");

                entity.HasOne(d => d.Religion)
                    .WithMany(p => p.EmployeeRelativeTbl)
                    .HasForeignKey(d => d.ReligionId)
                    .HasConstraintName("FK_Employee_Relative_Tbl_Religion_Tbl");

                entity.HasOne(d => d.ResidencyType)
                    .WithMany(p => p.EmployeeRelativeTbl)
                    .HasForeignKey(d => d.ResidencyTypeId)
                    .HasConstraintName("FK_Employee_Relative_Tbl_Residency_Type_Tbl");

                entity.HasOne(d => d.Sponsor)
                    .WithMany(p => p.EmployeeRelativeTbl)
                    .HasForeignKey(d => d.SponsorId)
                    .HasConstraintName("FK_Employee_Relative_Tbl_Sponsor_Tbl");
            });

            modelBuilder.Entity<EmployeeSharedPropertyTbl>(entity =>
            {
                entity.HasKey(e => e.EmployeeSharedPropertyId);

                entity.ToTable("Employee_Shared_Property_Tbl");

                entity.Property(e => e.EmployeeSharedPropertyId).HasColumnName("Employee_Shared_Property_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeSharedPropertyTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Employee_Shared_Property_Tbl_Employee_Tbl");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.EmployeeSharedPropertyTbl)
                    .HasForeignKey(d => d.PropertyId)
                    .HasConstraintName("FK_Employee_Shared_Property_Tbl_Property_Tbl");
            });

            modelBuilder.Entity<EmployeeStatusTbl>(entity =>
            {
                entity.HasKey(e => e.EmployeeStatusId);

                entity.ToTable("Employee_Status_Tbl");

                entity.Property(e => e.EmployeeStatusId).HasColumnName("Employee_Status_ID");

                entity.Property(e => e.EmployeeStatusArName)
                    .HasColumnName("Employee_Status_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.EmployeeStatusEnName)
                    .HasColumnName("Employee_Status_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<EmployeeTbl>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("Employee_Tbl");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.AboutEmployee)
                    .HasColumnName("About_Employee")
                    .HasMaxLength(200);

                entity.Property(e => e.AirplaneDestinationId).HasColumnName("Airplane_Destination_ID");

                entity.Property(e => e.AttendanceMachineClockNumber)
                    .HasColumnName("Attendance_Machine_Clock_Number")
                    .HasMaxLength(10);

                entity.Property(e => e.AttendanceMachineScheduleRuleId).HasColumnName("Attendance_Machine_Schedule_Rule_ID");

                entity.Property(e => e.BirthDate)
                    .HasColumnName("Birth_Date")
                    .HasColumnType("date");

                entity.Property(e => e.BirthPlace)
                    .HasColumnName("Birth_Place")
                    .HasMaxLength(50);

                entity.Property(e => e.BloodTypeId).HasColumnName("Blood_Type_ID");

                entity.Property(e => e.BusWayId).HasColumnName("Bus_Way_ID");

                entity.Property(e => e.ChildrenYearlyTicketsDue).HasColumnName("Children_Yearly_Tickets_Due");

                entity.Property(e => e.CivilIdExpireDate)
                    .HasColumnName("Civil_ID_Expire_Date")
                    .HasColumnType("date");

                entity.Property(e => e.CivilIdIssueDate)
                    .HasColumnName("Civil_ID_Issue_Date")
                    .HasColumnType("date");

                entity.Property(e => e.CivilIdNotes)
                    .HasColumnName("Civil_ID_Notes")
                    .HasMaxLength(100);

                entity.Property(e => e.CivilIdNumber)
                    .HasColumnName("Civil_ID_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.CivilIdTypeId).HasColumnName("Civil_ID_Type_ID");

                entity.Property(e => e.CompanyDefrayInsuranceYn).HasColumnName("Company_Defray_Insurance_YN");

                entity.Property(e => e.ContractExpireDate)
                    .HasColumnName("Contract_Expire_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ContractId).HasColumnName("Contract_ID");

                entity.Property(e => e.ContractIssueDate)
                    .HasColumnName("Contract_Issue_Date")
                    .HasColumnType("date");

                entity.Property(e => e.CreateLoginDetailYn).HasColumnName("Create_Login_Detail_YN");

                entity.Property(e => e.CurrencyId).HasColumnName("Currency_ID");

                entity.Property(e => e.DPaymentModeMonth).HasColumnName("D_Payment_Mode_Month");

                entity.Property(e => e.DPaymentModeYear).HasColumnName("D_Payment_Mode_Year");

                entity.Property(e => e.DailySalary).HasColumnName("Daily_Salary");

                entity.Property(e => e.DepartmentId).HasColumnName("Department_ID");

                entity.Property(e => e.DivisionId).HasColumnName("Division_ID");

                entity.Property(e => e.EmployeeCode)
                    .HasColumnName("Employee_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.EmployeePhoto)
                    .HasColumnName("Employee_Photo")
                    .HasMaxLength(200);

                entity.Property(e => e.EmployeePhotoFileName)
                    .HasColumnName("Employee_Photo_File_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.EmployeePhotoPath)
                    .HasColumnName("Employee_Photo_Path")
                    .HasMaxLength(200);

                entity.Property(e => e.EmployeeStatusId).HasColumnName("Employee_Status_ID");

                entity.Property(e => e.EmployeeYearlyTicketsDue).HasColumnName("Employee_Yearly_Tickets_Due");

                entity.Property(e => e.EmploymentTypeId).HasColumnName("Employment_Type_ID");

                entity.Property(e => e.FamilyYearlyTicketsDue).HasColumnName("Family_Yearly_Tickets_Due");

                entity.Property(e => e.FirstArName)
                    .HasColumnName("First_Ar_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.FirstEnName)
                    .HasColumnName("First_En_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.FirstHiringDateInTheChain)
                    .HasColumnName("First_Hiring_Date_In_The_Chain")
                    .HasColumnType("date");

                entity.Property(e => e.FirstInsuranceDate)
                    .HasColumnName("First_Insurance_Date")
                    .HasColumnType("date");

                entity.Property(e => e.FirstSalary).HasColumnName("First_Salary");

                entity.Property(e => e.FixedInsuranceValue).HasColumnName("Fixed_Insurance_Value");

                entity.Property(e => e.ForeignerYn).HasColumnName("Foreigner_YN");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.FullArName)
                    .HasColumnName("Full_Ar_Name")
                    .HasMaxLength(150);

                entity.Property(e => e.FullEnName)
                    .HasColumnName("Full_En_Name")
                    .HasMaxLength(150);

                entity.Property(e => e.GenderId).HasColumnName("Gender_ID");

                entity.Property(e => e.GovernorateId).HasColumnName("Governorate_ID");

                entity.Property(e => e.GrossSalary).HasColumnName("Gross_Salary");

                entity.Property(e => e.HandicappedCertificateDate)
                    .HasColumnName("Handicapped_Certificate_Date")
                    .HasColumnType("date");

                entity.Property(e => e.HandicappedCertificateNumber)
                    .HasColumnName("Handicapped_Certificate_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.HandicappedLevelId).HasColumnName("Handicapped_Level_ID");

                entity.Property(e => e.HandicappedNotes)
                    .HasColumnName("Handicapped_Notes")
                    .HasMaxLength(100);

                entity.Property(e => e.HandicappedTypeId).HasColumnName("Handicapped_Type_ID");

                entity.Property(e => e.HandicappedYn).HasColumnName("Handicapped_YN");

                entity.Property(e => e.HasCarYn).HasColumnName("Has_Car_YN");

                entity.Property(e => e.HealthFitnessYn).HasColumnName("Health_Fitness_YN");

                entity.Property(e => e.HiringDate)
                    .HasColumnName("Hiring_Date")
                    .HasColumnType("date");

                entity.Property(e => e.HousingTypeId).HasColumnName("Housing_Type_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.InsuranceDate)
                    .HasColumnName("Insurance_Date")
                    .HasColumnType("date");

                entity.Property(e => e.InsuranceNotes)
                    .HasColumnName("Insurance_Notes")
                    .HasMaxLength(100);

                entity.Property(e => e.InsuranceNumber)
                    .HasColumnName("Insurance_Number")
                    .HasMaxLength(10);

                entity.Property(e => e.InsuranceOfficeId).HasColumnName("Insurance_Office_ID");

                entity.Property(e => e.InsuranceRuleId).HasColumnName("Insurance_Rule_ID");

                entity.Property(e => e.InsuranceYn).HasColumnName("Insurance_YN");

                entity.Property(e => e.LastArName)
                    .HasColumnName("Last_Ar_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.LastEnName)
                    .HasColumnName("Last_En_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.LifeInsuranceAnnualValue).HasColumnName("Life_Insurance_Annual_Value");

                entity.Property(e => e.LifeInsuranceYn).HasColumnName("Life_Insurance_YN");

                entity.Property(e => e.LoginPassword).HasColumnName("Login_Password");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.ManagerYn).HasColumnName("Manager_YN");

                entity.Property(e => e.ManyCostCenterYn).HasColumnName("Many_Cost_Center_YN");

                entity.Property(e => e.MaritalStatusId).HasColumnName("Marital_Status_ID");

                entity.Property(e => e.MaritalStatusNotes)
                    .HasColumnName("Marital_Status_Notes")
                    .HasMaxLength(100);

                entity.Property(e => e.MiddleArName)
                    .HasColumnName("Middle_Ar_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.MiddleEnName)
                    .HasColumnName("Middle_En_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.MilitaryExpireDate)
                    .HasColumnName("Military_Expire_Date")
                    .HasColumnType("date");

                entity.Property(e => e.MilitaryIssueDate)
                    .HasColumnName("Military_Issue_Date")
                    .HasColumnType("date");

                entity.Property(e => e.MilitaryLocation)
                    .HasColumnName("Military_Location")
                    .HasMaxLength(50);

                entity.Property(e => e.MilitaryNotes)
                    .HasColumnName("Military_Notes")
                    .HasMaxLength(100);

                entity.Property(e => e.MilitaryNumber)
                    .HasColumnName("Military_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.MilitaryStatusId).HasColumnName("Military_Status_ID");

                entity.Property(e => e.NationalityId).HasColumnName("Nationality_ID");

                entity.Property(e => e.NationalityNotes)
                    .HasColumnName("Nationality_Notes")
                    .HasMaxLength(100);

                entity.Property(e => e.NumberOfChildren).HasColumnName("Number_Of_Children");

                entity.Property(e => e.Office).HasMaxLength(50);

                entity.Property(e => e.OrganizationLegalFormId).HasColumnName("Organization_Legal_Form_ID");

                entity.Property(e => e.PassportExpireDate)
                    .HasColumnName("Passport_Expire_Date")
                    .HasColumnType("date");

                entity.Property(e => e.PassportIssueDate)
                    .HasColumnName("Passport_Issue_Date")
                    .HasColumnType("date");

                entity.Property(e => e.PassportIssuePlace)
                    .HasColumnName("Passport_Issue_Place")
                    .HasMaxLength(50);

                entity.Property(e => e.PassportNumber)
                    .HasColumnName("Passport_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.PositionId).HasColumnName("Position_ID");

                entity.Property(e => e.PrefixId).HasColumnName("Prefix_ID");

                entity.Property(e => e.PreviousInsuranceMonths).HasColumnName("Previous_Insurance_Months");

                entity.Property(e => e.ProbationPeriodExpireDate)
                    .HasColumnName("Probation_Period_Expire_Date")
                    .HasColumnType("date");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.ReligionId).HasColumnName("Religion_ID");

                entity.Property(e => e.ResidencyExpireDate)
                    .HasColumnName("Residency_Expire_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ResidencyIssueDate)
                    .HasColumnName("Residency_Issue_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ResidencyIssuePlace)
                    .HasColumnName("Residency_Issue_Place")
                    .HasMaxLength(50);

                entity.Property(e => e.ResidencyNotes)
                    .HasColumnName("Residency_Notes")
                    .HasMaxLength(100);

                entity.Property(e => e.ResidencyNumber)
                    .HasColumnName("Residency_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.ResidencyTypeId).HasColumnName("Residency_Type_ID");

                entity.Property(e => e.SalaryCalculationWayId).HasColumnName("Salary_Calculation_Way_ID");

                entity.Property(e => e.SectionId).HasColumnName("Section_ID");

                entity.Property(e => e.SecurityLevelId).HasColumnName("Security_Level_ID");

                entity.Property(e => e.ShadowArName)
                    .HasColumnName("Shadow_Ar_Name")
                    .HasMaxLength(150);

                entity.Property(e => e.SharedEmployeeYn)
                    .HasColumnName("Shared_Employee_YN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SharedHousingYn).HasColumnName("Shared_Housing_YN");

                entity.Property(e => e.SponsorId).HasColumnName("Sponsor_ID");

                entity.Property(e => e.TaxRuleId).HasColumnName("Tax_Rule_ID");

                entity.Property(e => e.TerminationDate)
                    .HasColumnName("Termination_Date")
                    .HasColumnType("date");

                entity.Property(e => e.TicketsPerTwoYearsYn).HasColumnName("Tickets_Per_Two_Years_YN");

                entity.Property(e => e.TransportationTypeId).HasColumnName("Transportation_Type_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.Property(e => e.VacationRuleId).HasColumnName("Vacation_Rule_ID");

                entity.Property(e => e.VariableInsuranceValue).HasColumnName("Variable_Insurance_Value");

                entity.Property(e => e.WorkInGovernmentTypeId).HasColumnName("Work_In_Government_Type_ID");

                entity.HasOne(d => d.AirplaneDestination)
                    .WithMany(p => p.EmployeeTbl)
                    .HasForeignKey(d => d.AirplaneDestinationId)
                    .HasConstraintName("FK_Employee_Tbl_Airplane_Destination_Tbl");

                entity.HasOne(d => d.AttendanceMachineScheduleRule)
                    .WithMany(p => p.EmployeeTbl)
                    .HasForeignKey(d => d.AttendanceMachineScheduleRuleId)
                    .HasConstraintName("FK_Employee_Tbl_Attendance_Rule_Tbl");

                entity.HasOne(d => d.BloodType)
                    .WithMany(p => p.EmployeeTbl)
                    .HasForeignKey(d => d.BloodTypeId)
                    .HasConstraintName("FK_Employee_Tbl_Blood_Type_Tbl");

                entity.HasOne(d => d.BusWay)
                    .WithMany(p => p.EmployeeTbl)
                    .HasForeignKey(d => d.BusWayId)
                    .HasConstraintName("FK_Employee_Tbl_Bus_Way_Tbl");

                entity.HasOne(d => d.CivilIdType)
                    .WithMany(p => p.EmployeeTbl)
                    .HasForeignKey(d => d.CivilIdTypeId)
                    .HasConstraintName("FK_Employee_Tbl_Civil_ID_Type_Tbl");

                entity.HasOne(d => d.Contract)
                    .WithMany(p => p.EmployeeTbl)
                    .HasForeignKey(d => d.ContractId)
                    .HasConstraintName("FK_Employee_Tbl_Contract_Tbl");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.EmployeeTbl)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_Employee_Tbl_Currency_Tbl");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.EmployeeTbl)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_Employee_Tbl_Department_Tbl");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.EmployeeTbl)
                    .HasForeignKey(d => d.DivisionId)
                    .HasConstraintName("FK_Employee_Tbl_Division_Tbl");

                entity.HasOne(d => d.EmploymentType)
                    .WithMany(p => p.EmployeeTbl)
                    .HasForeignKey(d => d.EmploymentTypeId)
                    .HasConstraintName("FK_Employee_Tbl_Employment_Type_Tbl");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.EmployeeTbl)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK_Employee_Tbl_Gender_Tbl");

                entity.HasOne(d => d.Governorate)
                    .WithMany(p => p.EmployeeTbl)
                    .HasForeignKey(d => d.GovernorateId)
                    .HasConstraintName("FK_Employee_Tbl_Governorate_Tbl");

                entity.HasOne(d => d.HandicappedLevel)
                    .WithMany(p => p.EmployeeTbl)
                    .HasForeignKey(d => d.HandicappedLevelId)
                    .HasConstraintName("FK_Employee_Tbl_Handicapped_Level_Tbl");

                entity.HasOne(d => d.HandicappedType)
                    .WithMany(p => p.EmployeeTbl)
                    .HasForeignKey(d => d.HandicappedTypeId)
                    .HasConstraintName("FK_Employee_Tbl_Handicapped_Type_Tbl");

                entity.HasOne(d => d.HousingType)
                    .WithMany(p => p.EmployeeTbl)
                    .HasForeignKey(d => d.HousingTypeId)
                    .HasConstraintName("FK_Employee_Tbl_Housing_Type_Tbl");

                entity.HasOne(d => d.InsuranceOffice)
                    .WithMany(p => p.EmployeeTbl)
                    .HasForeignKey(d => d.InsuranceOfficeId)
                    .HasConstraintName("FK_Employee_Tbl_Insurance_Office_Tbl");

                entity.HasOne(d => d.InsuranceRule)
                    .WithMany(p => p.EmployeeTbl)
                    .HasForeignKey(d => d.InsuranceRuleId)
                    .HasConstraintName("FK_Employee_Tbl_Insurance_Rule_Tbl");

                entity.HasOne(d => d.MaritalStatus)
                    .WithMany(p => p.EmployeeTbl)
                    .HasForeignKey(d => d.MaritalStatusId)
                    .HasConstraintName("FK_Employee_Tbl_Marital_Status_Tbl");

                entity.HasOne(d => d.MilitaryStatus)
                    .WithMany(p => p.EmployeeTbl)
                    .HasForeignKey(d => d.MilitaryStatusId)
                    .HasConstraintName("FK_Employee_Tbl_Military_Status_Tbl");

                entity.HasOne(d => d.Nationality)
                    .WithMany(p => p.EmployeeTbl)
                    .HasForeignKey(d => d.NationalityId)
                    .HasConstraintName("FK_Employee_Tbl_Nationality_Tbl");

                entity.HasOne(d => d.OrganizationLegalForm)
                    .WithMany(p => p.EmployeeTbl)
                    .HasForeignKey(d => d.OrganizationLegalFormId)
                    .HasConstraintName("FK_Employee_Tbl_Organization_Legal_Form_Tbl");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.EmployeeTbl)
                    .HasForeignKey(d => d.PositionId)
                    .HasConstraintName("FK_Employee_Tbl_Position_Tbl");

                entity.HasOne(d => d.Prefix)
                    .WithMany(p => p.EmployeeTbl)
                    .HasForeignKey(d => d.PrefixId)
                    .HasConstraintName("FK_Employee_Tbl_Prefix_Tbl");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.EmployeeTbl)
                    .HasForeignKey(d => d.PropertyId)
                    .HasConstraintName("FK_Employee_Tbl_Property_Tbl");

                entity.HasOne(d => d.Religion)
                    .WithMany(p => p.EmployeeTbl)
                    .HasForeignKey(d => d.ReligionId)
                    .HasConstraintName("FK_Employee_Tbl_Religion_Tbl");

                entity.HasOne(d => d.ResidencyType)
                    .WithMany(p => p.EmployeeTbl)
                    .HasForeignKey(d => d.ResidencyTypeId)
                    .HasConstraintName("FK_Employee_Tbl_Residency_Type_Tbl");

                entity.HasOne(d => d.SalaryCalculationWay)
                    .WithMany(p => p.EmployeeTbl)
                    .HasForeignKey(d => d.SalaryCalculationWayId)
                    .HasConstraintName("FK_Employee_Tbl_Salary_Calculation_Way_Tbl");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.EmployeeTbl)
                    .HasForeignKey(d => d.SectionId)
                    .HasConstraintName("FK_Employee_Tbl_Section_Tbl");

                entity.HasOne(d => d.SecurityLevel)
                    .WithMany(p => p.EmployeeTbl)
                    .HasForeignKey(d => d.SecurityLevelId)
                    .HasConstraintName("FK_Employee_Tbl_Security_Level_Tbl");

                entity.HasOne(d => d.Sponsor)
                    .WithMany(p => p.EmployeeTbl)
                    .HasForeignKey(d => d.SponsorId)
                    .HasConstraintName("FK_Employee_Tbl_Sponsor_Tbl");

                entity.HasOne(d => d.TaxRule)
                    .WithMany(p => p.EmployeeTbl)
                    .HasForeignKey(d => d.TaxRuleId)
                    .HasConstraintName("FK_Employee_Tbl_Tax_Rule_Tbl");

                entity.HasOne(d => d.TransportationType)
                    .WithMany(p => p.EmployeeTbl)
                    .HasForeignKey(d => d.TransportationTypeId)
                    .HasConstraintName("FK_Employee_Tbl_Transportation_Type_Tbl");

                entity.HasOne(d => d.VacationRule)
                    .WithMany(p => p.EmployeeTbl)
                    .HasForeignKey(d => d.VacationRuleId)
                    .HasConstraintName("FK_Employee_Tbl_Vacation_Rule_Tbl");

                entity.HasOne(d => d.WorkInGovernmentType)
                    .WithMany(p => p.EmployeeTbl)
                    .HasForeignKey(d => d.WorkInGovernmentTypeId)
                    .HasConstraintName("FK_Employee_Tbl_Work_In_Government_Type_Tbl");
            });

            modelBuilder.Entity<EmployeeVacationBalanceTbl>(entity =>
            {
                entity.HasKey(e => e.EmployeeVacationBalanceId);

                entity.ToTable("Employee_Vacation_Balance_Tbl");

                entity.Property(e => e.EmployeeVacationBalanceId).HasColumnName("Employee_Vacation_Balance_ID");

                entity.Property(e => e.AnnualBalance).HasColumnName("Annual_Balance");

                entity.Property(e => e.AnnualConsumption).HasColumnName("Annual_Consumption");

                entity.Property(e => e.AnnualDueBalance).HasColumnName("Annual_Due_Balance");

                entity.Property(e => e.AnnualHolidayDeduction).HasColumnName("Annual_Holiday_Deduction");

                entity.Property(e => e.AnnualOpeningBalance).HasColumnName("Annual_Opening_Balance");

                entity.Property(e => e.AnnualOtherConsumption).HasColumnName("Annual_Other_Consumption");

                entity.Property(e => e.DayOffBalance).HasColumnName("Day_Off_Balance");

                entity.Property(e => e.DayOffConsumption).HasColumnName("Day_Off_Consumption");

                entity.Property(e => e.DayOffDueBalance).HasColumnName("Day_Off_Due_Balance");

                entity.Property(e => e.DayOffHolidayDeduction).HasColumnName("Day_Off_Holiday_Deduction");

                entity.Property(e => e.DayOffOpeningBalance).HasColumnName("Day_Off_Opening_Balance");

                entity.Property(e => e.DayOffOtherConsumption).HasColumnName("Day_Off_Other_Consumption");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.HolidayBalance).HasColumnName("Holiday_Balance");

                entity.Property(e => e.HolidayConsumption).HasColumnName("Holiday_Consumption");

                entity.Property(e => e.HolidayDueBalance).HasColumnName("Holiday_Due_Balance");

                entity.Property(e => e.HolidayHolidayDeduction).HasColumnName("Holiday_Holiday_Deduction");

                entity.Property(e => e.HolidayOpeningBalance).HasColumnName("Holiday_Opening_Balance");

                entity.Property(e => e.HolidayOtherConsumption).HasColumnName("Holiday_Other_Consumption");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.RemoteBalance).HasColumnName("Remote_Balance");

                entity.Property(e => e.RemoteConsumption).HasColumnName("Remote_Consumption");

                entity.Property(e => e.RemoteDueBalance).HasColumnName("Remote_Due_Balance");

                entity.Property(e => e.RemoteHolidayDeduction).HasColumnName("Remote_Holiday_Deduction");

                entity.Property(e => e.RemoteOpeningBalance).HasColumnName("Remote_Opening_Balance");

                entity.Property(e => e.RemoteOtherConsumption).HasColumnName("Remote_Other_Consumption");

                entity.Property(e => e.UserId).HasColumnName("User_ID");
            });

            modelBuilder.Entity<EmploymentTypeTbl>(entity =>
            {
                entity.HasKey(e => e.EmploymentTypeId);

                entity.ToTable("Employment_Type_Tbl");

                entity.Property(e => e.EmploymentTypeId).HasColumnName("Employment_Type_ID");

                entity.Property(e => e.EmploymentTypeArName)
                    .HasColumnName("Employment_Type_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.EmploymentTypeEnName)
                    .HasColumnName("Employment_Type_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<EosBenefitAccrualReportTbl>(entity =>
            {
                entity.HasKey(e => e.EosBenefitAccrualReportId);

                entity.ToTable("EOS_Benefit_Accrual_Report_Tbl");

                entity.Property(e => e.EosBenefitAccrualReportId).HasColumnName("EOS_Benefit_Accrual_Report_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.ServiceMonths).HasColumnName("Service_Months");

                entity.Property(e => e.ServiceYears).HasColumnName("Service_Years");

                entity.Property(e => e.TheAmount).HasColumnName("The_Amount");

                entity.Property(e => e.UserId).HasColumnName("User_ID");
            });

            modelBuilder.Entity<EosBenifitTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.EosBenifitTransactionId);

                entity.ToTable("EOS_Benifit_Transaction_Tbl");

                entity.Property(e => e.EosBenifitTransactionId).HasColumnName("EOS_Benifit_Transaction_ID");

                entity.Property(e => e.BenifitDate)
                    .HasColumnName("Benifit_Date")
                    .HasColumnType("date");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.EosRuleId).HasColumnName("EOS_Rule_ID");

                entity.Property(e => e.EosValue).HasColumnName("EOS_Value");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.NoneCompletedYearMonths).HasColumnName("None_Completed_Year_Months");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.PaidWithSalaryYn).HasColumnName("Paid_With_Salary_YN");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.ServiceYears).HasColumnName("Service_Years");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EosBenifitTransactionTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_EOS_Benifit_Transaction_Tbl_Employee_Tbl");

                entity.HasOne(d => d.EosRule)
                    .WithMany(p => p.EosBenifitTransactionTbl)
                    .HasForeignKey(d => d.EosRuleId)
                    .HasConstraintName("FK_EOS_Benifit_Transaction_Tbl_EOS_Rule_Tbl");
            });

            modelBuilder.Entity<EosRuleDetailsTbl>(entity =>
            {
                entity.HasKey(e => e.EosRuleDetailsId);

                entity.ToTable("EOS_Rule_Details_Tbl");

                entity.Property(e => e.EosRuleDetailsId).HasColumnName("EOS_Rule_Details_ID");

                entity.Property(e => e.EosRuleId).HasColumnName("EOS_Rule_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.ServiceYearsUpTo).HasColumnName("Service_Years_Up_To");

                entity.Property(e => e.SliceFormula).HasColumnName("Slice_Formula");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.EosRule)
                    .WithMany(p => p.EosRuleDetailsTbl)
                    .HasForeignKey(d => d.EosRuleId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_EOS_Rule_Details_Tbl_EOS_Rule_Tbl");
            });

            modelBuilder.Entity<EosRuleTbl>(entity =>
            {
                entity.HasKey(e => e.EosRuleId);

                entity.ToTable("EOS_Rule_Tbl");

                entity.Property(e => e.EosRuleId).HasColumnName("EOS_Rule_ID");

                entity.Property(e => e.ComputeNoneCompletedYearProportionallyYn).HasColumnName("Compute_None_Completed_Year_Proportionally_YN");

                entity.Property(e => e.EffectedPayments)
                    .HasColumnName("Effected_Payments")
                    .HasMaxLength(200);

                entity.Property(e => e.EosRuleArName)
                    .HasColumnName("EOS_Rule_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.EosRuleArNameShadow)
                    .HasColumnName("EOS_Rule_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.EosRuleCode)
                    .HasColumnName("EOS_Rule_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.EosRuleEnName)
                    .HasColumnName("EOS_Rule_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<ExpiredFieldTbl>(entity =>
            {
                entity.HasKey(e => e.ExpiredFieldId);

                entity.ToTable("Expired_Field_Tbl");

                entity.Property(e => e.ExpiredFieldId).HasColumnName("Expired_Field_ID");

                entity.Property(e => e.ExpiredFieldArName)
                    .HasColumnName("Expired_Field_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.ExpiredFieldEnName)
                    .HasColumnName("Expired_Field_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<FacultyTbl>(entity =>
            {
                entity.HasKey(e => e.FacultyId);

                entity.ToTable("Faculty_Tbl");

                entity.Property(e => e.FacultyId).HasColumnName("Faculty_ID");

                entity.Property(e => e.FacultyArName)
                    .HasColumnName("Faculty_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.FacultyArNameShadow)
                    .HasColumnName("Faculty_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.FacultyCode)
                    .HasColumnName("Faculty_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.FacultyEnName)
                    .HasColumnName("Faculty_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<GenderTbl>(entity =>
            {
                entity.HasKey(e => e.GenderId);

                entity.ToTable("Gender_Tbl");

                entity.Property(e => e.GenderId).HasColumnName("Gender_ID");

                entity.Property(e => e.GenderArName)
                    .HasColumnName("Gender_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.GenderEnName)
                    .HasColumnName("Gender_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<GovernorateTbl>(entity =>
            {
                entity.HasKey(e => e.GovernorateId);

                entity.ToTable("Governorate_Tbl");

                entity.Property(e => e.GovernorateId).HasColumnName("Governorate_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.GovernorateArName)
                    .HasColumnName("Governorate_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.GovernorateArNameShadow)
                    .HasColumnName("Governorate_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.GovernorateCode)
                    .HasColumnName("Governorate_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.GovernorateEnName)
                    .HasColumnName("Governorate_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<GradeTbl>(entity =>
            {
                entity.HasKey(e => e.GradeId);

                entity.ToTable("Grade_Tbl");

                entity.Property(e => e.GradeId).HasColumnName("Grade_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.GradeArName)
                    .HasColumnName("Grade_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.GradeArNameShadow)
                    .HasColumnName("Grade_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.GradeCode)
                    .HasColumnName("Grade_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.GradeCostCenter)
                    .HasColumnName("Grade_Cost_Center")
                    .HasMaxLength(20);

                entity.Property(e => e.GradeEnName)
                    .HasColumnName("Grade_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.IncentiveStaff).HasColumnName("Incentive_Staff");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PensionSchemeRate).HasColumnName("Pension_Scheme_Rate");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.TicketsNumber).HasColumnName("Tickets_Number");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<GroupTbl>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .HasName("PK_Employee_Group_Tbl");

                entity.ToTable("Group_Tbl");

                entity.Property(e => e.GroupId).HasColumnName("Group_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.GroupArName)
                    .HasColumnName("Group_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.GroupArNameShadow)
                    .HasColumnName("Group_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.GroupCode)
                    .HasColumnName("Group_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.GroupEnName)
                    .HasColumnName("Group_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<HandicappedLevelTbl>(entity =>
            {
                entity.HasKey(e => e.HandicappedLevelId);

                entity.ToTable("Handicapped_Level_Tbl");

                entity.Property(e => e.HandicappedLevelId).HasColumnName("Handicapped_Level_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.HandicappedLevelArName)
                    .HasColumnName("Handicapped_Level_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.HandicappedLevelArNameShadow)
                    .HasColumnName("Handicapped_Level_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.HandicappedLevelCode)
                    .HasColumnName("Handicapped_Level_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.HandicappedLevelEnName)
                    .HasColumnName("Handicapped_Level_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<HandicappedTypeTbl>(entity =>
            {
                entity.HasKey(e => e.HandicappedTypeId);

                entity.ToTable("Handicapped_Type_Tbl");

                entity.Property(e => e.HandicappedTypeId).HasColumnName("Handicapped_Type_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.HandicappedTypeArName)
                    .HasColumnName("Handicapped_Type_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.HandicappedTypeArNameShadow)
                    .HasColumnName("Handicapped_Type_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.HandicappedTypeCode)
                    .HasColumnName("Handicapped_Type_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.HandicappedTypeEnName)
                    .HasColumnName("Handicapped_Type_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<HiringDocumentTbl>(entity =>
            {
                entity.HasKey(e => e.HiringDocumentId);

                entity.ToTable("Hiring_Document_Tbl");

                entity.Property(e => e.HiringDocumentId).HasColumnName("Hiring_Document_ID");

                entity.Property(e => e.ForGenderYn).HasColumnName("For_Gender_YN");

                entity.Property(e => e.ForPositionYn).HasColumnName("For_Position_YN");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.GenderId).HasColumnName("Gender_ID");

                entity.Property(e => e.HiringDocumentArName)
                    .HasColumnName("Hiring_Document_Ar_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.HiringDocumentArNameShadow)
                    .HasColumnName("Hiring_Document_Ar_Name_Shadow")
                    .HasMaxLength(200);

                entity.Property(e => e.HiringDocumentCode)
                    .HasColumnName("Hiring_Document_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.HiringDocumentEnName)
                    .HasColumnName("Hiring_Document_En_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PositionIds).HasColumnName("Position_IDs");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.RequiredYn).HasColumnName("Required_YN");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<HiringDocumentTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.HiringDocumentTransactionId)
                    .HasName("PK_Document_Archive_Transaction_Tbl");

                entity.ToTable("Hiring_Document_Transaction_Tbl");

                entity.Property(e => e.HiringDocumentTransactionId).HasColumnName("Hiring_Document_Transaction_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.HiringDocumentId).HasColumnName("Hiring_Document_ID");

                entity.Property(e => e.HiringDocumentIssueDate)
                    .HasColumnName("Hiring_Document_Issue_Date")
                    .HasColumnType("date");

                entity.Property(e => e.HiringDocumentStatus)
                    .HasColumnName("Hiring_Document_Status")
                    .HasMaxLength(100);

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.ReceiveDate)
                    .HasColumnName("Receive_Date")
                    .HasColumnType("date");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.HiringDocumentTransactionTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Document_Archive_Transaction_Tbl_Employee_Tbl");

                entity.HasOne(d => d.HiringDocument)
                    .WithMany(p => p.HiringDocumentTransactionTbl)
                    .HasForeignKey(d => d.HiringDocumentId)
                    .HasConstraintName("FK_Document_Archive_Transaction_Tbl_Hiring_Document_Tbl");
            });

            modelBuilder.Entity<HolidayAllowanceTransactionDetailsTbl>(entity =>
            {
                entity.HasKey(e => e.HolidayAllowanceTransactionDetailsId);

                entity.ToTable("Holiday_Allowance_Transaction_Details_Tbl");

                entity.Property(e => e.HolidayAllowanceTransactionDetailsId).HasColumnName("Holiday_Allowance_Transaction_Details_ID");

                entity.Property(e => e.AlternativeVacationTransactionId).HasColumnName("Alternative_Vacation_Transaction_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.HolidayAllowanceTransactionId).HasColumnName("Holiday_Allowance_Transaction_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.HolidayAllowanceTransactionDetailsTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Holiday_Allowance_Transaction_Details_Tbl_Employee_Tbl");

                entity.HasOne(d => d.HolidayAllowanceTransaction)
                    .WithMany(p => p.HolidayAllowanceTransactionDetailsTbl)
                    .HasForeignKey(d => d.HolidayAllowanceTransactionId)
                    .HasConstraintName("FK_Holiday_Allowance_Transaction_Details_Tbl_Holiday_Allowance_Transaction_Tbl");
            });

            modelBuilder.Entity<HolidayAllowanceTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.HolidayAllowanceTransactionId);

                entity.ToTable("Holiday_Allowance_Transaction_Tbl");

                entity.Property(e => e.HolidayAllowanceTransactionId).HasColumnName("Holiday_Allowance_Transaction_ID");

                entity.Property(e => e.AlternativeDate)
                    .HasColumnName("Alternative_Date")
                    .HasColumnType("date");

                entity.Property(e => e.DescriptionAr)
                    .HasColumnName("Description_Ar")
                    .HasMaxLength(200);

                entity.Property(e => e.DescriptionEn)
                    .HasColumnName("Description_En")
                    .HasMaxLength(200);

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.HolidayAllowanceTypeId).HasColumnName("Holiday_Allowance_Type_ID");

                entity.Property(e => e.HolidayDate)
                    .HasColumnName("Holiday_Date")
                    .HasColumnType("date");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PaidAsAdditionalPaymnet).HasColumnName("Paid_As_Additional_Paymnet");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.PublicHolidayId).HasColumnName("Public_Holiday_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.HolidayAllowanceType)
                    .WithMany(p => p.HolidayAllowanceTransactionTbl)
                    .HasForeignKey(d => d.HolidayAllowanceTypeId)
                    .HasConstraintName("FK_Holiday_Allowance_Transaction_Tbl_Holiday_Allowance_Type_Tbl");

                entity.HasOne(d => d.PublicHoliday)
                    .WithMany(p => p.HolidayAllowanceTransactionTbl)
                    .HasForeignKey(d => d.PublicHolidayId)
                    .HasConstraintName("FK_Holiday_Allowance_Transaction_Tbl_Public_Holiday_Tbl");
            });

            modelBuilder.Entity<HolidayAllowanceTypeTbl>(entity =>
            {
                entity.HasKey(e => e.HolidayAllowanceTypeId);

                entity.ToTable("Holiday_Allowance_Type_Tbl");

                entity.Property(e => e.HolidayAllowanceTypeId).HasColumnName("Holiday_Allowance_Type_ID");

                entity.Property(e => e.HolidayAllowanceTypeArName)
                    .HasColumnName("Holiday_Allowance_Type_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.HolidayAllowanceTypeEnName)
                    .HasColumnName("Holiday_Allowance_Type_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<HousingTypeTbl>(entity =>
            {
                entity.HasKey(e => e.HousingTypeId);

                entity.ToTable("Housing_Type_Tbl");

                entity.Property(e => e.HousingTypeId).HasColumnName("Housing_Type_ID");

                entity.Property(e => e.HousingTypeArName)
                    .HasColumnName("Housing_Type_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.HousingTypeEnName)
                    .HasColumnName("Housing_Type_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<InsuranceOfficeTbl>(entity =>
            {
                entity.HasKey(e => e.InsuranceOfficeId);

                entity.ToTable("Insurance_Office_Tbl");

                entity.Property(e => e.InsuranceOfficeId).HasColumnName("Insurance_Office_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.InsuranceOfficeArName)
                    .HasColumnName("Insurance_Office_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.InsuranceOfficeArNameShadow)
                    .HasColumnName("Insurance_Office_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.InsuranceOfficeCode)
                    .HasColumnName("Insurance_Office_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.InsuranceOfficeEnName)
                    .HasColumnName("Insurance_Office_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<InsuranceRuleTbl>(entity =>
            {
                entity.HasKey(e => e.InsuranceRuleId);

                entity.ToTable("Insurance_Rule_Tbl");

                entity.Property(e => e.InsuranceRuleId).HasColumnName("Insurance_Rule_ID");

                entity.Property(e => e.CalculateFromFixedAmounts).HasColumnName("Calculate_From_Fixed_Amounts");

                entity.Property(e => e.EmployeeFixedHealthInsuranceRate).HasColumnName("Employee_Fixed_Health_Insurance_Rate");

                entity.Property(e => e.EmployeeFixedInsuranceRate).HasColumnName("Employee_Fixed_Insurance_Rate");

                entity.Property(e => e.EmployeeVariableHealthInsuranceRate).HasColumnName("Employee_Variable_Health_Insurance_Rate");

                entity.Property(e => e.EmployeeVariableInsuranceRate).HasColumnName("Employee_Variable_Insurance_Rate");

                entity.Property(e => e.FixedInsuranceMaximumLimit).HasColumnName("Fixed_Insurance_Maximum_Limit");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.InsuranceRuleArName)
                    .HasColumnName("Insurance_Rule_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.InsuranceRuleArNameShadow)
                    .HasColumnName("Insurance_Rule_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.InsuranceRuleCode)
                    .HasColumnName("Insurance_Rule_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.InsuranceRuleEnName)
                    .HasColumnName("Insurance_Rule_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.OrganizationFixedHealthInsuranceRate).HasColumnName("Organization_Fixed_Health_Insurance_Rate");

                entity.Property(e => e.OrganizationFixedInsuranceRate).HasColumnName("Organization_Fixed_Insurance_Rate");

                entity.Property(e => e.OrganizationVariableHealthInsuranceRate).HasColumnName("Organization_Variable_Health_Insurance_Rate");

                entity.Property(e => e.OrganizationVariableInsuranceRate).HasColumnName("Organization_Variable_Insurance_Rate");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.Property(e => e.VariableInsuranceMaximumLimit).HasColumnName("Variable_Insurance_Maximum_Limit");
            });

            modelBuilder.Entity<InsuranceStatusTbl>(entity =>
            {
                entity.HasKey(e => e.InsuranceStatusId);

                entity.ToTable("Insurance_Status_Tbl");

                entity.Property(e => e.InsuranceStatusId).HasColumnName("Insurance_Status_ID");

                entity.Property(e => e.InsuranceStatusArName)
                    .HasColumnName("Insurance_Status_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.InsuranceStatusEnName)
                    .HasColumnName("Insurance_Status_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<InterfaceTbl>(entity =>
            {
                entity.HasKey(e => e.InterfaceId);

                entity.ToTable("Interface_Tbl");

                entity.Property(e => e.InterfaceId).HasColumnName("Interface_ID");

                entity.Property(e => e.AbsenceWithPermissionDeductionId)
                    .HasColumnName("Absence_With_Permission_Deduction_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.AbsenceWithoutPermissionDeductionId)
                    .HasColumnName("Absence_Without_Permission_Deduction_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyInsuranceDeductionId)
                    .HasColumnName("Company_Insurance_Deduction_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.ContractExpiryDeductionId)
                    .HasColumnName("Contract_Expiry_Deduction_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.DayoffDeductionId)
                    .HasColumnName("Dayoff_Deduction_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.DayoffPaymentId)
                    .HasColumnName("Dayoff_Payment_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.EosPaymentId)
                    .HasColumnName("EOS_Payment_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.HolidayAllowancePaymentId)
                    .HasColumnName("Holiday_Allowance_Payment_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.HolidayDeductionId)
                    .HasColumnName("Holiday_Deduction_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.HolidayPaymentId)
                    .HasColumnName("Holiday_Payment_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.LateDeductionId)
                    .HasColumnName("Late_Deduction_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.MedicalDeductionId)
                    .HasColumnName("Medical_Deduction_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.MonthComplementPaymentId)
                    .HasColumnName("Month_Complement_Payment_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.OutSideDeductionId)
                    .HasColumnName("Out_Side_Deduction_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.OverTimePaymentId)
                    .HasColumnName("Over_Time_Payment_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.PenaltyDeductionId)
                    .HasColumnName("Penalty_Deduction_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.PenaltyNotListDeductionId)
                    .HasColumnName("Penalty_Not_List_Deduction_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.PenaltyValueDeductionId)
                    .HasColumnName("Penalty_Value_Deduction_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.TrainingDeductionId)
                    .HasColumnName("Training_Deduction_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.Property(e => e.VacationBalanceDeductionId)
                    .HasColumnName("Vacation_Balance_Deduction_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.VacationBalancePaymentId)
                    .HasColumnName("Vacation_Balance_Payment_ID")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<JobDescriptionTbl>(entity =>
            {
                entity.HasKey(e => e.JobDescriptionId)
                    .HasName("PK_Evaluation_Job_Description");

                entity.ToTable("Job_Description_Tbl");

                entity.Property(e => e.JobDescriptionId).HasColumnName("Job_Description_ID");

                entity.Property(e => e.ExperienceFrom).HasColumnName("Experience_From");

                entity.Property(e => e.ExperienceTo).HasColumnName("Experience_To");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.JobDescriptionSummary).HasColumnName("Job_Description_Summary");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PositionId).HasColumnName("Position_ID");

                entity.Property(e => e.PositionReportingTo).HasColumnName("Position_Reporting_To");

                entity.Property(e => e.PositionSubOrdinate).HasColumnName("Position_SubOrdinate");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.ResponsibilitiesWeight).HasColumnName("Responsibilities_Weight");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.JobDescriptionTbl)
                    .HasForeignKey(d => d.PositionId)
                    .HasConstraintName("FK_Job_Description_Tbl_Position_Tbl");
            });

            modelBuilder.Entity<JobLanguageSkillsTbl>(entity =>
            {
                entity.HasKey(e => e.JobLanguageSkillsId)
                    .HasName("PK_Evaluation_Job_Language_Skills_Tbl");

                entity.ToTable("Job_Language_Skills_Tbl");

                entity.Property(e => e.JobLanguageSkillsId).HasColumnName("Job_Language_Skills_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.JobDescriptionId).HasColumnName("Job_Description_ID");

                entity.Property(e => e.LanguageDegreeId).HasColumnName("Language_Degree_ID");

                entity.Property(e => e.LanguageId).HasColumnName("Language_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.JobDescription)
                    .WithMany(p => p.JobLanguageSkillsTbl)
                    .HasForeignKey(d => d.JobDescriptionId)
                    .HasConstraintName("FK_Job_Language_Skills_Tbl_Job_Description_Tbl");

                entity.HasOne(d => d.LanguageDegree)
                    .WithMany(p => p.JobLanguageSkillsTbl)
                    .HasForeignKey(d => d.LanguageDegreeId)
                    .HasConstraintName("FK_Job_Language_Skills_Tbl_Language_Degree_Tbl");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.JobLanguageSkillsTbl)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_Job_Language_Skills_Tbl_Language_Tbl");
            });

            modelBuilder.Entity<JobResponsibilityTbl>(entity =>
            {
                entity.HasKey(e => e.JobResponsibilityId)
                    .HasName("PK_Evaluation_Job_Responsibility_Tbl");

                entity.ToTable("Job_Responsibility_Tbl");

                entity.Property(e => e.JobResponsibilityId).HasColumnName("Job_Responsibility_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.JobDescriptionId).HasColumnName("Job_Description_ID");

                entity.Property(e => e.JobResponsibilityArName)
                    .HasColumnName("Job_Responsibility_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.JobResponsibilityArNameShadow)
                    .HasColumnName("Job_Responsibility_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.JobResponsibilityEnName)
                    .HasColumnName("Job_Responsibility_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.JobDescription)
                    .WithMany(p => p.JobResponsibilityTbl)
                    .HasForeignKey(d => d.JobDescriptionId)
                    .HasConstraintName("FK_Job_Responsibility_Tbl_Job_Description_Tbl");
            });

            modelBuilder.Entity<JobTechnicalSkillsTbl>(entity =>
            {
                entity.HasKey(e => e.JobTechnicalSkillsId)
                    .HasName("PK_Evaluation_Job_Technical_Skills_Tbl");

                entity.ToTable("Job_Technical_Skills_Tbl");

                entity.Property(e => e.JobTechnicalSkillsId).HasColumnName("Job_Technical_Skills_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.JobDescriptionId).HasColumnName("Job_Description_ID");

                entity.Property(e => e.JobTechnicalSkillsArName)
                    .HasColumnName("Job_Technical_Skills_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.JobTechnicalSkillsArNameShadow)
                    .HasColumnName("Job_Technical_Skills_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.JobTechnicalSkillsEnName)
                    .HasColumnName("Job_Technical_Skills_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<JvCalculationTbl>(entity =>
            {
                entity.HasKey(e => e.JvCalculationId);

                entity.ToTable("JV_Calculation_Tbl");

                entity.Property(e => e.JvCalculationId).HasColumnName("JV_Calculation_ID");

                entity.Property(e => e.AccountNumber)
                    .HasColumnName("Account_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.AccountNumberJvDescription)
                    .HasColumnName("Account_Number_JV_Description")
                    .HasMaxLength(100);

                entity.Property(e => e.AmountType)
                    .HasColumnName("Amount_Type")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentCostCenter)
                    .HasColumnName("Department_Cost_Center")
                    .HasMaxLength(20);

                entity.Property(e => e.DepartmentId).HasColumnName("Department_ID");

                entity.Property(e => e.DivisionCostCenter)
                    .HasColumnName("Division_Cost_Center")
                    .HasMaxLength(20);

                entity.Property(e => e.DivisionId).HasColumnName("Division_ID");

                entity.Property(e => e.EmployeeCostCenter)
                    .HasColumnName("Employee_Cost_Center")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.EmployeeStatus).HasColumnName("Employee_Status");

                entity.Property(e => e.GradeCostCenter)
                    .HasColumnName("Grade_Cost_Center")
                    .HasMaxLength(20);

                entity.Property(e => e.JornalType)
                    .HasColumnName("Jornal_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.JvDate)
                    .HasColumnName("JV_Date")
                    .HasColumnType("date");

                entity.Property(e => e.JvType)
                    .HasColumnName("JV_Type")
                    .HasMaxLength(3);

                entity.Property(e => e.ManegerialCostCenter)
                    .HasColumnName("Manegerial_Cost_Center")
                    .HasMaxLength(20);

                entity.Property(e => e.ManegerialTCode)
                    .HasColumnName("Manegerial_T_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.OtherHierarchyCostCenter)
                    .HasColumnName("Other_Hierarchy_Cost_Center")
                    .HasMaxLength(20);

                entity.Property(e => e.OtherHierarchyTCode)
                    .HasColumnName("Other_Hierarchy_T_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PropertyCostCenter)
                    .HasColumnName("Property_Cost_Center")
                    .HasMaxLength(20);

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.SectionCostCenter)
                    .HasColumnName("Section_Cost_Center")
                    .HasMaxLength(20);

                entity.Property(e => e.SectionId).HasColumnName("Section_ID");

                entity.Property(e => e.SettlementYn).HasColumnName("Settlement_YN");

                entity.Property(e => e.TheMonth).HasColumnName("The_Month");

                entity.Property(e => e.TheYear).HasColumnName("The_Year");
            });

            modelBuilder.Entity<JvConfigurationTbl>(entity =>
            {
                entity.HasKey(e => e.JvConfigurationId);

                entity.ToTable("JV_Configuration_Tbl");

                entity.Property(e => e.JvConfigurationId).HasColumnName("JV_Configuration_ID");

                entity.Property(e => e.AdditionalPaymentClearanceAccountNumberId).HasColumnName("Additional_Payment_Clearance_Account_Number_ID");

                entity.Property(e => e.AdditionalPaymentJournalType)
                    .HasColumnName("Additional_Payment_Journal_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.BaladyaCardAccountNumberId).HasColumnName("Baladya_Card_Account_Number_ID");

                entity.Property(e => e.BaladyaCardClearanceAccountNumberId).HasColumnName("Baladya_Card_Clearance_Account_Number_ID");

                entity.Property(e => e.BaladyaCardJournalType)
                    .HasColumnName("Baladya_Card_Journal_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.BonusAccountNumberId).HasColumnName("Bonus_Account_Number_ID");

                entity.Property(e => e.BonusClearanceAccountNumberId).HasColumnName("Bonus_Clearance_Account_Number_ID");

                entity.Property(e => e.BonusJournalType)
                    .HasColumnName("Bonus_Journal_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.BranchCodeType).HasColumnName("Branch_Code_Type");

                entity.Property(e => e.BranchPosition)
                    .HasColumnName("Branch_Position")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BranchStartIndex).HasColumnName("Branch_Start_Index");

                entity.Property(e => e.BranchTCode)
                    .HasColumnName("Branch_T_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.CompanyInsuranceCreditAccountNumberId).HasColumnName("Company_Insurance_Credit_Account_Number_ID");

                entity.Property(e => e.CompanyInsuranceDebitAccountNumberId).HasColumnName("Company_Insurance_Debit_Account_Number_ID");

                entity.Property(e => e.DayOffAccountNumberId).HasColumnName("Day_Off_Account_Number_ID");

                entity.Property(e => e.DayOffClearanceAccountNumberId).HasColumnName("Day_Off_Clearance_Account_Number_ID");

                entity.Property(e => e.DayOffJournalType)
                    .HasColumnName("Day_Off_Journal_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.DepartmentCodeType).HasColumnName("Department_Code_Type");

                entity.Property(e => e.DepartmentPosition)
                    .HasColumnName("Department_Position")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentStartIndex).HasColumnName("Department_Start_Index");

                entity.Property(e => e.DepartmentTCode)
                    .HasColumnName("Department_T_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.DivisionCodeType).HasColumnName("Division_Code_Type");

                entity.Property(e => e.DivisionPosition)
                    .HasColumnName("Division_Position")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DivisionStartIndex).HasColumnName("Division_Start_Index");

                entity.Property(e => e.DivisionTCode)
                    .HasColumnName("Division_T_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.EmployeeInsuranceAccountNumberId).HasColumnName("Employee_Insurance_Account_Number_ID");

                entity.Property(e => e.EosAccountNumberId).HasColumnName("EOS_Account_Number_ID");

                entity.Property(e => e.EosAccrualAccountNumberId).HasColumnName("EOS_Accrual_Account_Number_ID");

                entity.Property(e => e.EosAccrualClearanceAccountNumberId).HasColumnName("EOS_Accrual_Clearance_Account_Number_ID");

                entity.Property(e => e.EosAccrualJournalType)
                    .HasColumnName("EOS_Accrual_Journal_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.EosAccrualRuleId).HasColumnName("EOS_Accrual_Rule_ID");

                entity.Property(e => e.EosClearanceAccountNumberId).HasColumnName("EOS_Clearance_Account_Number_ID");

                entity.Property(e => e.EosJournalType)
                    .HasColumnName("EOS_Journal_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.ExitEntryAccountNumberId).HasColumnName("Exit_Entry_Account_Number_ID");

                entity.Property(e => e.ExitEntryAmount).HasColumnName("Exit_Entry_Amount");

                entity.Property(e => e.ExitEntryClearanceAccountNumberId).HasColumnName("Exit_Entry_Clearance_Account_Number_ID");

                entity.Property(e => e.ExitEntryJournalType)
                    .HasColumnName("Exit_Entry_Journal_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.GeneralCashierAccountNumberId).HasColumnName("General_Cashier_Account_Number_ID");

                entity.Property(e => e.GradeCodeType).HasColumnName("Grade_Code_Type");

                entity.Property(e => e.GradePosition)
                    .HasColumnName("Grade_Position")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.GradeStartIndex).HasColumnName("Grade_Start_Index");

                entity.Property(e => e.GradeTCode)
                    .HasColumnName("Grade_T_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.HealthInsuranceAccountNumberId).HasColumnName("Health_Insurance_Account_Number_ID");

                entity.Property(e => e.HealthInsuranceClearanceAccountNumberId).HasColumnName("Health_Insurance_Clearance_Account_Number_ID");

                entity.Property(e => e.HealthInsuranceJournalType)
                    .HasColumnName("Health_Insurance_Journal_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.HolidayAccountNumberId).HasColumnName("Holiday_Account_Number_ID");

                entity.Property(e => e.HolidayClearanceAccountNumberId).HasColumnName("Holiday_Clearance_Account_Number_ID");

                entity.Property(e => e.HolidayJournalType)
                    .HasColumnName("Holiday_Journal_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.ImsInsuranceAccountNumberId).HasColumnName("IMS_Insurance_Account_Number_ID");

                entity.Property(e => e.ImsInsuranceAmount).HasColumnName("IMS_Insurance_Amount");

                entity.Property(e => e.ImsInsuranceClearanceAccountNumberId).HasColumnName("IMS_Insurance_Clearance_Account_Number_ID");

                entity.Property(e => e.ImsInsuranceJournalType)
                    .HasColumnName("IMS_Insurance_Journal_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.IncentiveBonusAccountNumberId).HasColumnName("Incentive_Bonus_Account_Number_ID");

                entity.Property(e => e.IncentiveBonusClearanceAccountNumberId).HasColumnName("Incentive_Bonus_Clearance_Account_Number_ID");

                entity.Property(e => e.IncentiveBonusJournalType)
                    .HasColumnName("Incentive_Bonus_Journal_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.InsuranceJournalType)
                    .HasColumnName("Insurance_Journal_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.IqamaMedicalAccountNumberId).HasColumnName("Iqama_Medical_Account_Number_ID");

                entity.Property(e => e.IqamaMedicalAmount).HasColumnName("Iqama_Medical_Amount");

                entity.Property(e => e.IqamaMedicalClearanceAccountNumberId).HasColumnName("Iqama_Medical_Clearance_Account_Number_ID");

                entity.Property(e => e.IqamaMedicalJournalType)
                    .HasColumnName("Iqama_Medical_Journal_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.IqamaRenewalAccountNumberId).HasColumnName("Iqama_Renewal_Account_Number_ID");

                entity.Property(e => e.IqamaRenewalAmount).HasColumnName("Iqama_Renewal_Amount");

                entity.Property(e => e.IqamaRenewalClearanceAccountNumberId).HasColumnName("Iqama_Renewal_Clearance_Account_Number_ID");

                entity.Property(e => e.IqamaRenewalJournalType)
                    .HasColumnName("Iqama_Renewal_Journal_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.LifeInsuranceAccountNumberId).HasColumnName("Life_Insurance_Account_Number_ID");

                entity.Property(e => e.LifeInsuranceClearanceAccountNumberId).HasColumnName("Life_Insurance_Clearance_Account_Number_ID");

                entity.Property(e => e.LifeInsuranceJournalType)
                    .HasColumnName("Life_Insurance_Journal_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PensionSchemeAccountNumberId).HasColumnName("Pension_Scheme_Account_Number_ID");

                entity.Property(e => e.PensionSchemeClearanceAccountNumberId).HasColumnName("Pension_Scheme_Clearance_Account_Number_ID");

                entity.Property(e => e.PensionSchemeJournalType)
                    .HasColumnName("Pension_Scheme_Journal_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.ProfitAccountNumberId).HasColumnName("Profit_Account_Number_ID");

                entity.Property(e => e.ProfitClearanceAccountNumberId).HasColumnName("Profit_Clearance_Account_Number_ID");

                entity.Property(e => e.ProfitJournalType)
                    .HasColumnName("Profit_Journal_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.PropertyCodeType).HasColumnName("Property_Code_Type");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.PropertyPosition)
                    .HasColumnName("Property_Position")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyStartIndex).HasColumnName("Property_Start_Index");

                entity.Property(e => e.PropertyTCode)
                    .HasColumnName("Property_T_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.RiskAccountNumberId).HasColumnName("Risk_Account_Number_ID");

                entity.Property(e => e.RiskClearanceAccountNumberId).HasColumnName("Risk_Clearance_Account_Number_ID");

                entity.Property(e => e.RiskJournalType)
                    .HasColumnName("Risk_Journal_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.RiskRate).HasColumnName("Risk_Rate");

                entity.Property(e => e.SalaryClearanceAccountNumberId).HasColumnName("Salary_Clearance_Account_Number_ID");

                entity.Property(e => e.SalaryJournalType)
                    .HasColumnName("Salary_Journal_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.SalaryTaxAccountNumberId).HasColumnName("Salary_Tax_Account_Number_ID");

                entity.Property(e => e.SchoolFeesAccountNumberId).HasColumnName("School_Fees_Account_Number_ID");

                entity.Property(e => e.SchoolFeesClearanceAccountNumberId).HasColumnName("School_Fees_Clearance_Account_Number_ID");

                entity.Property(e => e.SchoolFeesJournalType)
                    .HasColumnName("School_Fees_Journal_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.SectionCodeType).HasColumnName("Section_Code_Type");

                entity.Property(e => e.SectionPosition)
                    .HasColumnName("Section_Position")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SectionStartIndex).HasColumnName("Section_Start_Index");

                entity.Property(e => e.SectionTCode)
                    .HasColumnName("Section_T_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ServiceChargeAccountNumberId).HasColumnName("Service_Charge_Account_Number_ID");

                entity.Property(e => e.ServiceChargeClearanceAccountNumberId).HasColumnName("Service_Charge_Clearance_Account_Number_ID");

                entity.Property(e => e.ServiceChargeJournalType)
                    .HasColumnName("Service_Charge_Journal_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.ServiceChargeTaxAccountNumberId).HasColumnName("Service_Charge_Tax_Account_Number_ID");

                entity.Property(e => e.StaffBonusAccountNumberId).HasColumnName("Staff_Bonus_Account_Number_ID");

                entity.Property(e => e.StaffBonusClearanceAccountNumberId).HasColumnName("Staff_Bonus_Clearance_Account_Number_ID");

                entity.Property(e => e.StaffBonusJournalType)
                    .HasColumnName("Staff_Bonus_Journal_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.TicketAccountNumberId).HasColumnName("Ticket_Account_Number_ID");

                entity.Property(e => e.TicketClearanceAccountNumberId).HasColumnName("Ticket_Clearance_Account_Number_ID");

                entity.Property(e => e.TicketJournalType)
                    .HasColumnName("Ticket_Journal_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.UnitCodeType).HasColumnName("Unit_Code_Type");

                entity.Property(e => e.UnitPosition)
                    .HasColumnName("Unit_Position")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UnitStartIndex).HasColumnName("Unit_Start_Index");

                entity.Property(e => e.UnitTCode)
                    .HasColumnName("Unit_T_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.Property(e => e.UseRiskYn).HasColumnName("Use_Risk_YN");

                entity.Property(e => e.VacationAccountNumberId).HasColumnName("Vacation_Account_Number_ID");

                entity.Property(e => e.VacationClearanceAccountNumberId).HasColumnName("Vacation_Clearance_Account_Number_ID");

                entity.Property(e => e.VacationJournalType)
                    .HasColumnName("Vacation_Journal_Type")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<JvReportDetailsTbl>(entity =>
            {
                entity.HasKey(e => e.JvReportDetailsId);

                entity.ToTable("JV_Report_Details_Tbl");

                entity.Property(e => e.JvReportDetailsId).HasColumnName("JV_Report_Details_ID");

                entity.Property(e => e.AccountNumber)
                    .HasColumnName("Account_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.AccountNumberJvDescription)
                    .HasColumnName("Account_Number_JV_Description")
                    .HasMaxLength(100);

                entity.Property(e => e.AmountC).HasColumnName("Amount_C");

                entity.Property(e => e.AmountD).HasColumnName("Amount_D");

                entity.Property(e => e.CostCenter)
                    .HasColumnName("Cost_Center")
                    .HasMaxLength(20);

                entity.Property(e => e.JornalType)
                    .HasColumnName("Jornal_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.JvType)
                    .HasColumnName("JV_Type")
                    .HasMaxLength(3);

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.T0).HasMaxLength(20);

                entity.Property(e => e.T1).HasMaxLength(20);

                entity.Property(e => e.T2).HasMaxLength(20);

                entity.Property(e => e.T3).HasMaxLength(20);

                entity.Property(e => e.T4).HasMaxLength(20);

                entity.Property(e => e.T5).HasMaxLength(20);

                entity.Property(e => e.T6).HasMaxLength(20);

                entity.Property(e => e.T7).HasMaxLength(20);

                entity.Property(e => e.T8).HasMaxLength(20);

                entity.Property(e => e.T9).HasMaxLength(20);

                entity.Property(e => e.TheMonth).HasColumnName("The_Month");

                entity.Property(e => e.TheYear).HasColumnName("The_Year");

                entity.Property(e => e.UserId).HasColumnName("User_ID");
            });

            modelBuilder.Entity<LanguageDegreeTbl>(entity =>
            {
                entity.HasKey(e => e.LanguageDegreeId);

                entity.ToTable("Language_Degree_Tbl");

                entity.Property(e => e.LanguageDegreeId).HasColumnName("Language_Degree_ID");

                entity.Property(e => e.LanguageDegreeArName)
                    .HasColumnName("Language_Degree_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.LanguageDegreeEnName)
                    .HasColumnName("Language_Degree_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LanguageTbl>(entity =>
            {
                entity.HasKey(e => e.LanguageId);

                entity.ToTable("Language_Tbl");

                entity.Property(e => e.LanguageId).HasColumnName("Language_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.LanguageArName)
                    .HasColumnName("Language_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.LanguageArNameShadow)
                    .HasColumnName("Language_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("Language_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.LanguageEnName)
                    .HasColumnName("Language_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<LateTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.LateTransactionId);

                entity.ToTable("Late_Transaction_Tbl");

                entity.Property(e => e.LateTransactionId).HasColumnName("Late_Transaction_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.LateDate)
                    .HasColumnName("Late_Date")
                    .HasColumnType("date");

                entity.Property(e => e.LateHours).HasColumnName("Late_Hours");

                entity.Property(e => e.LateMinutes).HasColumnName("Late_Minutes");

                entity.Property(e => e.LateTotalHours).HasColumnName("Late_Total_Hours");

                entity.Property(e => e.LateTotalMinutes).HasColumnName("Late_Total_Minutes");

                entity.Property(e => e.LateTypeId).HasColumnName("Late_Type_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.PenaltyTransactionId).HasColumnName("Penalty_Transaction_ID");

                entity.Property(e => e.PenaltyYn).HasColumnName("Penalty_YN");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.ThroughMachineYn).HasColumnName("Through_Machine_YN");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.LateTransactionTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Late_Transaction_Tbl_Employee_Tbl");

                entity.HasOne(d => d.LateType)
                    .WithMany(p => p.LateTransactionTbl)
                    .HasForeignKey(d => d.LateTypeId)
                    .HasConstraintName("FK_Late_Transaction_Tbl_Late_Type_Tbl");
            });

            modelBuilder.Entity<LateTypeTbl>(entity =>
            {
                entity.HasKey(e => e.LateTypeId);

                entity.ToTable("Late_Type_Tbl");

                entity.Property(e => e.LateTypeId).HasColumnName("Late_Type_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.LateTypeArName)
                    .HasColumnName("Late_Type_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.LateTypeArNameShadow)
                    .HasColumnName("Late_Type_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.LateTypeCode)
                    .HasColumnName("Late_Type_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.LateTypeEnName)
                    .HasColumnName("Late_Type_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.LateTypeRate).HasColumnName("Late_Type_Rate");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<LicenseTypeTbl>(entity =>
            {
                entity.HasKey(e => e.LicenseTypeId);

                entity.ToTable("License_Type_Tbl");

                entity.Property(e => e.LicenseTypeId).HasColumnName("License_Type_ID");

                entity.Property(e => e.LicenseName)
                    .HasColumnName("License_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.LicenseTypeArName)
                    .HasColumnName("License_Type_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.LicenseTypeEnName)
                    .HasColumnName("License_Type_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LoanTbl>(entity =>
            {
                entity.HasKey(e => e.LoanId);

                entity.ToTable("Loan_Tbl");

                entity.Property(e => e.LoanId).HasColumnName("Loan_ID");

                entity.Property(e => e.AccountNumberId).HasColumnName("Account_Number_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.LoanArName)
                    .HasColumnName("Loan_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.LoanArNameShadow)
                    .HasColumnName("Loan_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.LoanArShortName)
                    .HasColumnName("Loan_Ar_Short_Name")
                    .HasMaxLength(20);

                entity.Property(e => e.LoanCode)
                    .HasColumnName("Loan_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.LoanEnName)
                    .HasColumnName("Loan_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.LoanEnShortName)
                    .HasColumnName("Loan_En_Short_Name")
                    .HasMaxLength(20);

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.MaxAmount).HasColumnName("Max_Amount");

                entity.Property(e => e.MaxNumber).HasColumnName("Max_Number");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.AccountNumber)
                    .WithMany(p => p.LoanTbl)
                    .HasForeignKey(d => d.AccountNumberId)
                    .HasConstraintName("FK_Loan_Tbl_Account_Number_Tbl");
            });

            modelBuilder.Entity<LoanTransactionDetailsTbl>(entity =>
            {
                entity.HasKey(e => e.LoanTransactionDetailsId);

                entity.ToTable("Loan_Transaction_Details_Tbl");

                entity.Property(e => e.LoanTransactionDetailsId).HasColumnName("Loan_Transaction_Details_ID");

                entity.Property(e => e.LoanStatus).HasColumnName("Loan_Status");

                entity.Property(e => e.LoanTransactionId).HasColumnName("Loan_Transaction_ID");

                entity.Property(e => e.LoanValue).HasColumnName("Loan_Value");

                entity.Property(e => e.PaidYn).HasColumnName("Paid_YN");

                entity.Property(e => e.TheMonth).HasColumnName("The_Month");

                entity.Property(e => e.TheYear).HasColumnName("The_Year");

                entity.HasOne(d => d.LoanTransaction)
                    .WithMany(p => p.LoanTransactionDetailsTbl)
                    .HasForeignKey(d => d.LoanTransactionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Loan_Transaction_Details_Tbl_Loan_Transaction_Tbl");
            });

            modelBuilder.Entity<LoanTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.LoanTransactionId);

                entity.ToTable("Loan_Transaction_Tbl");

                entity.Property(e => e.LoanTransactionId).HasColumnName("Loan_Transaction_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.LoanAmount).HasColumnName("Loan_Amount");

                entity.Property(e => e.LoanDate)
                    .HasColumnName("Loan_Date")
                    .HasColumnType("date");

                entity.Property(e => e.LoanEndMonth).HasColumnName("Loan_End_Month");

                entity.Property(e => e.LoanEndYear).HasColumnName("Loan_End_Year");

                entity.Property(e => e.LoanId).HasColumnName("Loan_ID");

                entity.Property(e => e.LoanPeriod).HasColumnName("Loan_Period");

                entity.Property(e => e.LoanStartingMonth).HasColumnName("Loan_Starting_Month");

                entity.Property(e => e.LoanStartingYear).HasColumnName("Loan_Starting_Year");

                entity.Property(e => e.LoanStatus).HasColumnName("Loan_Status");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.LoanTransactionTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Loan_Transaction_Tbl_Employee_Tbl");

                entity.HasOne(d => d.Loan)
                    .WithMany(p => p.LoanTransactionTbl)
                    .HasForeignKey(d => d.LoanId)
                    .HasConstraintName("FK_Loan_Transaction_Tbl_Loan_Tbl");
            });

            modelBuilder.Entity<LockedRecordTbl>(entity =>
            {
                entity.HasKey(e => new { e.PropertyId, e.AppMenuId, e.RecordId });

                entity.ToTable("Locked_Record_Tbl");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.AppMenuId).HasColumnName("App_Menu_ID");

                entity.Property(e => e.RecordId).HasColumnName("Record_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");
            });

            modelBuilder.Entity<MachineTbl>(entity =>
            {
                entity.HasKey(e => e.MachineId);

                entity.ToTable("Machine_Tbl");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.LoginName)
                    .HasColumnName("Login_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.MachineName)
                    .HasColumnName("Machine_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MaritalStatusTbl>(entity =>
            {
                entity.HasKey(e => e.MaritalStatusId);

                entity.ToTable("Marital_Status_Tbl");

                entity.Property(e => e.MaritalStatusId).HasColumnName("Marital_Status_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.MaritalStatusArName)
                    .HasColumnName("Marital_Status_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.MaritalStatusArNameShadow)
                    .HasColumnName("Marital_Status_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.MaritalStatusCode)
                    .HasColumnName("Marital_Status_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.MaritalStatusEnName)
                    .HasColumnName("Marital_Status_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.MaritalStatusTypeId).HasColumnName("Marital_Status_Type_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.MaritalStatusType)
                    .WithMany(p => p.MaritalStatusTbl)
                    .HasForeignKey(d => d.MaritalStatusTypeId)
                    .HasConstraintName("FK_Marital_Status_Tbl_Marital_Status_Type_Tbl");
            });

            modelBuilder.Entity<MaritalStatusTypeTbl>(entity =>
            {
                entity.HasKey(e => e.MaritalStatusTypeId);

                entity.ToTable("Marital_Status_Type_Tbl");

                entity.Property(e => e.MaritalStatusTypeId).HasColumnName("Marital_Status_Type_ID");

                entity.Property(e => e.MaritalStatusTypeArName)
                    .HasColumnName("Marital_Status_Type_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.MaritalStatusTypeEnName)
                    .HasColumnName("Marital_Status_Type_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MedicalBenefitTbl>(entity =>
            {
                entity.HasKey(e => e.MedicalBenefitId);

                entity.ToTable("Medical_Benefit_Tbl");

                entity.Property(e => e.MedicalBenefitId).HasColumnName("Medical_Benefit_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.HasValueYn).HasColumnName("Has_Value_YN");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.MedicalBenefitArName)
                    .HasColumnName("Medical_Benefit_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.MedicalBenefitArNameShadow)
                    .HasColumnName("Medical_Benefit_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.MedicalBenefitCode)
                    .HasColumnName("Medical_Benefit_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.MedicalBenefitEnName)
                    .HasColumnName("Medical_Benefit_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.RepeatEveryMonths).HasColumnName("Repeat_Every_Months");

                entity.Property(e => e.RepeatableYn).HasColumnName("Repeatable_YN");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<MedicalBenefitTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.MedicalBenefitTransactionId);

                entity.ToTable("Medical_Benefit_Transaction_Tbl");

                entity.Property(e => e.MedicalBenefitTransactionId).HasColumnName("Medical_Benefit_Transaction_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.MedicalBenefitDate)
                    .HasColumnName("Medical_Benefit_Date")
                    .HasColumnType("date");

                entity.Property(e => e.MedicalBenefitId).HasColumnName("Medical_Benefit_ID");

                entity.Property(e => e.MedicalBenefitValue).HasColumnName("Medical_Benefit_Value");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.RepeateDate)
                    .HasColumnName("Repeate_Date")
                    .HasColumnType("date");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.MedicalBenefit)
                    .WithMany(p => p.MedicalBenefitTransactionTbl)
                    .HasForeignKey(d => d.MedicalBenefitId)
                    .HasConstraintName("FK_Medical_Benefit_Transaction_Tbl_Medical_Benefit_Tbl");
            });

            modelBuilder.Entity<MedicalCardsTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.MedicalCardsTransactionId);

                entity.ToTable("Medical_Cards_Transaction_Tbl");

                entity.Property(e => e.MedicalCardsTransactionId).HasColumnName("Medical_Cards_Transaction_ID");

                entity.Property(e => e.CardNumber)
                    .HasColumnName("Card_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnName("Expiry_Date")
                    .HasColumnType("date");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.IssueDate)
                    .HasColumnName("Issue_Date")
                    .HasColumnType("date");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.MaxLimit).HasColumnName("Max_Limit");

                entity.Property(e => e.MedicalTypeId).HasColumnName("Medical_Type_ID");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.StoppedYn).HasColumnName("Stopped_YN");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.MedicalCardsTransactionTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Medical_Cards_Transaction_Tbl_Employee_Tbl");

                entity.HasOne(d => d.MedicalType)
                    .WithMany(p => p.MedicalCardsTransactionTbl)
                    .HasForeignKey(d => d.MedicalTypeId)
                    .HasConstraintName("FK_Medical_Cards_Transaction_Tbl_Medical_Type_Tbl");
            });

            modelBuilder.Entity<MedicalDegreeDetailsTbl>(entity =>
            {
                entity.HasKey(e => e.MedicalDegreeDetailsId);

                entity.ToTable("Medical_Degree_Details_Tbl");

                entity.Property(e => e.MedicalDegreeDetailsId)
                    .HasColumnName("Medical_Degree_Details_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CompanyPercentage).HasColumnName("Company_Percentage");

                entity.Property(e => e.EmployeePercentage).HasColumnName("Employee_Percentage");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.MedicalDegreeId).HasColumnName("Medical_Degree_ID");

                entity.Property(e => e.MedicalValue).HasColumnName("Medical_Value");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.RelativeDegreeId).HasColumnName("Relative_Degree_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<MedicalDegreeTbl>(entity =>
            {
                entity.HasKey(e => e.MedicalDegreeId)
                    .HasName("PK_Table_3");

                entity.ToTable("Medical_Degree_Tbl");

                entity.Property(e => e.MedicalDegreeId)
                    .HasColumnName("Medical_Degree_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.MedicalDegreeArName).HasColumnName("Medical_Degree_Ar_Name");

                entity.Property(e => e.MedicalDegreeArNameShadow).HasColumnName("Medical_Degree_Ar_Name_Shadow");

                entity.Property(e => e.MedicalDegreeCode).HasColumnName("Medical_Degree_Code");

                entity.Property(e => e.MedicalDegreeEnName).HasColumnName("Medical_Degree_En_Name");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<MedicalFamilyCardsTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.MedicalFamilyCardsTransactionId);

                entity.ToTable("Medical_Family_Cards_Transaction_Tbl");

                entity.Property(e => e.MedicalFamilyCardsTransactionId).HasColumnName("Medical_Family_Cards_Transaction_ID");

                entity.Property(e => e.CardNumber)
                    .HasColumnName("Card_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.EmployeeRelativeId).HasColumnName("Employee_Relative_ID");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnName("Expiry_Date")
                    .HasColumnType("date");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.IssueDate)
                    .HasColumnName("Issue_Date")
                    .HasColumnType("date");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.MaxLimit).HasColumnName("Max_Limit");

                entity.Property(e => e.MedicalTypeId).HasColumnName("Medical_Type_ID");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.StoppedYn).HasColumnName("Stopped_YN");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.MedicalFamilyCardsTransactionTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Medical_Family_Cards_Transaction_Tbl_Employee_Tbl");

                entity.HasOne(d => d.EmployeeRelative)
                    .WithMany(p => p.MedicalFamilyCardsTransactionTbl)
                    .HasForeignKey(d => d.EmployeeRelativeId)
                    .HasConstraintName("FK_Medical_Family_Cards_Transaction_Tbl_Employee_Relative_Tbl");

                entity.HasOne(d => d.MedicalType)
                    .WithMany(p => p.MedicalFamilyCardsTransactionTbl)
                    .HasForeignKey(d => d.MedicalTypeId)
                    .HasConstraintName("FK_Medical_Family_Cards_Transaction_Tbl_Medical_Type_Tbl");
            });

            modelBuilder.Entity<MedicalFamilyInvoiceTransactionDetailsTbl>(entity =>
            {
                entity.HasKey(e => e.MedicalFamilyInvoiceTransactionDetailsId);

                entity.ToTable("Medical_Family_Invoice_Transaction_Details_Tbl");

                entity.Property(e => e.MedicalFamilyInvoiceTransactionDetailsId).HasColumnName("Medical_Family_Invoice_Transaction_Details_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.MedicalFamilyInvoiceTransactionId).HasColumnName("Medical_Family_Invoice_Transaction_ID");

                entity.Property(e => e.MedicineId).HasColumnName("Medicine_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.MedicalFamilyInvoiceTransaction)
                    .WithMany(p => p.MedicalFamilyInvoiceTransactionDetailsTbl)
                    .HasForeignKey(d => d.MedicalFamilyInvoiceTransactionId)
                    .HasConstraintName("FK_Medical_Family_Invoice_Transaction_Details_Tbl_Medical_Family_Invoice_Transaction_Tbl");

                entity.HasOne(d => d.Medicine)
                    .WithMany(p => p.MedicalFamilyInvoiceTransactionDetailsTbl)
                    .HasForeignKey(d => d.MedicineId)
                    .HasConstraintName("FK_Medical_Family_Invoice_Transaction_Details_Tbl_Medicine_Tbl");
            });

            modelBuilder.Entity<MedicalFamilyInvoiceTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.MedicalFamilyInvoiceTransactionId);

                entity.ToTable("Medical_Family_Invoice_Transaction_Tbl");

                entity.Property(e => e.MedicalFamilyInvoiceTransactionId).HasColumnName("Medical_Family_Invoice_Transaction_ID");

                entity.Property(e => e.DeductionValue).HasColumnName("Deduction_Value");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.DuductFromEmployeeYn).HasColumnName("Duduct_From_Employee_YN");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.EmployeeRelativeId).HasColumnName("Employee_Relative_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("Invoice_Date")
                    .HasColumnType("date");

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("Invoice_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.MedicineDetailsYn).HasColumnName("Medicine_Details_YN");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.TheMonth).HasColumnName("The_Month");

                entity.Property(e => e.TheYear).HasColumnName("The_Year");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.MedicalFamilyInvoiceTransactionTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Medical_Family_Invoice_Transaction_Tbl_Employee_Tbl");

                entity.HasOne(d => d.EmployeeRelative)
                    .WithMany(p => p.MedicalFamilyInvoiceTransactionTbl)
                    .HasForeignKey(d => d.EmployeeRelativeId)
                    .HasConstraintName("FK_Medical_Family_Invoice_Transaction_Tbl_Employee_Relative_Tbl");
            });

            modelBuilder.Entity<MedicalFamilyMonthlyMedicineTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.MedicalFamilyMonthlyMedicineTransactionId);

                entity.ToTable("Medical_Family_Monthly_Medicine_Transaction_Tbl");

                entity.Property(e => e.MedicalFamilyMonthlyMedicineTransactionId).HasColumnName("Medical_Family_Monthly_Medicine_Transaction_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.EmployeeRelativeId).HasColumnName("Employee_Relative_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.MedicineId).HasColumnName("Medicine_ID");

                entity.Property(e => e.MedicinePermanentYn).HasColumnName("Medicine_Permanent_YN");

                entity.Property(e => e.MedicineStoppedYn).HasColumnName("Medicine_Stopped_YN");

                entity.Property(e => e.MonthlyMedicineQty).HasColumnName("Monthly_Medicine_Qty");

                entity.Property(e => e.NoOfMonth).HasColumnName("No_Of_Month");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.TransactionDate)
                    .HasColumnName("Transaction_Date")
                    .HasColumnType("date");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.MedicalFamilyMonthlyMedicineTransactionTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Medical_Family_Monthly_Medicine_Transaction_Tbl_Employee_Tbl");

                entity.HasOne(d => d.EmployeeRelative)
                    .WithMany(p => p.MedicalFamilyMonthlyMedicineTransactionTbl)
                    .HasForeignKey(d => d.EmployeeRelativeId)
                    .HasConstraintName("FK_Medical_Family_Monthly_Medicine_Transaction_Tbl_Employee_Relative_Tbl");

                entity.HasOne(d => d.Medicine)
                    .WithMany(p => p.MedicalFamilyMonthlyMedicineTransactionTbl)
                    .HasForeignKey(d => d.MedicineId)
                    .HasConstraintName("FK_Medical_Family_Monthly_Medicine_Transaction_Tbl_Medicine_Tbl");
            });

            modelBuilder.Entity<MedicalFamilyVisitTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.MedicalFamilyVisitTransactionId);

                entity.ToTable("Medical_Family_Visit_Transaction_Tbl");

                entity.Property(e => e.MedicalFamilyVisitTransactionId).HasColumnName("Medical_Family_Visit_Transaction_ID");

                entity.Property(e => e.DeductionValue).HasColumnName("Deduction_Value");

                entity.Property(e => e.Diagnosis).HasMaxLength(500);

                entity.Property(e => e.DiseaseId).HasColumnName("Disease_ID");

                entity.Property(e => e.Doctor).HasMaxLength(100);

                entity.Property(e => e.DuductFromEmployeeYn).HasColumnName("Duduct_From_Employee_YN");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.EmployeeRelativeId).HasColumnName("Employee_Relative_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.InternalYn).HasColumnName("Internal_YN");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.NoOfDays).HasColumnName("No_Of_Days");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.SpecialityId).HasColumnName("Speciality_ID");

                entity.Property(e => e.SysMedicalVacationTypeId).HasColumnName("Sys_Medical_Vacation_Type_ID");

                entity.Property(e => e.TheMonth).HasColumnName("The_Month");

                entity.Property(e => e.TheYear).HasColumnName("The_Year");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.Property(e => e.VisitDate)
                    .HasColumnName("Visit_Date")
                    .HasColumnType("date");

                entity.Property(e => e.VisitNumber)
                    .HasColumnName("Visit_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.VisitPlace)
                    .HasColumnName("Visit_Place")
                    .HasMaxLength(500);

                entity.Property(e => e.VisitReason)
                    .HasColumnName("Visit_Reason")
                    .HasMaxLength(500);

                entity.HasOne(d => d.Disease)
                    .WithMany(p => p.MedicalFamilyVisitTransactionTbl)
                    .HasForeignKey(d => d.DiseaseId)
                    .HasConstraintName("FK_Medical_Family_Visit_Transaction_Tbl_Disease_Tbl");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.MedicalFamilyVisitTransactionTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Medical_Family_Visit_Transaction_Tbl_Employee_Tbl");

                entity.HasOne(d => d.EmployeeRelative)
                    .WithMany(p => p.MedicalFamilyVisitTransactionTbl)
                    .HasForeignKey(d => d.EmployeeRelativeId)
                    .HasConstraintName("FK_Medical_Family_Visit_Transaction_Tbl_Employee_Relative_Tbl");

                entity.HasOne(d => d.Speciality)
                    .WithMany(p => p.MedicalFamilyVisitTransactionTbl)
                    .HasForeignKey(d => d.SpecialityId)
                    .HasConstraintName("FK_Medical_Family_Visit_Transaction_Tbl_Speciality_Tbl");
            });

            modelBuilder.Entity<MedicalInvoiceTransactionDetailsTbl>(entity =>
            {
                entity.HasKey(e => e.MedicalInvoiceTransactionDetailsId)
                    .HasName("PK_Medical_Invoce_Transaction_Details_Tbl");

                entity.ToTable("Medical_Invoice_Transaction_Details_Tbl");

                entity.Property(e => e.MedicalInvoiceTransactionDetailsId).HasColumnName("Medical_Invoice_Transaction_Details_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.MedicalInvoiceTransactionId).HasColumnName("Medical_Invoice_Transaction_ID");

                entity.Property(e => e.MedicineId).HasColumnName("Medicine_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.MedicalInvoiceTransaction)
                    .WithMany(p => p.MedicalInvoiceTransactionDetailsTbl)
                    .HasForeignKey(d => d.MedicalInvoiceTransactionId)
                    .HasConstraintName("FK_Medical_Invoice_Transaction_Details_Tbl_Medical_Invoice_Transaction_Tbl");

                entity.HasOne(d => d.Medicine)
                    .WithMany(p => p.MedicalInvoiceTransactionDetailsTbl)
                    .HasForeignKey(d => d.MedicineId)
                    .HasConstraintName("FK_Medical_Invoice_Transaction_Details_Tbl_Medicine_Tbl");
            });

            modelBuilder.Entity<MedicalInvoiceTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.MedicalInvoiceTransactionId)
                    .HasName("PK_Medical_Invoce_Transaction_Tbl");

                entity.ToTable("Medical_Invoice_Transaction_Tbl");

                entity.Property(e => e.MedicalInvoiceTransactionId).HasColumnName("Medical_Invoice_Transaction_ID");

                entity.Property(e => e.DeductionValue).HasColumnName("Deduction_Value");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.DuductFromEmployeeYn).HasColumnName("Duduct_From_Employee_YN");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("Invoice_Date")
                    .HasColumnType("date");

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("Invoice_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.MedicineDetailsYn).HasColumnName("Medicine_Details_YN");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.TheMonth).HasColumnName("The_Month");

                entity.Property(e => e.TheYear).HasColumnName("The_Year");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.MedicalInvoiceTransactionTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Medical_Invoice_Transaction_Tbl_Employee_Tbl");
            });

            modelBuilder.Entity<MedicalMonthlyMedicineTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.MedicalMonthlyMedicineTransactionId);

                entity.ToTable("Medical_Monthly_Medicine_Transaction_Tbl");

                entity.Property(e => e.MedicalMonthlyMedicineTransactionId).HasColumnName("Medical_Monthly_Medicine_Transaction_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.MedicineId).HasColumnName("Medicine_ID");

                entity.Property(e => e.MedicinePermanentYn).HasColumnName("Medicine_Permanent_YN");

                entity.Property(e => e.MedicineStoppedYn).HasColumnName("Medicine_Stopped_YN");

                entity.Property(e => e.MonthlyMedicineQty).HasColumnName("Monthly_Medicine_Qty");

                entity.Property(e => e.NoOfMonth).HasColumnName("No_Of_Month");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.TransactionDate)
                    .HasColumnName("Transaction_Date")
                    .HasColumnType("date");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<MedicalTypeTbl>(entity =>
            {
                entity.HasKey(e => e.MedicalTypeId);

                entity.ToTable("Medical_Type_Tbl");

                entity.Property(e => e.MedicalTypeId).HasColumnName("Medical_Type_ID");

                entity.Property(e => e.ExpiryMonths).HasColumnName("Expiry_Months");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.MedicalTypeArName)
                    .HasColumnName("Medical_Type_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.MedicalTypeArNameShadow)
                    .HasColumnName("Medical_Type_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.MedicalTypeCode)
                    .HasColumnName("Medical_Type_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.MedicalTypeEnName)
                    .HasColumnName("Medical_Type_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.SingleFamily).HasColumnName("Single_Family");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<MedicalVisitTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.MedicalVisitTransactionId);

                entity.ToTable("Medical_Visit_Transaction_Tbl");

                entity.Property(e => e.MedicalVisitTransactionId).HasColumnName("Medical_Visit_Transaction_ID");

                entity.Property(e => e.DeductionValue).HasColumnName("Deduction_Value");

                entity.Property(e => e.Diagnosis).HasMaxLength(500);

                entity.Property(e => e.DiseaseId).HasColumnName("Disease_ID");

                entity.Property(e => e.Doctor).HasMaxLength(100);

                entity.Property(e => e.DuductFromEmployeeYn).HasColumnName("Duduct_From_Employee_YN");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.InternalYn).HasColumnName("Internal_YN");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.NoOfDays).HasColumnName("No_Of_Days");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.SpecialityId).HasColumnName("Speciality_ID");

                entity.Property(e => e.SysMedicalVacationTypeId).HasColumnName("Sys_Medical_Vacation_Type_ID");

                entity.Property(e => e.TheMonth).HasColumnName("The_Month");

                entity.Property(e => e.TheYear).HasColumnName("The_Year");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.Property(e => e.VisitDate)
                    .HasColumnName("Visit_Date")
                    .HasColumnType("date");

                entity.Property(e => e.VisitNumber)
                    .HasColumnName("Visit_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.VisitPlace)
                    .HasColumnName("Visit_Place")
                    .HasMaxLength(500);

                entity.Property(e => e.VisitReason)
                    .HasColumnName("Visit_Reason")
                    .HasMaxLength(500);

                entity.HasOne(d => d.Disease)
                    .WithMany(p => p.MedicalVisitTransactionTbl)
                    .HasForeignKey(d => d.DiseaseId)
                    .HasConstraintName("FK_Medical_Visit_Transaction_Tbl_Disease_Tbl");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.MedicalVisitTransactionTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Medical_Visit_Transaction_Tbl_Employee_Tbl");

                entity.HasOne(d => d.Speciality)
                    .WithMany(p => p.MedicalVisitTransactionTbl)
                    .HasForeignKey(d => d.SpecialityId)
                    .HasConstraintName("FK_Medical_Visit_Transaction_Tbl_Speciality_Tbl");
            });

            modelBuilder.Entity<MedicineTbl>(entity =>
            {
                entity.HasKey(e => e.MedicineId);

                entity.ToTable("Medicine_Tbl");

                entity.Property(e => e.MedicineId).HasColumnName("Medicine_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.MedicineArName)
                    .HasColumnName("Medicine_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.MedicineArNameShadow)
                    .HasColumnName("Medicine_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.MedicineCode)
                    .HasColumnName("Medicine_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.MedicineEnName)
                    .HasColumnName("Medicine_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<MilitaryStatusTbl>(entity =>
            {
                entity.HasKey(e => e.MilitaryStatusId);

                entity.ToTable("Military_Status_Tbl");

                entity.Property(e => e.MilitaryStatusId).HasColumnName("Military_Status_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.MilitaryStatusArName)
                    .HasColumnName("Military_Status_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.MilitaryStatusArNameShadow)
                    .HasColumnName("Military_Status_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.MilitaryStatusCode)
                    .HasColumnName("Military_Status_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.MilitaryStatusEnName)
                    .HasColumnName("Military_Status_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<MissionExpensesTransactionTbl>(entity =>
            {
                entity.HasKey(e => new { e.MissionExpensesTransactionId, e.AttendanceTypeId });

                entity.ToTable("Mission_Expenses_Transaction_Tbl");

                entity.Property(e => e.MissionExpensesTransactionId)
                    .HasColumnName("Mission_Expenses_Transaction_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AttendanceTypeId)
                    .HasColumnName("Attendance_Type_ID")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('M')");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.MissionExpensesTypeId).HasColumnName("Mission_Expenses_Type_ID");

                entity.Property(e => e.MissionTransactionId).HasColumnName("Mission_Transaction_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.MissionExpensesType)
                    .WithMany(p => p.MissionExpensesTransactionTbl)
                    .HasForeignKey(d => d.MissionExpensesTypeId)
                    .HasConstraintName("FK_Mission_Expenses_Transaction_Tbl_Mission_Expenses_Type_Tbl");
            });

            modelBuilder.Entity<MissionExpensesTypeTbl>(entity =>
            {
                entity.HasKey(e => e.MissionExpensesTypeId);

                entity.ToTable("Mission_Expenses_Type_Tbl");

                entity.Property(e => e.MissionExpensesTypeId).HasColumnName("Mission_Expenses_Type_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.MissionExpensesTypeArName)
                    .HasColumnName("Mission_Expenses_Type_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.MissionExpensesTypeArNameShadow)
                    .HasColumnName("Mission_Expenses_Type_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.MissionExpensesTypeCode)
                    .HasColumnName("Mission_Expenses_Type_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.MissionExpensesTypeEnName)
                    .HasColumnName("Mission_Expenses_Type_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<MissionTransactionTbl>(entity =>
            {
                entity.HasKey(e => new { e.MissionTransactionId, e.AttendanceTypeId });

                entity.ToTable("Mission_Transaction_Tbl");

                entity.Property(e => e.MissionTransactionId)
                    .HasColumnName("Mission_Transaction_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AttendanceTypeId)
                    .HasColumnName("Attendance_Type_ID")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('M')");

                entity.Property(e => e.AbroadYn).HasColumnName("Abroad_YN");

                entity.Property(e => e.DaysNumber).HasColumnName("Days_Number");

                entity.Property(e => e.Destination).HasMaxLength(100);

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.FromDate)
                    .HasColumnName("From_Date")
                    .HasColumnType("date");

                entity.Property(e => e.FromTime).HasColumnName("From_Time");

                entity.Property(e => e.FullDayYn).HasColumnName("Full_Day_YN");

                entity.Property(e => e.IdBeforeDistribution).HasColumnName("ID_Before_Distribution");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.OverlappingTypeId).HasColumnName("Overlapping_Type_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.Reason).HasMaxLength(100);

                entity.Property(e => e.SysRequestStatusId).HasColumnName("Sys_Request_Status_ID");

                entity.Property(e => e.ToDate)
                    .HasColumnName("To_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ToTime).HasColumnName("To_Time");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.MissionTransactionTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Mission_Transaction_Tbl_Employee_Tbl");

                entity.HasOne(d => d.SysRequestStatus)
                    .WithMany(p => p.MissionTransactionTbl)
                    .HasForeignKey(d => d.SysRequestStatusId)
                    .HasConstraintName("FK_Mission_Transaction_Tbl_Sys_Request_Status_ID");
            });

            modelBuilder.Entity<ModuleGenericEmailTbl>(entity =>
            {
                entity.HasKey(e => e.ModuleGenericEmailId);

                entity.ToTable("Module_Generic_Email_Tbl");

                entity.Property(e => e.ModuleGenericEmailId).HasColumnName("Module_Generic_Email_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.ModuleGenericEmailAddress).HasColumnName("Module_Generic_Email_Address");

                entity.Property(e => e.ModuleGenericEmailDisplayEnName)
                    .HasColumnName("Module_Generic_Email_Display_En_Name")
                    .HasMaxLength(150);

                entity.Property(e => e.ModuleGenericEmailPassword).HasColumnName("Module_Generic_Email_Password");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.SysEmailTypeId).HasColumnName("Sys_Email_Type_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.ModuleGenericEmailTbl)
                    .HasForeignKey(d => d.PropertyId)
                    .HasConstraintName("FK_Module_Generic_Email_Tbl_Property_Tbl");

                entity.HasOne(d => d.SysEmailType)
                    .WithMany(p => p.ModuleGenericEmailTbl)
                    .HasForeignKey(d => d.SysEmailTypeId)
                    .HasConstraintName("FK_Module_Generic_Email_Tbl_Sys_Email_Type_Tbl");
            });

            modelBuilder.Entity<MonthTbl>(entity =>
            {
                entity.HasKey(e => e.MonthId);

                entity.ToTable("Month_Tbl");

                entity.Property(e => e.MonthId)
                    .HasColumnName("Month_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.MonthArName)
                    .HasColumnName("Month_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.MonthEnName)
                    .HasColumnName("Month_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MonthlyActualAttendanceTbl>(entity =>
            {
                entity.HasKey(e => e.MonthlyActualAttendanceId);

                entity.ToTable("Monthly_Actual_Attendance_Tbl");

                entity.Property(e => e.MonthlyActualAttendanceId).HasColumnName("Monthly_Actual_Attendance_ID");

                entity.Property(e => e.Day1).HasColumnName("Day_1");

                entity.Property(e => e.Day10).HasColumnName("Day_10");

                entity.Property(e => e.Day11).HasColumnName("Day_11");

                entity.Property(e => e.Day12).HasColumnName("Day_12");

                entity.Property(e => e.Day13).HasColumnName("Day_13");

                entity.Property(e => e.Day14).HasColumnName("Day_14");

                entity.Property(e => e.Day15).HasColumnName("Day_15");

                entity.Property(e => e.Day16).HasColumnName("Day_16");

                entity.Property(e => e.Day17).HasColumnName("Day_17");

                entity.Property(e => e.Day18).HasColumnName("Day_18");

                entity.Property(e => e.Day19).HasColumnName("Day_19");

                entity.Property(e => e.Day2).HasColumnName("Day_2");

                entity.Property(e => e.Day20).HasColumnName("Day_20");

                entity.Property(e => e.Day21).HasColumnName("Day_21");

                entity.Property(e => e.Day22).HasColumnName("Day_22");

                entity.Property(e => e.Day23).HasColumnName("Day_23");

                entity.Property(e => e.Day24).HasColumnName("Day_24");

                entity.Property(e => e.Day25).HasColumnName("Day_25");

                entity.Property(e => e.Day26).HasColumnName("Day_26");

                entity.Property(e => e.Day27).HasColumnName("Day_27");

                entity.Property(e => e.Day28).HasColumnName("Day_28");

                entity.Property(e => e.Day29).HasColumnName("Day_29");

                entity.Property(e => e.Day3).HasColumnName("Day_3");

                entity.Property(e => e.Day30).HasColumnName("Day_30");

                entity.Property(e => e.Day31).HasColumnName("Day_31");

                entity.Property(e => e.Day4).HasColumnName("Day_4");

                entity.Property(e => e.Day5).HasColumnName("Day_5");

                entity.Property(e => e.Day6).HasColumnName("Day_6");

                entity.Property(e => e.Day7).HasColumnName("Day_7");

                entity.Property(e => e.Day8).HasColumnName("Day_8");

                entity.Property(e => e.Day9).HasColumnName("Day_9");

                entity.Property(e => e.HierarchyId).HasColumnName("Hierarchy_ID");

                entity.Property(e => e.HierarchyType)
                    .HasColumnName("Hierarchy_Type")
                    .HasMaxLength(5);

                entity.Property(e => e.ManagerStaff).HasColumnName("Manager_Staff");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");
            });

            modelBuilder.Entity<MonthlyCalculationsTbl>(entity =>
            {
                entity.HasKey(e => e.MonthlyCalculationsId);

                entity.ToTable("Monthly_Calculations_Tbl");

                entity.Property(e => e.MonthlyCalculationsId).HasColumnName("Monthly_Calculations_ID");

                entity.Property(e => e.ExportJvYn).HasColumnName("Export_JV_YN");

                entity.Property(e => e.LockSelfServiceYn).HasColumnName("Lock_Self_Service_YN");

                entity.Property(e => e.PaidYn).HasColumnName("Paid_YN");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.SalaryCalculationYn).HasColumnName("Salary_Calculation_YN");

                entity.Property(e => e.ServiceChargeCalculationYn).HasColumnName("Service_Charge_Calculation_YN");

                entity.Property(e => e.TaxBalanceYn).HasColumnName("Tax_Balance_YN");

                entity.Property(e => e.TheMonth).HasColumnName("The_Month");

                entity.Property(e => e.TheYear).HasColumnName("The_Year");

                entity.Property(e => e.TransferDataYn).HasColumnName("Transfer_Data_YN");

                entity.Property(e => e.VacationCalculationYn).HasColumnName("Vacation_Calculation_YN");
            });

            modelBuilder.Entity<MonthlyCurrencyRateTbl>(entity =>
            {
                entity.HasKey(e => e.MonthlyCurrencyRateId);

                entity.ToTable("Monthly_Currency_Rate_Tbl");

                entity.Property(e => e.MonthlyCurrencyRateId).HasColumnName("Monthly_Currency_Rate_ID");

                entity.Property(e => e.CurrencyId).HasColumnName("Currency_ID");

                entity.Property(e => e.CurrencyRate).HasColumnName("Currency_Rate");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.TheMonth).HasColumnName("The_Month");

                entity.Property(e => e.TheYear).HasColumnName("The_Year");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<MonthlyTicketRateTbl>(entity =>
            {
                entity.HasKey(e => e.MonthlyTicketRateId);

                entity.ToTable("Monthly_Ticket_Rate_Tbl");

                entity.Property(e => e.MonthlyTicketRateId).HasColumnName("Monthly_Ticket_Rate_ID");

                entity.Property(e => e.AirplaneDestinationId).HasColumnName("Airplane_Destination_ID");

                entity.Property(e => e.ChildRate).HasColumnName("Child_Rate");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.TheMonth).HasColumnName("The_Month");

                entity.Property(e => e.TheYear).HasColumnName("The_Year");

                entity.Property(e => e.TicketRate).HasColumnName("Ticket_Rate");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.AirplaneDestination)
                    .WithMany(p => p.MonthlyTicketRateTbl)
                    .HasForeignKey(d => d.AirplaneDestinationId)
                    .HasConstraintName("FK_Monthly_Ticket_Rate_Tbl_Airplane_Destination_Tbl");
            });

            modelBuilder.Entity<MonthlyWorkingHoursTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.MonthlyWorkingHoursTransactionId);

                entity.ToTable("Monthly_Working_Hours_Transaction_Tbl");

                entity.Property(e => e.MonthlyWorkingHoursTransactionId).HasColumnName("Monthly_Working_Hours_Transaction_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.HoursNumber).HasColumnName("Hours_Number");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.TheMonth).HasColumnName("The_Month");

                entity.Property(e => e.TheYear).HasColumnName("The_Year");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.MonthlyWorkingHoursTransactionTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Monthly_Working_Hours_Transaction_Tbl_Employee_Tbl");
            });

            modelBuilder.Entity<NationalityTbl>(entity =>
            {
                entity.HasKey(e => e.NationalityId);

                entity.ToTable("Nationality_Tbl");

                entity.Property(e => e.NationalityId).HasColumnName("Nationality_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.NationalityArName)
                    .HasColumnName("Nationality_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.NationalityArNameShadow)
                    .HasColumnName("Nationality_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.NationalityCode)
                    .HasColumnName("Nationality_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.NationalityEnName)
                    .HasColumnName("Nationality_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<NotificationConfigurationTbl>(entity =>
            {
                entity.HasKey(e => e.NotificationConfigurationId)
                    .HasName("PK_Notification_CC_Email_Tbl");

                entity.ToTable("Notification_Configuration_Tbl");

                entity.Property(e => e.NotificationConfigurationId).HasColumnName("Notification_Configuration_ID");

                entity.Property(e => e.AnotherEmail)
                    .HasColumnName("Another_Email")
                    .HasMaxLength(50);

                entity.Property(e => e.CcEmail).HasColumnName("CC_Email");

                entity.Property(e => e.CcSms).HasColumnName("CC_SMS");

                entity.Property(e => e.EmailMessage).HasColumnName("Email_Message");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.RepeatSendingEmailsEveryXDays).HasColumnName("Repeat_Sending_Emails_Every_X_Days");

                entity.Property(e => e.RepeatSendingSmsEveryXDays).HasColumnName("Repeat_Sending_SMS_Every_X_Days");

                entity.Property(e => e.SendEmailAtXOclock).HasColumnName("Send_Email_At_X_Oclock");

                entity.Property(e => e.SendEmailBeforeEventByXDays).HasColumnName("Send_Email_Before_Event_By_X_Days");

                entity.Property(e => e.SendEmailsAutomaticallyYn).HasColumnName("Send_Emails_Automatically_YN");

                entity.Property(e => e.SendSmsAtXOclock).HasColumnName("Send_SMS_At_X_Oclock");

                entity.Property(e => e.SendSmsAutomaticallyYn).HasColumnName("Send_SMS_Automatically_YN");

                entity.Property(e => e.SendSmsBeforeEventByXDays).HasColumnName("Send_SMS_Before_Event_By_X_Days");

                entity.Property(e => e.SmsMessage).HasColumnName("SMS_Message");

                entity.Property(e => e.SysNotificationFieldId).HasColumnName("Sys_Notification_Field_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<OrganizationLegalFormTbl>(entity =>
            {
                entity.HasKey(e => e.OrganizationLegalFormId);

                entity.ToTable("Organization_Legal_Form_Tbl");

                entity.Property(e => e.OrganizationLegalFormId).HasColumnName("Organization_Legal_Form_ID");

                entity.Property(e => e.Area).HasMaxLength(100);

                entity.Property(e => e.BuildingNumber)
                    .HasColumnName("Building_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.CompanyInsuranceCreditAccountNumberId).HasColumnName("Company_Insurance_Credit_Account_Number_ID");

                entity.Property(e => e.CompanyInsuranceCreditHealthAccountNumberId).HasColumnName("Company_Insurance_Credit_Health_Account_Number_ID");

                entity.Property(e => e.CompanyInsuranceDebitAccountNumberId).HasColumnName("Company_Insurance_Debit_Account_Number_ID");

                entity.Property(e => e.CompanyInsuranceDebitHealthAccountNumberId).HasColumnName("Company_Insurance_Debit_Health_Account_Number_ID");

                entity.Property(e => e.DiseaseInsuranceRate)
                    .HasColumnName("Disease_Insurance_Rate")
                    .HasMaxLength(10);

                entity.Property(e => e.DiseaseStartingDate)
                    .HasColumnName("Disease_Starting_Date")
                    .HasColumnType("date");

                entity.Property(e => e.EmployeeHealthInsuranceAccountNumberId).HasColumnName("Employee_Health_Insurance_Account_Number_ID");

                entity.Property(e => e.EmployeeInsuranceAccountNumberId).HasColumnName("Employee_Insurance_Account_Number_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.GovernorateId).HasColumnName("Governorate_ID");

                entity.Property(e => e.InfectInsuranceRate)
                    .HasColumnName("Infect_Insurance_Rate")
                    .HasMaxLength(10);

                entity.Property(e => e.InfectStartingDate)
                    .HasColumnName("Infect_Starting_Date")
                    .HasColumnType("date");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.InsuranceJournalType)
                    .HasColumnName("Insurance_Journal_Type")
                    .HasMaxLength(10);

                entity.Property(e => e.InsuranceNumber)
                    .HasColumnName("Insurance_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.InsuranceOfficeId).HasColumnName("Insurance_Office_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.OrganizationCode)
                    .HasColumnName("Organization_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.OrganizationLegalFormArName)
                    .HasColumnName("Organization_Legal_Form_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.OrganizationLegalFormArNameShadow)
                    .HasColumnName("Organization_Legal_Form_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.OrganizationLegalFormDescription)
                    .HasColumnName("Organization_Legal_Form_Description")
                    .HasMaxLength(100);

                entity.Property(e => e.OrganizationLegalFormEnName)
                    .HasColumnName("Organization_Legal_Form_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.PositionOfArticle42)
                    .HasColumnName("Position_Of_Article_42")
                    .HasMaxLength(100);

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.StartActivity)
                    .HasColumnName("Start_Activity")
                    .HasMaxLength(100);

                entity.Property(e => e.Station).HasMaxLength(100);

                entity.Property(e => e.StopContinuationDate)
                    .HasColumnName("Stop_Continuation_Date")
                    .HasColumnType("date");

                entity.Property(e => e.StopReason)
                    .HasColumnName("Stop_Reason")
                    .HasMaxLength(100);

                entity.Property(e => e.StreetName)
                    .HasColumnName("Street_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.TaxFileNumber)
                    .HasColumnName("Tax_File_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.TaxOffice)
                    .HasColumnName("Tax_Office")
                    .HasMaxLength(100);

                entity.Property(e => e.TaxOfficeAddress)
                    .HasColumnName("Tax_Office_Address")
                    .HasMaxLength(200);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.Property(e => e.Village).HasMaxLength(100);

                entity.HasOne(d => d.Governorate)
                    .WithMany(p => p.OrganizationLegalFormTbl)
                    .HasForeignKey(d => d.GovernorateId)
                    .HasConstraintName("FK_Organization_Legal_Form_Tbl_Governorate_Tbl");

                entity.HasOne(d => d.InsuranceOffice)
                    .WithMany(p => p.OrganizationLegalFormTbl)
                    .HasForeignKey(d => d.InsuranceOfficeId)
                    .HasConstraintName("FK_Organization_Legal_Form_Tbl_Insurance_Office_Tbl");
            });

            modelBuilder.Entity<OverTimeTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.OverTimeTransactionId);

                entity.ToTable("Over_Time_Transaction_Tbl");

                entity.Property(e => e.OverTimeTransactionId).HasColumnName("Over_Time_Transaction_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.GmApprovedYn).HasColumnName("GM_Approved_YN");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.OverTimeDate)
                    .HasColumnName("Over_Time_Date")
                    .HasColumnType("date");

                entity.Property(e => e.OverTimeHours).HasColumnName("Over_Time_Hours");

                entity.Property(e => e.OverTimeMinutes).HasColumnName("Over_Time_Minutes");

                entity.Property(e => e.OverTimeTotalHours).HasColumnName("Over_Time_Total_Hours");

                entity.Property(e => e.OverTimeTotalMinutes).HasColumnName("Over_Time_Total_Minutes");

                entity.Property(e => e.OverTimeTypeId).HasColumnName("Over_Time_Type_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.ThroughMachineYn).HasColumnName("Through_Machine_YN");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.OverTimeTransactionTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Over_Time_Transaction_Tbl_Employee_Tbl");

                entity.HasOne(d => d.OverTimeType)
                    .WithMany(p => p.OverTimeTransactionTbl)
                    .HasForeignKey(d => d.OverTimeTypeId)
                    .HasConstraintName("FK_Over_Time_Transaction_Tbl_Over_Time_Type_Tbl");
            });

            modelBuilder.Entity<OverTimeTypeTbl>(entity =>
            {
                entity.HasKey(e => e.OverTimeTypeId);

                entity.ToTable("Over_Time_Type_Tbl");

                entity.Property(e => e.OverTimeTypeId).HasColumnName("Over_Time_Type_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.OverTimeTypeArName)
                    .HasColumnName("Over_Time_Type_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.OverTimeTypeArNameShadow)
                    .HasColumnName("Over_Time_Type_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.OverTimeTypeCode)
                    .HasColumnName("Over_Time_Type_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.OverTimeTypeEnName)
                    .HasColumnName("Over_Time_Type_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.OverTimeTypeRate).HasColumnName("Over_Time_Type_Rate");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<PastExperiencePlaceTbl>(entity =>
            {
                entity.HasKey(e => e.PastExperiencePlaceId);

                entity.ToTable("Past_Experience_Place_Tbl");

                entity.Property(e => e.PastExperiencePlaceId).HasColumnName("Past_Experience_Place_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PastExperiencePlaceArName)
                    .HasColumnName("Past_Experience_Place_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.PastExperiencePlaceArNameShadow)
                    .HasColumnName("Past_Experience_Place_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.PastExperiencePlaceCode)
                    .HasColumnName("Past_Experience_Place_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PastExperiencePlaceEnName)
                    .HasColumnName("Past_Experience_Place_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<PastExperienceTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.PastExperienceTransactionId);

                entity.ToTable("Past_Experience_Transaction_Tbl");

                entity.Property(e => e.PastExperienceTransactionId).HasColumnName("Past_Experience_Transaction_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.FromDate)
                    .HasColumnName("From_Date")
                    .HasColumnType("date");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.PastExperiencePlaceId).HasColumnName("Past_Experience_Place_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.ToDate)
                    .HasColumnName("To_Date")
                    .HasColumnType("date");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.PastExperienceTransactionTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Past_Experience_Transaction_Tbl_Employee_Tbl");

                entity.HasOne(d => d.PastExperiencePlace)
                    .WithMany(p => p.PastExperienceTransactionTbl)
                    .HasForeignKey(d => d.PastExperiencePlaceId)
                    .HasConstraintName("FK_Past_Experience_Transaction_Tbl_Past_Experience_Place_Tbl");
            });

            modelBuilder.Entity<PaymentDetailsTbl>(entity =>
            {
                entity.HasKey(e => new { e.PaymentId, e.LinkedPaymentId })
                    .HasName("PK_Payment_Details_Tbl_1");

                entity.ToTable("Payment_Details_Tbl");

                entity.Property(e => e.PaymentId).HasColumnName("Payment_ID");

                entity.Property(e => e.LinkedPaymentId).HasColumnName("Linked_Payment_ID");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.PaymentDetailsTbl)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_Payment_Details_Tbl_Payment_Tbl");
            });

            modelBuilder.Entity<PaymentFunctionTbl>(entity =>
            {
                entity.HasKey(e => e.PaymentFunctionId);

                entity.ToTable("Payment_Function_Tbl");

                entity.Property(e => e.PaymentFunctionId).HasColumnName("Payment_Function_ID");

                entity.Property(e => e.PaymentFunctionArName)
                    .HasColumnName("Payment_Function_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.PaymentFunctionEnName)
                    .HasColumnName("Payment_Function_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PaymentGroupDetailsTbl>(entity =>
            {
                entity.HasKey(e => new { e.PaymentGroupId, e.PaymentId })
                    .HasName("PK_Payment_Group_Details_Tbl_1");

                entity.ToTable("Payment_Group_Details_Tbl");

                entity.Property(e => e.PaymentGroupId).HasColumnName("Payment_Group_ID");

                entity.Property(e => e.PaymentId).HasColumnName("Payment_ID");

                entity.HasOne(d => d.PaymentGroup)
                    .WithMany(p => p.PaymentGroupDetailsTbl)
                    .HasForeignKey(d => d.PaymentGroupId)
                    .HasConstraintName("FK_Payment_Group_Details_Tbl_Payment_Group_Tbl");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.PaymentGroupDetailsTbl)
                    .HasForeignKey(d => d.PaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payment_Group_Details_Tbl_Payment_Tbl");
            });

            modelBuilder.Entity<PaymentGroupTbl>(entity =>
            {
                entity.HasKey(e => e.PaymentGroupId);

                entity.ToTable("Payment_Group_Tbl");

                entity.Property(e => e.PaymentGroupId).HasColumnName("Payment_Group_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PaymentGroupArName)
                    .HasColumnName("Payment_Group_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.PaymentGroupArNameShadow)
                    .HasColumnName("Payment_Group_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.PaymentGroupCode)
                    .HasColumnName("Payment_Group_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PaymentGroupEnName)
                    .HasColumnName("Payment_Group_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.ShowInPayslipYn)
                    .HasColumnName("Show_In_Payslip_YN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<PaymentModeTypeTbl>(entity =>
            {
                entity.HasKey(e => e.PaymentModeTypeId);

                entity.ToTable("Payment_Mode_Type_Tbl");

                entity.Property(e => e.PaymentModeTypeId).HasColumnName("Payment_Mode_Type_ID");

                entity.Property(e => e.PaymentModeTypeArName)
                    .HasColumnName("Payment_Mode_Type_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.PaymentModeTypeEnName)
                    .HasColumnName("Payment_Mode_Type_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PaymentStatusTbl>(entity =>
            {
                entity.HasKey(e => e.PaymentStatusId);

                entity.ToTable("Payment_Status_Tbl");

                entity.Property(e => e.PaymentStatusId).HasColumnName("Payment_Status_ID");

                entity.Property(e => e.PaymentStatusArName)
                    .HasColumnName("Payment_Status_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.PaymentStatusEnName)
                    .HasColumnName("Payment_Status_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PaymentTbl>(entity =>
            {
                entity.HasKey(e => e.PaymentId);

                entity.ToTable("Payment_Tbl");

                entity.Property(e => e.PaymentId).HasColumnName("Payment_ID");

                entity.Property(e => e.AccountNumberId).HasColumnName("Account_Number_ID");

                entity.Property(e => e.AddToBasicInMonth).HasColumnName("Add_To_Basic_In_Month");

                entity.Property(e => e.AddToBasicInYear).HasColumnName("Add_To_Basic_In_Year");

                entity.Property(e => e.AddToBasicYn).HasColumnName("Add_To_Basic_YN");

                entity.Property(e => e.BasicPaymentYn).HasColumnName("Basic_Payment_YN");

                entity.Property(e => e.DaysHoursFactor).HasColumnName("Days_Hours_Factor");

                entity.Property(e => e.EffectInServiceChargeYn).HasColumnName("Effect_In_Service_Charge_YN");

                entity.Property(e => e.FixedAmountYn).HasColumnName("Fixed_Amount_YN");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.GrossSalaryYn).HasColumnName("Gross_Salary_YN");

                entity.Property(e => e.HrControlYn).HasColumnName("HR_Control_YN");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.InsuranceStatusId).HasColumnName("Insurance_Status_ID");

                entity.Property(e => e.InterfaceYn).HasColumnName("Interface_YN");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.MaximumAmount).HasColumnName("Maximum_Amount");

                entity.Property(e => e.MinimumAmount).HasColumnName("Minimum_Amount");

                entity.Property(e => e.PaymentArName)
                    .HasColumnName("Payment_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.PaymentArNameShadow)
                    .HasColumnName("Payment_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.PaymentArShortName)
                    .HasColumnName("Payment_Ar_Short_Name")
                    .HasMaxLength(20);

                entity.Property(e => e.PaymentCode)
                    .HasColumnName("Payment_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PaymentContinuity).HasColumnName("Payment_Continuity");

                entity.Property(e => e.PaymentEnName)
                    .HasColumnName("Payment_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.PaymentEnShortName)
                    .HasColumnName("Payment_En_Short_Name")
                    .HasMaxLength(20);

                entity.Property(e => e.PaymentGroupId).HasColumnName("Payment_Group_ID");

                entity.Property(e => e.PaymentStatusId).HasColumnName("Payment_Status_ID");

                entity.Property(e => e.PaymentTypeId).HasColumnName("Payment_Type_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.SelectionGroupPayment).HasColumnName("Selection_Group_Payment");

                entity.Property(e => e.ShowInPayslipYn)
                    .HasColumnName("Show_In_Payslip_YN")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TaxableYn).HasColumnName("Taxable_YN");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.AccountNumber)
                    .WithMany(p => p.PaymentTbl)
                    .HasForeignKey(d => d.AccountNumberId)
                    .HasConstraintName("FK_Payment_Tbl_Account_Number_Tbl");

                entity.HasOne(d => d.PaymentGroup)
                    .WithMany(p => p.PaymentTbl)
                    .HasForeignKey(d => d.PaymentGroupId)
                    .HasConstraintName("FK_Payment_Tbl_Payment_Group_Tbl");

                entity.HasOne(d => d.PaymentStatus)
                    .WithMany(p => p.PaymentTbl)
                    .HasForeignKey(d => d.PaymentStatusId)
                    .HasConstraintName("FK_Payment_Tbl_Payment_Status_Tbl");

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.PaymentTbl)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .HasConstraintName("FK_Payment_Tbl_Payment_Type_Tbl");
            });

            modelBuilder.Entity<PaymentTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.PaymentTransactionId);

                entity.ToTable("Payment_Transaction_Tbl");

                entity.Property(e => e.PaymentTransactionId).HasColumnName("Payment_Transaction_ID");

                entity.Property(e => e.ActiveYn).HasColumnName("Active_YN");

                entity.Property(e => e.CalculateFromValueNonSc).HasColumnName("Calculate_From_Value_Non_SC");

                entity.Property(e => e.CalculateFromValueNonTaxable).HasColumnName("Calculate_From_Value_Non_Taxable");

                entity.Property(e => e.CalculateFromValueSc).HasColumnName("Calculate_From_Value_SC");

                entity.Property(e => e.CalculateFromValueTaxable).HasColumnName("Calculate_From_Value_Taxable");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.NetYn).HasColumnName("Net_YN");

                entity.Property(e => e.PaymentId).HasColumnName("Payment_ID");

                entity.Property(e => e.PaymentNetValue).HasColumnName("Payment_Net_Value");

                entity.Property(e => e.PaymentValueAfterCalc).HasColumnName("Payment_Value_After_Calc");

                entity.Property(e => e.PaymentValueBeforeCalc).HasColumnName("Payment_Value_Before_Calc");

                entity.Property(e => e.PaymentValueByLocalCurrency).HasColumnName("Payment_Value_By_Local_Currency");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.TheMonth).HasColumnName("The_Month");

                entity.Property(e => e.TheYear).HasColumnName("The_Year");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.PaymentTransactionTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Payment_Transaction_Tbl_Employee_Tbl");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.PaymentTransactionTbl)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_Payment_Transaction_Tbl_Payment_Tbl");
            });

            modelBuilder.Entity<PaymentTypeTbl>(entity =>
            {
                entity.HasKey(e => e.PaymentTypeId);

                entity.ToTable("Payment_Type_Tbl");

                entity.Property(e => e.PaymentTypeId).HasColumnName("Payment_Type_ID");

                entity.Property(e => e.PaymentTypeArName)
                    .HasColumnName("Payment_Type_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.PaymentTypeEnName)
                    .HasColumnName("Payment_Type_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PenaltyRepeatTbl>(entity =>
            {
                entity.HasKey(e => e.PenaltyRepeatId);

                entity.ToTable("Penalty_Repeat_Tbl");

                entity.Property(e => e.PenaltyRepeatId).HasColumnName("Penalty_Repeat_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PenaltyDays).HasColumnName("Penalty_Days");

                entity.Property(e => e.PenaltyId).HasColumnName("Penalty_ID");

                entity.Property(e => e.PenaltyRepeatArName)
                    .HasColumnName("Penalty_Repeat_Ar_Name")
                    .HasMaxLength(300);

                entity.Property(e => e.PenaltyRepeatArNameShadow)
                    .HasColumnName("Penalty_Repeat_Ar_Name_Shadow")
                    .HasMaxLength(300);

                entity.Property(e => e.PenaltyRepeatCode)
                    .HasColumnName("Penalty_Repeat_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PenaltyRepeatEnName)
                    .HasColumnName("Penalty_Repeat_En_Name")
                    .HasMaxLength(300);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Penalty)
                    .WithMany(p => p.PenaltyRepeatTbl)
                    .HasForeignKey(d => d.PenaltyId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Penalty_Repeat_Tbl_Penalty_Tbl");
            });

            modelBuilder.Entity<PenaltyTbl>(entity =>
            {
                entity.HasKey(e => e.PenaltyId);

                entity.ToTable("Penalty_Tbl");

                entity.Property(e => e.PenaltyId).HasColumnName("Penalty_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PenaltyArName).HasColumnName("Penalty_Ar_Name");

                entity.Property(e => e.PenaltyArNameShadow).HasColumnName("Penalty_Ar_Name_Shadow");

                entity.Property(e => e.PenaltyCode)
                    .HasColumnName("Penalty_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PenaltyEnName).HasColumnName("Penalty_En_Name");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<PenaltyTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.PenaltyTransactionId);

                entity.ToTable("Penalty_Transaction_Tbl");

                entity.Property(e => e.PenaltyTransactionId).HasColumnName("Penalty_Transaction_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.PenaltyDate)
                    .HasColumnName("Penalty_Date")
                    .HasColumnType("date");

                entity.Property(e => e.PenaltyDays).HasColumnName("Penalty_Days");

                entity.Property(e => e.PenaltyDescription)
                    .HasColumnName("Penalty_Description")
                    .HasMaxLength(100);

                entity.Property(e => e.PenaltyId).HasColumnName("Penalty_ID");

                entity.Property(e => e.PenaltyRepeatId).HasColumnName("Penalty_Repeat_ID");

                entity.Property(e => e.PenaltyTypeId).HasColumnName("Penalty_Type_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.SysRequestStatusId).HasColumnName("Sys_Request_Status_ID");

                entity.Property(e => e.ThroughMachineYn).HasColumnName("Through_Machine_YN");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.PenaltyTransactionTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Penalty_Transaction_Tbl_Employee_Tbl");

                entity.HasOne(d => d.Penalty)
                    .WithMany(p => p.PenaltyTransactionTbl)
                    .HasForeignKey(d => d.PenaltyId)
                    .HasConstraintName("FK_Penalty_Transaction_Tbl_Penalty_Tbl");

                entity.HasOne(d => d.PenaltyRepeat)
                    .WithMany(p => p.PenaltyTransactionTbl)
                    .HasForeignKey(d => d.PenaltyRepeatId)
                    .HasConstraintName("FK_Penalty_Transaction_Tbl_Penalty_Repeat_Tbl");

                entity.HasOne(d => d.PenaltyType)
                    .WithMany(p => p.PenaltyTransactionTbl)
                    .HasForeignKey(d => d.PenaltyTypeId)
                    .HasConstraintName("FK_Penalty_Transaction_Tbl_Penalty_Type_Tbl");

                entity.HasOne(d => d.SysRequestStatus)
                    .WithMany(p => p.PenaltyTransactionTbl)
                    .HasForeignKey(d => d.SysRequestStatusId)
                    .HasConstraintName("FK_Penalty_Transaction_Tbl_Sys_Request_Status_ID");
            });

            modelBuilder.Entity<PenaltyTypeTbl>(entity =>
            {
                entity.HasKey(e => e.PenaltyTypeId);

                entity.ToTable("Penalty_Type_Tbl");

                entity.Property(e => e.PenaltyTypeId).HasColumnName("Penalty_Type_ID");

                entity.Property(e => e.PenaltyTypeArName)
                    .HasColumnName("Penalty_Type_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.PenaltyTypeEnName)
                    .HasColumnName("Penalty_Type_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PermissionTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.PermissionTransactionId);

                entity.ToTable("Permission_Transaction_Tbl");

                entity.Property(e => e.PermissionTransactionId).HasColumnName("Permission_Transaction_ID");

                entity.Property(e => e.BalanceAfter)
                    .HasColumnName("Balance_After")
                    .HasMaxLength(5);

                entity.Property(e => e.CurrentBalance)
                    .HasColumnName("Current_Balance")
                    .HasMaxLength(5);

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.PendingBalance)
                    .HasColumnName("Pending_Balance")
                    .HasMaxLength(5);

                entity.Property(e => e.PermissionDate)
                    .HasColumnName("Permission_Date")
                    .HasColumnType("date");

                entity.Property(e => e.PermissionHours).HasColumnName("Permission_Hours");

                entity.Property(e => e.PermissionMinutes).HasColumnName("Permission_Minutes");

                entity.Property(e => e.PermissionTypeId).HasColumnName("Permission_Type_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.SysRequestStatusId).HasColumnName("Sys_Request_Status_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.PermissionTransactionTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Permission_Transaction_Tbl_Employee_Tbl");

                entity.HasOne(d => d.PermissionType)
                    .WithMany(p => p.PermissionTransactionTbl)
                    .HasForeignKey(d => d.PermissionTypeId)
                    .HasConstraintName("FK_Permission_Transaction_Tbl_Permission_Type_Tbl");

                entity.HasOne(d => d.SysRequestStatus)
                    .WithMany(p => p.PermissionTransactionTbl)
                    .HasForeignKey(d => d.SysRequestStatusId)
                    .HasConstraintName("FK_Permission_Transaction_Tbl_Sys_Request_Status_ID");
            });

            modelBuilder.Entity<PermissionTypeTbl>(entity =>
            {
                entity.HasKey(e => e.PermissionTypeId);

                entity.ToTable("Permission_Type_Tbl");

                entity.Property(e => e.PermissionTypeId).HasColumnName("Permission_Type_ID");

                entity.Property(e => e.PermissionTypeArName)
                    .HasColumnName("Permission_Type_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.PermissionTypeEnName)
                    .HasColumnName("Permission_Type_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PositionConfigurationTbl>(entity =>
            {
                entity.HasKey(e => new { e.PositionId, e.CertificateId });

                entity.ToTable("Position_Configuration_Tbl");

                entity.Property(e => e.PositionId).HasColumnName("Position_ID");

                entity.Property(e => e.CertificateId).HasColumnName("Certificate_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PositionConfigurationId)
                    .HasColumnName("Position_Configuration_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Certificate)
                    .WithMany(p => p.PositionConfigurationTbl)
                    .HasForeignKey(d => d.CertificateId)
                    .HasConstraintName("FK_Position_Configuration_Tbl_Certificate_Tbl");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.PositionConfigurationTbl)
                    .HasForeignKey(d => d.PositionId)
                    .HasConstraintName("FK_Position_Configuration_Tbl_Position_Tbl");
            });

            modelBuilder.Entity<PositionTbl>(entity =>
            {
                entity.HasKey(e => e.PositionId);

                entity.ToTable("Position_Tbl");

                entity.Property(e => e.PositionId).HasColumnName("Position_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.GradeId).HasColumnName("Grade_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.ManagerYn).HasColumnName("Manager_YN");

                entity.Property(e => e.PositionArName)
                    .HasColumnName("Position_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.PositionArNameShadow)
                    .HasColumnName("Position_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.PositionCode)
                    .HasColumnName("Position_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PositionEnName)
                    .HasColumnName("Position_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.PositionTypeId).HasColumnName("Position_Type_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.PositionTbl)
                    .HasForeignKey(d => d.GradeId)
                    .HasConstraintName("FK_Position_Tbl_Grade_Tbl");

                entity.HasOne(d => d.PositionType)
                    .WithMany(p => p.PositionTbl)
                    .HasForeignKey(d => d.PositionTypeId)
                    .HasConstraintName("FK_Position_Tbl_Position_Type_Tbl");
            });

            modelBuilder.Entity<PositionTypeTbl>(entity =>
            {
                entity.HasKey(e => e.PositionTypeId);

                entity.ToTable("Position_Type_Tbl");

                entity.Property(e => e.PositionTypeId).HasColumnName("Position_Type_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PositionTypeArName)
                    .HasColumnName("Position_Type_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.PositionTypeArNameShadow)
                    .HasColumnName("Position_Type_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.PositionTypeCode)
                    .HasColumnName("Position_Type_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PositionTypeEnName)
                    .HasColumnName("Position_Type_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<PrefixTbl>(entity =>
            {
                entity.HasKey(e => e.PrefixId);

                entity.ToTable("Prefix_Tbl");

                entity.Property(e => e.PrefixId).HasColumnName("Prefix_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PrefixArName)
                    .HasColumnName("Prefix_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.PrefixArNameShadow)
                    .HasColumnName("Prefix_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.PrefixCode)
                    .HasColumnName("Prefix_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PrefixEnName)
                    .HasColumnName("Prefix_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<PropertyTbl>(entity =>
            {
                entity.HasKey(e => e.PropertyId);

                entity.ToTable("Property_Tbl");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.ChainId).HasColumnName("Chain_ID");

                entity.Property(e => e.CostCenter)
                    .HasColumnName("Cost_Center")
                    .HasMaxLength(20);

                entity.Property(e => e.CurrentMonth).HasColumnName("Current_Month");

                entity.Property(e => e.CurrentYear).HasColumnName("Current_Year");

                entity.Property(e => e.CustomerCode)
                    .HasColumnName("Customer_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.EndPeriod).HasColumnName("End_Period");

                entity.Property(e => e.ExpiredMonth).HasColumnName("Expired_Month");

                entity.Property(e => e.ExpiredYear).HasColumnName("Expired_Year");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnName("Expiry_Date")
                    .HasColumnType("date");

                entity.Property(e => e.FcId).HasColumnName("FC_ID");

                entity.Property(e => e.FirstMonth).HasColumnName("First_Month");

                entity.Property(e => e.FirstYear).HasColumnName("First_Year");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.GmId).HasColumnName("GM_ID");

                entity.Property(e => e.HrmId).HasColumnName("HRM_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.LicenseCode)
                    .HasColumnName("License_Code")
                    .HasMaxLength(100);

                entity.Property(e => e.LicenseTypeId).HasColumnName("License_Type_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.MultiPropertyYn)
                    .HasColumnName("Multi_Property_YN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NoOfEmployees).HasColumnName("No_Of_Employees");

                entity.Property(e => e.PropertyArName)
                    .HasColumnName("Property_AR_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.PropertyArNameShadow)
                    .HasColumnName("Property_AR_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.PropertyCode)
                    .HasColumnName("Property_Code")
                    .HasMaxLength(20);

                entity.Property(e => e.PropertyEnName)
                    .HasColumnName("Property_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.PropertyLogoFileName)
                    .HasColumnName("Property_Logo_File_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.PropertyLogoFilePath).HasColumnName("Property_Logo_File_Path");

                entity.Property(e => e.StartLiveDate)
                    .HasColumnName("Start_Live_Date")
                    .HasColumnType("date");

                entity.Property(e => e.StartPeriod).HasColumnName("Start_Period");

                entity.Property(e => e.TranslatorKey).HasColumnName("Translator_Key");

                entity.Property(e => e.UnlimitedYn)
                    .HasColumnName("Unlimited_YN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.LicenseType)
                    .WithMany(p => p.PropertyTbl)
                    .HasForeignKey(d => d.LicenseTypeId)
                    .HasConstraintName("FK_Property_Tbl_License_Type_Tbl");
            });

            modelBuilder.Entity<PublicHolidayTbl>(entity =>
            {
                entity.HasKey(e => e.PublicHolidayId);

                entity.ToTable("Public_Holiday_Tbl");

                entity.Property(e => e.PublicHolidayId).HasColumnName("Public_Holiday_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.PublicHolidayArName)
                    .HasColumnName("Public_Holiday_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.PublicHolidayArNameShadow)
                    .HasColumnName("Public_Holiday_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.PublicHolidayCode)
                    .HasColumnName("Public_Holiday_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PublicHolidayDate)
                    .HasColumnName("Public_Holiday_Date")
                    .HasColumnType("date");

                entity.Property(e => e.PublicHolidayEnName)
                    .HasColumnName("Public_Holiday_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<QualificationGradeTbl>(entity =>
            {
                entity.HasKey(e => e.QualificationGradeId);

                entity.ToTable("Qualification_Grade_Tbl");

                entity.Property(e => e.QualificationGradeId).HasColumnName("Qualification_Grade_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.QualificationGradeArName)
                    .HasColumnName("Qualification_Grade_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.QualificationGradeArNameShadow)
                    .HasColumnName("Qualification_Grade_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.QualificationGradeCode)
                    .HasColumnName("Qualification_Grade_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.QualificationGradeEnName)
                    .HasColumnName("Qualification_Grade_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<QualificationTbl>(entity =>
            {
                entity.HasKey(e => e.QualificationId);

                entity.ToTable("Qualification_Tbl");

                entity.Property(e => e.QualificationId).HasColumnName("Qualification_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.QualificationArName)
                    .HasColumnName("Qualification_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.QualificationArNameShadow)
                    .HasColumnName("Qualification_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.QualificationCode)
                    .HasColumnName("Qualification_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.QualificationEnName)
                    .HasColumnName("Qualification_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.QualificationTypeId).HasColumnName("Qualification_Type_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.QualificationType)
                    .WithMany(p => p.QualificationTbl)
                    .HasForeignKey(d => d.QualificationTypeId)
                    .HasConstraintName("FK_Qualification_Tbl_Qualification_Type_Tbl");
            });

            modelBuilder.Entity<QualificationTypeTbl>(entity =>
            {
                entity.HasKey(e => e.QualificationTypeId);

                entity.ToTable("Qualification_Type_Tbl");

                entity.Property(e => e.QualificationTypeId).HasColumnName("Qualification_Type_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.QualificationTypeArName)
                    .HasColumnName("Qualification_Type_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.QualificationTypeArNameShadow)
                    .HasColumnName("Qualification_Type_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.QualificationTypeCode)
                    .HasColumnName("Qualification_Type_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.QualificationTypeEnName)
                    .HasColumnName("Qualification_Type_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<RehireTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.RehireTransactionId);

                entity.ToTable("Rehire_Transaction_Tbl");

                entity.Property(e => e.RehireTransactionId).HasColumnName("Rehire_Transaction_ID");

                entity.Property(e => e.CalculateNewProbationPeriodYn).HasColumnName("Calculate_New_Probation_Period_YN");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.NewEmployeeCode)
                    .HasColumnName("New_Employee_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.NewEmployeeCodeYn).HasColumnName("New_Employee_Code_YN");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.OldEmployeeCode)
                    .HasColumnName("Old_Employee_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PreviousTerminationDate)
                    .HasColumnName("Previous_Termination_Date")
                    .HasColumnType("date");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.RehireDate)
                    .HasColumnName("Rehire_Date")
                    .HasColumnType("date");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.RehireTransactionTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Rehire_Transaction_Tbl_Employee_Tbl");
            });

            modelBuilder.Entity<RelativeDegreeTbl>(entity =>
            {
                entity.HasKey(e => e.RelativeDegreeId)
                    .HasName("PK_Table_1");

                entity.ToTable("Relative_Degree_Tbl");

                entity.Property(e => e.RelativeDegreeId).HasColumnName("Relative_Degree_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.RelativeDegreeArName)
                    .HasColumnName("Relative_Degree_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.RelativeDegreeArNameShadow)
                    .HasColumnName("Relative_Degree_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.RelativeDegreeCode)
                    .HasColumnName("Relative_Degree_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.RelativeDegreeEnName)
                    .HasColumnName("Relative_Degree_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.RelativeDegreeTypeId).HasColumnName("Relative_Degree_Type_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.RelativeDegreeType)
                    .WithMany(p => p.RelativeDegreeTbl)
                    .HasForeignKey(d => d.RelativeDegreeTypeId)
                    .HasConstraintName("FK_Relative_Degree_Tbl_Relative_Degree_Type_Tbl");
            });

            modelBuilder.Entity<RelativeDegreeTypeTbl>(entity =>
            {
                entity.HasKey(e => e.RelativeDegreeTypeId)
                    .HasName("PK_Relative_Degree_Tbl");

                entity.ToTable("Relative_Degree_Type_Tbl");

                entity.Property(e => e.RelativeDegreeTypeId)
                    .HasColumnName("Relative_Degree_Type_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RelativeDegreeTypeArName)
                    .HasColumnName("Relative_Degree_Type_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.RelativeDegreeTypeEnName)
                    .HasColumnName("Relative_Degree_Type_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ReligionTbl>(entity =>
            {
                entity.HasKey(e => e.ReligionId);

                entity.ToTable("Religion_Tbl");

                entity.Property(e => e.ReligionId).HasColumnName("Religion_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.ReligionArName)
                    .HasColumnName("Religion_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.ReligionArNameShadow)
                    .HasColumnName("Religion_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.ReligionCode)
                    .HasColumnName("Religion_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ReligionEnName)
                    .HasColumnName("Religion_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<ReportGeneratorFieldTbl>(entity =>
            {
                entity.HasKey(e => e.ReportGeneratorFieldId);

                entity.ToTable("Report_Generator_Field_Tbl");

                entity.Property(e => e.ReportGeneratorFieldId).HasColumnName("Report_Generator_Field_ID");

                entity.Property(e => e.ReportGeneratorFieldAlign)
                    .HasColumnName("Report_Generator_Field_Align")
                    .HasMaxLength(10);

                entity.Property(e => e.ReportGeneratorFieldDataType)
                    .HasColumnName("Report_Generator_Field_Data_Type")
                    .HasMaxLength(200);

                entity.Property(e => e.ReportGeneratorFieldHeaderName)
                    .HasColumnName("Report_Generator_Field_Header_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.ReportGeneratorFieldHeaderNameAr)
                    .HasColumnName("Report_Generator_Field_Header_Name_Ar")
                    .HasMaxLength(200);

                entity.Property(e => e.ReportGeneratorFieldIndex).HasColumnName("Report_Generator_Field_Index");

                entity.Property(e => e.ReportGeneratorFieldName)
                    .HasColumnName("Report_Generator_Field_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.ReportGeneratorFieldSummary)
                    .HasColumnName("Report_Generator_Field_Summary")
                    .HasMaxLength(10);

                entity.Property(e => e.ReportGeneratorFieldSysTableYn).HasColumnName("Report_Generator_Field_Sys_Table_YN");

                entity.Property(e => e.ReportGeneratorId).HasColumnName("Report_Generator_ID");
            });

            modelBuilder.Entity<ReportGeneratorFilterTbl>(entity =>
            {
                entity.HasKey(e => e.ReportGeneratorFilterId);

                entity.ToTable("Report_Generator_Filter_Tbl");

                entity.Property(e => e.ReportGeneratorFilterId).HasColumnName("Report_Generator_Filter_ID");

                entity.Property(e => e.ReportGeneratorControlType)
                    .HasColumnName("Report_Generator_Control_Type")
                    .HasMaxLength(50);

                entity.Property(e => e.ReportGeneratorFilterAndOr)
                    .HasColumnName("Report_Generator_Filter_AND_OR")
                    .HasMaxLength(10);

                entity.Property(e => e.ReportGeneratorFilterChangeable).HasColumnName("Report_Generator_Filter_Changeable");

                entity.Property(e => e.ReportGeneratorFilterDataTable)
                    .HasColumnName("Report_Generator_Filter_Data_Table")
                    .HasMaxLength(200);

                entity.Property(e => e.ReportGeneratorFilterDataType)
                    .HasColumnName("Report_Generator_Filter_Data_Type")
                    .HasMaxLength(20);

                entity.Property(e => e.ReportGeneratorFilterDisplayName)
                    .HasColumnName("Report_Generator_Filter_Display_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.ReportGeneratorFilterDisplayNameAr)
                    .HasColumnName("Report_Generator_Filter_Display_Name_Ar")
                    .HasMaxLength(200);

                entity.Property(e => e.ReportGeneratorFilterHeaderName)
                    .HasColumnName("Report_Generator_Filter_Header_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.ReportGeneratorFilterHeaderNameAr)
                    .HasColumnName("Report_Generator_Filter_Header_Name_Ar")
                    .HasMaxLength(200);

                entity.Property(e => e.ReportGeneratorFilterIndex).HasColumnName("Report_Generator_Filter_Index");

                entity.Property(e => e.ReportGeneratorFilterName)
                    .HasColumnName("Report_Generator_Filter_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.ReportGeneratorFilterOperator)
                    .HasColumnName("Report_Generator_Filter_Operator")
                    .HasMaxLength(10);

                entity.Property(e => e.ReportGeneratorFilterSysTableYn).HasColumnName("Report_Generator_Filter_Sys_Table_YN");

                entity.Property(e => e.ReportGeneratorFilterValue)
                    .HasColumnName("Report_Generator_Filter_Value")
                    .HasMaxLength(200);

                entity.Property(e => e.ReportGeneratorId).HasColumnName("Report_Generator_ID");
            });

            modelBuilder.Entity<ReportGeneratorGroupTbl>(entity =>
            {
                entity.HasKey(e => e.ReportGeneratorGroupId);

                entity.ToTable("Report_Generator_Group_Tbl");

                entity.Property(e => e.ReportGeneratorGroupId).HasColumnName("Report_Generator_Group_ID");

                entity.Property(e => e.ReportGeneratorGroupDisplayName)
                    .HasColumnName("Report_Generator_Group_Display_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.ReportGeneratorGroupDisplayNameAr)
                    .HasColumnName("Report_Generator_Group_Display_Name_Ar")
                    .HasMaxLength(200);

                entity.Property(e => e.ReportGeneratorGroupFieldName)
                    .HasColumnName("Report_Generator_Group_Field_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.ReportGeneratorGroupIndex).HasColumnName("Report_Generator_Group_Index");

                entity.Property(e => e.ReportGeneratorId).HasColumnName("Report_Generator_ID");
            });

            modelBuilder.Entity<ReportGeneratorTbl>(entity =>
            {
                entity.HasKey(e => e.ReportGeneratorId);

                entity.ToTable("Report_Generator_Tbl");

                entity.Property(e => e.ReportGeneratorId).HasColumnName("Report_Generator_ID");

                entity.Property(e => e.AppMenuId).HasColumnName("App_Menu_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.ReportGeneratorArName)
                    .HasColumnName("Report_Generator_Ar_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.ReportGeneratorArNameShadow)
                    .HasColumnName("Report_Generator_Ar_Name_Shadow")
                    .HasMaxLength(200);

                entity.Property(e => e.ReportGeneratorDataSource).HasColumnName("Report_Generator_Data_Source");

                entity.Property(e => e.ReportGeneratorEnName)
                    .HasColumnName("Report_Generator_En_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.ReportGeneratorLanguage)
                    .HasColumnName("Report_Generator_Language")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ReportGeneratorOrientation)
                    .HasColumnName("Report_Generator_Orientation")
                    .HasMaxLength(50);

                entity.Property(e => e.ReportGeneratorSelectStatment).HasColumnName("Report_Generator_Select_Statment");

                entity.Property(e => e.ReportGeneratorTitleName)
                    .HasColumnName("Report_Generator_Title_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.ReportHeaderAttributeBoldYn).HasColumnName("Report_Header_Attribute_Bold_YN");

                entity.Property(e => e.ReportHeaderAttributeItalicYn).HasColumnName("Report_Header_Attribute_Italic_YN");

                entity.Property(e => e.ReportHeaderAttributeUnderlineYn).HasColumnName("Report_Header_Attribute_Underline_YN");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<ReportSignatureTbl>(entity =>
            {
                entity.HasKey(e => e.ReportSignatureId);

                entity.ToTable("Report_Signature_Tbl");

                entity.Property(e => e.ReportSignatureId).HasColumnName("Report_Signature_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.SignatureEmployeeIdNo1).HasColumnName("Signature_Employee_ID_No_1");

                entity.Property(e => e.SignatureEmployeeIdNo2).HasColumnName("Signature_Employee_ID_No_2");

                entity.Property(e => e.SignatureEmployeeIdNo3).HasColumnName("Signature_Employee_ID_No_3");

                entity.Property(e => e.SignatureEmployeeIdNo4).HasColumnName("Signature_Employee_ID_No_4");

                entity.Property(e => e.SignatureEmployeeIdNo5).HasColumnName("Signature_Employee_ID_No_5");

                entity.Property(e => e.SignatureEmployeeIdNo6).HasColumnName("Signature_Employee_ID_No_6");

                entity.Property(e => e.SignatureTitleArNo1)
                    .HasColumnName("Signature_Title_Ar_No_1")
                    .HasMaxLength(200);

                entity.Property(e => e.SignatureTitleArNo2)
                    .HasColumnName("Signature_Title_Ar_No_2")
                    .HasMaxLength(200);

                entity.Property(e => e.SignatureTitleArNo3)
                    .HasColumnName("Signature_Title_Ar_No_3")
                    .HasMaxLength(200);

                entity.Property(e => e.SignatureTitleArNo4)
                    .HasColumnName("Signature_Title_Ar_No_4")
                    .HasMaxLength(200);

                entity.Property(e => e.SignatureTitleArNo5)
                    .HasColumnName("Signature_Title_Ar_No_5")
                    .HasMaxLength(200);

                entity.Property(e => e.SignatureTitleArNo6)
                    .HasColumnName("Signature_Title_Ar_No_6")
                    .HasMaxLength(200);

                entity.Property(e => e.SignatureTitleEnNo1)
                    .HasColumnName("Signature_Title_En_No_1")
                    .HasMaxLength(200);

                entity.Property(e => e.SignatureTitleEnNo2)
                    .HasColumnName("Signature_Title_En_No_2")
                    .HasMaxLength(200);

                entity.Property(e => e.SignatureTitleEnNo3)
                    .HasColumnName("Signature_Title_En_No_3")
                    .HasMaxLength(200);

                entity.Property(e => e.SignatureTitleEnNo4)
                    .HasColumnName("Signature_Title_En_No_4")
                    .HasMaxLength(200);

                entity.Property(e => e.SignatureTitleEnNo5)
                    .HasColumnName("Signature_Title_En_No_5")
                    .HasMaxLength(200);

                entity.Property(e => e.SignatureTitleEnNo6)
                    .HasColumnName("Signature_Title_En_No_6")
                    .HasMaxLength(200);

                entity.Property(e => e.SysReportId).HasColumnName("Sys_Report_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<ReportToTbl>(entity =>
            {
                entity.HasKey(e => e.ReportToId);

                entity.ToTable("Report_To_Tbl");

                entity.Property(e => e.ReportToId).HasColumnName("Report_To_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.ReportToEmployeeId).HasColumnName("Report_To_Employee_ID");

                entity.Property(e => e.ReportToLevelId).HasColumnName("Report_To_Level_ID");

                entity.Property(e => e.ReportToTypeArName)
                    .HasColumnName("Report_To_Type_Ar_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.ReportToTypeEnName)
                    .HasColumnName("Report_To_Type_En_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.ReportToTypeId).HasColumnName("Report_To_Type_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<ResidencyRenewalTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.ResidencyRenewalTransactionId);

                entity.ToTable("Residency_Renewal_Transaction_Tbl");

                entity.Property(e => e.ResidencyRenewalTransactionId).HasColumnName("Residency_Renewal_Transaction_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.NewResidencyDate)
                    .HasColumnName("New_Residency_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NewResidencyExpireDate)
                    .HasColumnName("New_Residency_Expire_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NewResidencyTypeId).HasColumnName("New_Residency_Type_ID");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.OldResidencyDate)
                    .HasColumnName("Old_Residency_Date")
                    .HasColumnType("date");

                entity.Property(e => e.OldResidencyExpireDate)
                    .HasColumnName("Old_Residency_Expire_Date")
                    .HasColumnType("date");

                entity.Property(e => e.OldResidencyTypeId).HasColumnName("Old_Residency_Type_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.RenewalDate)
                    .HasColumnName("Renewal_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ResidencyNumber).HasColumnName("Residency_Number");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.ResidencyRenewalTransactionTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Residency_Renewal_Transaction_Tbl_Employee_Tbl");

                entity.HasOne(d => d.NewResidencyType)
                    .WithMany(p => p.ResidencyRenewalTransactionTbl)
                    .HasForeignKey(d => d.NewResidencyTypeId)
                    .HasConstraintName("FK_Residency_Renewal_Transaction_Tbl_Residency_Type_Tbl1");
            });

            modelBuilder.Entity<ResidencyTypeTbl>(entity =>
            {
                entity.HasKey(e => e.ResidencyTypeId)
                    .HasName("PK_Accommodation_Type_Tbl");

                entity.ToTable("Residency_Type_Tbl");

                entity.Property(e => e.ResidencyTypeId).HasColumnName("Residency_Type_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.ResidencyTypeArName)
                    .HasColumnName("Residency_Type_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.ResidencyTypeArNameShadow)
                    .HasColumnName("Residency_Type_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.ResidencyTypeCode)
                    .HasColumnName("Residency_Type_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ResidencyTypeEnName)
                    .HasColumnName("Residency_Type_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<SalaryCalculationWayTbl>(entity =>
            {
                entity.HasKey(e => e.SalaryCalculationWayId);

                entity.ToTable("Salary_Calculation_Way_Tbl");

                entity.Property(e => e.SalaryCalculationWayId).HasColumnName("Salary_Calculation_Way_ID");

                entity.Property(e => e.SalaryCalculationWayArName)
                    .HasColumnName("Salary_Calculation_Way_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.SalaryCalculationWayEnName)
                    .HasColumnName("Salary_Calculation_Way_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ScheduleTbl>(entity =>
            {
                entity.HasKey(e => e.ScheduleId);

                entity.ToTable("Schedule_Tbl");

                entity.Property(e => e.ScheduleId).HasColumnName("Schedule_ID");

                entity.Property(e => e.Abbreviation).HasMaxLength(5);

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.NightShiftYn).HasColumnName("Night_Shift_YN");

                entity.Property(e => e.OverTimeStart).HasColumnName("Over_Time_Start");

                entity.Property(e => e.PassIn).HasColumnName("Pass_In");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.ScheduleArName)
                    .HasColumnName("Schedule_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.ScheduleArNameShadow)
                    .HasColumnName("Schedule_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.ScheduleCode)
                    .HasColumnName("Schedule_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ScheduleEnName)
                    .HasColumnName("Schedule_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.TimeIn).HasColumnName("Time_In");

                entity.Property(e => e.TimeOut).HasColumnName("Time_Out");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<SectionTbl>(entity =>
            {
                entity.HasKey(e => e.SectionId);

                entity.ToTable("Section_Tbl");

                entity.Property(e => e.SectionId).HasColumnName("Section_ID");

                entity.Property(e => e.DepartmentId).HasColumnName("Department_ID");

                entity.Property(e => e.DivisionId).HasColumnName("Division_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.SectionArName)
                    .HasColumnName("Section_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.SectionArNameShadow)
                    .HasColumnName("Section_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.SectionCode)
                    .HasColumnName("Section_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.SectionCostCenter)
                    .HasColumnName("Section_Cost_Center")
                    .HasMaxLength(20);

                entity.Property(e => e.SectionEnName)
                    .HasColumnName("Section_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.SectionMgrId).HasColumnName("Section_Mgr_ID");

                entity.Property(e => e.SectionSecId).HasColumnName("Section_Sec_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<SecurityLevelTbl>(entity =>
            {
                entity.HasKey(e => e.SecurityLevelId);

                entity.ToTable("Security_Level_Tbl");

                entity.Property(e => e.SecurityLevelId).HasColumnName("Security_Level_ID");

                entity.Property(e => e.SecurityLevelArName)
                    .HasColumnName("Security_Level_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.SecurityLevelEnName)
                    .HasColumnName("Security_Level_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SelfServiceApprovalTbl>(entity =>
            {
                entity.HasKey(e => e.SelfServiceApprovalId);

                entity.ToTable("Self_Service_Approval_Tbl");

                entity.Property(e => e.SelfServiceApprovalId).HasColumnName("Self_Service_Approval_ID");

                entity.Property(e => e.ActionDate)
                    .HasColumnName("Action_Date")
                    .HasColumnType("date");

                entity.Property(e => e.CanApproveYn).HasColumnName("Can_Approve_YN");

                entity.Property(e => e.DelegatedToEmployeeId).HasColumnName("Delegated_To_Employee_ID");

                entity.Property(e => e.EmailAddress).HasColumnName("EMail_Address");

                entity.Property(e => e.MobileNumber)
                    .HasColumnName("Mobile_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.ReportToLevelId).HasColumnName("Report_To_Level_ID");

                entity.Property(e => e.ReportToTypeId).HasColumnName("Report_To_Type_ID");

                entity.Property(e => e.RequestForApprovalDate)
                    .HasColumnName("Request_For_Approval_Date")
                    .HasColumnType("date");

                entity.Property(e => e.SelfServiceRequestId).HasColumnName("Self_Service_Request_ID");

                entity.Property(e => e.SupervisorEmployeeId).HasColumnName("Supervisor_Employee_ID");

                entity.Property(e => e.SysRequestStatusId).HasColumnName("Sys_Request_Status_ID");

                entity.HasOne(d => d.SelfServiceRequest)
                    .WithMany(p => p.SelfServiceApprovalTbl)
                    .HasForeignKey(d => d.SelfServiceRequestId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Self_Service_Approval_Tbl_Self_Service_Request_Tbl");

                entity.HasOne(d => d.SupervisorEmployee)
                    .WithMany(p => p.SelfServiceApprovalTbl)
                    .HasForeignKey(d => d.SupervisorEmployeeId)
                    .HasConstraintName("FK_Self_Service_Approval_Tbl_Employee_Tbl");

                entity.HasOne(d => d.SysRequestStatus)
                    .WithMany(p => p.SelfServiceApprovalTbl)
                    .HasForeignKey(d => d.SysRequestStatusId)
                    .HasConstraintName("FK_Self_Service_Approval_Tbl_Sys_Request_Status_Tbl");
            });

            modelBuilder.Entity<SelfServiceDelegationTbl>(entity =>
            {
                entity.HasKey(e => e.SelfServiceDelegationId);

                entity.ToTable("Self_Service_Delegation_Tbl");

                entity.Property(e => e.SelfServiceDelegationId).HasColumnName("Self_Service_Delegation_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.SelfServiceDelegationAutoReleaseYn).HasColumnName("Self_Service_Delegation_Auto_Release_YN");

                entity.Property(e => e.SelfServiceDelegationFromDate)
                    .HasColumnName("Self_Service_Delegation_From_Date")
                    .HasColumnType("date");

                entity.Property(e => e.SelfServiceDelegationFromEmployeeId).HasColumnName("Self_Service_Delegation_From_Employee_ID");

                entity.Property(e => e.SelfServiceDelegationReleasedYn).HasColumnName("Self_Service_Delegation_Released_YN");

                entity.Property(e => e.SelfServiceDelegationToDate)
                    .HasColumnName("Self_Service_Delegation_To_Date")
                    .HasColumnType("date");

                entity.Property(e => e.SelfServiceDelegationToEmployeeId).HasColumnName("Self_Service_Delegation_To_Employee_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<SelfServiceEffectsApprovalTbl>(entity =>
            {
                entity.HasKey(e => e.SelfServiceEffectsApprovalId);

                entity.ToTable("Self_Service_Effects_Approval_Tbl");

                entity.Property(e => e.SelfServiceEffectsApprovalId).HasColumnName("Self_Service_Effects_Approval_ID");

                entity.Property(e => e.ApprovedYn).HasColumnName("Approved_YN");

                entity.Property(e => e.FromDate)
                    .HasColumnName("From_Date")
                    .HasColumnType("date");

                entity.Property(e => e.HrApprovedYn).HasColumnName("HR_Approved_YN");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.SupervisorEmployeeId).HasColumnName("Supervisor_Employee_ID");

                entity.Property(e => e.ToDate)
                    .HasColumnName("To_Date")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<SelfServiceRequestDetailsTbl>(entity =>
            {
                entity.HasKey(e => e.SelfServiceRequestDetailsId);

                entity.ToTable("Self_Service_Request_Details_Tbl");

                entity.Property(e => e.SelfServiceRequestDetailsId).HasColumnName("Self_Service_Request_Details_ID");

                entity.Property(e => e.Abbreviation).HasMaxLength(5);

                entity.Property(e => e.AttendanceDate)
                    .HasColumnName("Attendance_Date")
                    .HasColumnType("date");

                entity.Property(e => e.AttendanceTypeId)
                    .HasColumnName("Attendance_Type_ID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.RequestMasterId).HasColumnName("Request_Master_ID");
            });

            modelBuilder.Entity<SelfServiceRequestTbl>(entity =>
            {
                entity.HasKey(e => e.SelfServiceRequestId);

                entity.ToTable("Self_Service_Request_Tbl");

                entity.Property(e => e.SelfServiceRequestId).HasColumnName("Self_Service_Request_ID");

                entity.Property(e => e.EmailAddress).HasColumnName("EMail_Address");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.MobileNumber)
                    .HasColumnName("Mobile_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.RequestFromDate)
                    .HasColumnName("Request_From_Date")
                    .HasColumnType("date");

                entity.Property(e => e.RequestIssueDate)
                    .HasColumnName("Request_Issue_Date")
                    .HasColumnType("date");

                entity.Property(e => e.RequestMasterId).HasColumnName("Request_Master_ID");

                entity.Property(e => e.RequestToDate)
                    .HasColumnName("Request_To_Date")
                    .HasColumnType("date");

                entity.Property(e => e.SysRequestStatusId).HasColumnName("Sys_Request_Status_ID");

                entity.Property(e => e.SysRequestTypeId).HasColumnName("Sys_Request_Type_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.SelfServiceRequestTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Self_Service_Request_Tbl_Employee_Tbl");

                entity.HasOne(d => d.SysRequestStatus)
                    .WithMany(p => p.SelfServiceRequestTbl)
                    .HasForeignKey(d => d.SysRequestStatusId)
                    .HasConstraintName("FK_Self_Service_Request_Tbl_Sys_Request_Status_Tbl");

                entity.HasOne(d => d.SysRequestType)
                    .WithMany(p => p.SelfServiceRequestTbl)
                    .HasForeignKey(d => d.SysRequestTypeId)
                    .HasConstraintName("FK_Self_Service_Request_Tbl_Sys_Request_Type_Tbl");
            });

            modelBuilder.Entity<SelfServicesAttendanceApprovalTbl>(entity =>
            {
                entity.HasKey(e => e.SelfServicesAttendanceApprovalId);

                entity.ToTable("Self_Services_Attendance_Approval_Tbl");

                entity.Property(e => e.SelfServicesAttendanceApprovalId).HasColumnName("Self_Services_Attendance_Approval_ID");

                entity.Property(e => e.HrApprovedYn).HasColumnName("HR_Approved_YN");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.SupervisorEmployeeId).HasColumnName("Supervisor_Employee_ID");

                entity.Property(e => e.TheMonth).HasColumnName("The_Month");

                entity.Property(e => e.TheYear).HasColumnName("The_Year");
            });

            modelBuilder.Entity<ServiceChargeConfigurationTbl>(entity =>
            {
                entity.HasKey(e => e.ServiceChargeConfigurationId);

                entity.ToTable("Service_Charge_Configuration_Tbl");

                entity.Property(e => e.ServiceChargeConfigurationId).HasColumnName("Service_Charge_Configuration_ID");

                entity.Property(e => e.BonusRate).HasColumnName("Bonus_Rate");

                entity.Property(e => e.BrokenRate).HasColumnName("Broken_Rate");

                entity.Property(e => e.EmployeeRate).HasColumnName("Employee_Rate");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.GuestContactRate).HasColumnName("Guest_Contact_Rate");

                entity.Property(e => e.GuestContactSalariesMaxRate).HasColumnName("Guest_Contact_Salaries_Max_Rate");

                entity.Property(e => e.GuestNoneGuestContactRates).HasColumnName("Guest_None_Guest_Contact_Rates");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.NoneGuestContactRate).HasColumnName("None_Guest_Contact_Rate");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<ServiceChargeStatusTbl>(entity =>
            {
                entity.HasKey(e => e.ServiceChargeStatusId);

                entity.ToTable("Service_Charge_Status_Tbl");

                entity.Property(e => e.ServiceChargeStatusId).HasColumnName("Service_Charge_Status_ID");

                entity.Property(e => e.ServiceChargeStatusArName)
                    .HasColumnName("Service_Charge_Status_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.ServiceChargeStatusEnName)
                    .HasColumnName("Service_Charge_Status_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ServiceChargeTransactionDetailsTbl>(entity =>
            {
                entity.HasKey(e => e.ServiceChargeTransactionDetailsId);

                entity.ToTable("Service_Charge_Transaction_Details_Tbl");

                entity.Property(e => e.ServiceChargeTransactionDetailsId).HasColumnName("Service_Charge_Transaction_Details_ID");

                entity.Property(e => e.CurrencyId).HasColumnName("Currency_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.EmployeeNet).HasColumnName("Employee_Net");

                entity.Property(e => e.NetServiceCharge).HasColumnName("Net_Service_Charge");

                entity.Property(e => e.ServiceChargeDeduction).HasColumnName("Service_Charge_Deduction");

                entity.Property(e => e.ServiceChargePayments).HasColumnName("Service_Charge_Payments");

                entity.Property(e => e.ServiceChargePool).HasColumnName("Service_Charge_Pool");

                entity.Property(e => e.ServiceChargeTax).HasColumnName("Service_Charge_Tax");

                entity.Property(e => e.ServiceChargeTaxableDeductions).HasColumnName("Service_Charge_Taxable_Deductions");

                entity.Property(e => e.ServiceChargeTaxablePayments).HasColumnName("Service_Charge_Taxable_Payments");

                entity.Property(e => e.ServiceChargeTransactionId).HasColumnName("Service_Charge_Transaction_ID");

                entity.Property(e => e.ServiceChargeValue).HasColumnName("Service_Charge_Value");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.ServiceChargeTransactionDetailsTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Service_Charge_Transaction_Details_Tbl_Employee_Tbl");

                entity.HasOne(d => d.ServiceChargeTransaction)
                    .WithMany(p => p.ServiceChargeTransactionDetailsTbl)
                    .HasForeignKey(d => d.ServiceChargeTransactionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Service_Charge_Transaction_Details_Tbl_Service_Charge_Transaction_Tbl");
            });

            modelBuilder.Entity<ServiceChargeTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.ServiceChargeTransactionId);

                entity.ToTable("Service_Charge_Transaction_Tbl");

                entity.Property(e => e.ServiceChargeTransactionId).HasColumnName("Service_Charge_Transaction_ID");

                entity.Property(e => e.BonusAmount).HasColumnName("Bonus_Amount");

                entity.Property(e => e.BranchId).HasColumnName("Branch_ID");

                entity.Property(e => e.BrokenAmount).HasColumnName("Broken_Amount");

                entity.Property(e => e.CalculateServiceChargeForPastMonthSalaryYn).HasColumnName("Calculate_Service_Charge_For_Past_Month_Salary_YN");

                entity.Property(e => e.CalculatedYn)
                    .HasColumnName("Calculated_YN")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EmployeesAmount).HasColumnName("Employees_Amount");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.GuarantySalaries).HasColumnName("Guaranty_Salaries");

                entity.Property(e => e.GuestContactAmount).HasColumnName("Guest_Contact_Amount");

                entity.Property(e => e.GuestContactRate).HasColumnName("Guest_Contact_Rate");

                entity.Property(e => e.GuestContactSalaries).HasColumnName("Guest_Contact_Salaries");

                entity.Property(e => e.IncludeSettelmentEmployeesYn).HasColumnName("Include_Settelment_Employees_YN");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.NetSalaries).HasColumnName("Net_Salaries");

                entity.Property(e => e.NonGuestContactAmount).HasColumnName("Non_Guest_Contact_Amount");

                entity.Property(e => e.NonGuestContactRate).HasColumnName("Non_Guest_Contact_Rate");

                entity.Property(e => e.NonGuestContactSalaries).HasColumnName("Non_Guest_Contact_Salaries");

                entity.Property(e => e.PaidYn)
                    .HasColumnName("Paid_YN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.ServiceChargeWay).HasColumnName("Service_Charge_Way");

                entity.Property(e => e.TheMonth).HasColumnName("The_Month");

                entity.Property(e => e.TheYear).HasColumnName("The_Year");

                entity.Property(e => e.TotalAmount).HasColumnName("Total_Amount");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.Property(e => e.WholePropertyYn).HasColumnName("Whole_Property_YN");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.ServiceChargeTransactionTbl)
                    .HasForeignKey(d => d.PropertyId)
                    .HasConstraintName("FK_Service_Charge_Transaction_Tbl_Property_Tbl");
            });

            modelBuilder.Entity<SmsConfigurationTbl>(entity =>
            {
                entity.HasKey(e => e.SmsConfigurationId);

                entity.ToTable("SMS_Configuration_Tbl");

                entity.Property(e => e.SmsConfigurationId).HasColumnName("SMS_Configuration_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.SmsConfigurationEnName)
                    .HasColumnName("SMS_Configuration_En_Name")
                    .HasMaxLength(150);

                entity.Property(e => e.SmsConfigurationGetwayMobileNumber)
                    .HasColumnName("SMS_Configuration_Getway_Mobile_Number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SmsConfigurationUsbAlertYn).HasColumnName("SMS_Configuration_USB_Alert_YN");

                entity.Property(e => e.SmsConfigurationUsbBaudRate).HasColumnName("SMS_Configuration_USB_Baud_Rate");

                entity.Property(e => e.SmsConfigurationUsbMobileNumber)
                    .HasColumnName("SMS_Configuration_USB_Mobile_Number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SmsConfigurationUsbPort).HasColumnName("SMS_Configuration_USB_Port");

                entity.Property(e => e.SmsConfigurationUsbTimeOut).HasColumnName("SMS_Configuration_USB_Time_Out");

                entity.Property(e => e.SmsConfigurationUsbUnicodeYn).HasColumnName("SMS_Configuration_USB_Unicode_YN");

                entity.Property(e => e.SysSmsConfigurationApi)
                    .HasColumnName("Sys_SMS_Configuration_API")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SysSmsConfigurationPassword)
                    .HasColumnName("Sys_SMS_Configuration_Password")
                    .HasMaxLength(100);

                entity.Property(e => e.SysSmsConfigurationUserName)
                    .HasColumnName("Sys_SMS_Configuration_User_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.SysSmsTypeId).HasColumnName("Sys_SMS_Type_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.SmsConfigurationTbl)
                    .HasForeignKey(d => d.PropertyId)
                    .HasConstraintName("FK_SMS_Configuration_Tbl_SMS_Configuration_Tbl");

                entity.HasOne(d => d.SysSmsType)
                    .WithMany(p => p.SmsConfigurationTbl)
                    .HasForeignKey(d => d.SysSmsTypeId)
                    .HasConstraintName("FK_SMS_Configuration_Tbl_Sys_SMS_Type_Tbl");
            });

            modelBuilder.Entity<SpecialHolidayTbl>(entity =>
            {
                entity.HasKey(e => e.SpecialHolidayId);

                entity.ToTable("Special_Holiday_Tbl");

                entity.Property(e => e.SpecialHolidayId).HasColumnName("Special_Holiday_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.SpecialHolidayArName)
                    .HasColumnName("Special_Holiday_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.SpecialHolidayArNameShadow)
                    .HasColumnName("Special_Holiday_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.SpecialHolidayCode)
                    .HasColumnName("Special_Holiday_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.SpecialHolidayDate)
                    .HasColumnName("Special_Holiday_Date")
                    .HasColumnType("date");

                entity.Property(e => e.SpecialHolidayEnName)
                    .HasColumnName("Special_Holiday_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<SpecialityTbl>(entity =>
            {
                entity.HasKey(e => e.SpecialityId);

                entity.ToTable("Speciality_Tbl");

                entity.Property(e => e.SpecialityId).HasColumnName("Speciality_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.SpecialityArName)
                    .HasColumnName("Speciality_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.SpecialityArNameShadow)
                    .HasColumnName("Speciality_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.SpecialityCode)
                    .HasColumnName("Speciality_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.SpecialityEnName)
                    .HasColumnName("Speciality_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<SponsorTbl>(entity =>
            {
                entity.HasKey(e => e.SponsorId)
                    .HasName("PK_Sponser_Tbl");

                entity.ToTable("Sponsor_Tbl");

                entity.Property(e => e.SponsorId).HasColumnName("Sponsor_ID");

                entity.Property(e => e.CommercialLicense)
                    .HasColumnName("Commercial_License")
                    .HasMaxLength(50);

                entity.Property(e => e.ExpireDate)
                    .HasColumnName("Expire_Date")
                    .HasColumnType("date");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.IssueDate)
                    .HasColumnName("Issue_Date")
                    .HasColumnType("date");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.SponsorArName)
                    .HasColumnName("Sponsor_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.SponsorArNameShadow)
                    .HasColumnName("Sponsor_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.SponsorCode)
                    .HasColumnName("Sponsor_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.SponsorEnName)
                    .HasColumnName("Sponsor_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.SponsorTypeId).HasColumnName("Sponsor_Type_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.SponsorType)
                    .WithMany(p => p.SponsorTbl)
                    .HasForeignKey(d => d.SponsorTypeId)
                    .HasConstraintName("FK_Sponsor_Tbl_Sponser_Type_Tbl");
            });

            modelBuilder.Entity<SponsorTypeTbl>(entity =>
            {
                entity.HasKey(e => e.SponsorTypeId)
                    .HasName("PK_Sponser_Type_Tbl");

                entity.ToTable("Sponsor_Type_Tbl");

                entity.Property(e => e.SponsorTypeId)
                    .HasColumnName("Sponsor_Type_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SponsorTypeArName)
                    .HasColumnName("Sponsor_Type_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.SponsorTypeEnName)
                    .HasColumnName("Sponsor_Type_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SummaryReportConfigurationTbl>(entity =>
            {
                entity.HasKey(e => e.SummaryReportConfigurationId);

                entity.ToTable("Summary_Report_Configuration_Tbl");

                entity.Property(e => e.SummaryReportConfigurationId).HasColumnName("Summary_Report_Configuration_ID");

                entity.Property(e => e.DeductionId1).HasColumnName("Deduction_ID_1");

                entity.Property(e => e.DeductionId10).HasColumnName("Deduction_ID_10");

                entity.Property(e => e.DeductionId11).HasColumnName("Deduction_ID_11");

                entity.Property(e => e.DeductionId12).HasColumnName("Deduction_ID_12");

                entity.Property(e => e.DeductionId13).HasColumnName("Deduction_ID_13");

                entity.Property(e => e.DeductionId14).HasColumnName("Deduction_ID_14");

                entity.Property(e => e.DeductionId15).HasColumnName("Deduction_ID_15");

                entity.Property(e => e.DeductionId16).HasColumnName("Deduction_ID_16");

                entity.Property(e => e.DeductionId17).HasColumnName("Deduction_ID_17");

                entity.Property(e => e.DeductionId18).HasColumnName("Deduction_ID_18");

                entity.Property(e => e.DeductionId19).HasColumnName("Deduction_ID_19");

                entity.Property(e => e.DeductionId2).HasColumnName("Deduction_ID_2");

                entity.Property(e => e.DeductionId20).HasColumnName("Deduction_ID_20");

                entity.Property(e => e.DeductionId21).HasColumnName("Deduction_ID_21");

                entity.Property(e => e.DeductionId22).HasColumnName("Deduction_ID_22");

                entity.Property(e => e.DeductionId23).HasColumnName("Deduction_ID_23");

                entity.Property(e => e.DeductionId24).HasColumnName("Deduction_ID_24");

                entity.Property(e => e.DeductionId25).HasColumnName("Deduction_ID_25");

                entity.Property(e => e.DeductionId26).HasColumnName("Deduction_ID_26");

                entity.Property(e => e.DeductionId27).HasColumnName("Deduction_ID_27");

                entity.Property(e => e.DeductionId28).HasColumnName("Deduction_ID_28");

                entity.Property(e => e.DeductionId29).HasColumnName("Deduction_ID_29");

                entity.Property(e => e.DeductionId3).HasColumnName("Deduction_ID_3");

                entity.Property(e => e.DeductionId30).HasColumnName("Deduction_ID_30");

                entity.Property(e => e.DeductionId4).HasColumnName("Deduction_ID_4");

                entity.Property(e => e.DeductionId5).HasColumnName("Deduction_ID_5");

                entity.Property(e => e.DeductionId6).HasColumnName("Deduction_ID_6");

                entity.Property(e => e.DeductionId7).HasColumnName("Deduction_ID_7");

                entity.Property(e => e.DeductionId8).HasColumnName("Deduction_ID_8");

                entity.Property(e => e.DeductionId9).HasColumnName("Deduction_ID_9");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PaymentId1).HasColumnName("Payment_ID_1");

                entity.Property(e => e.PaymentId10).HasColumnName("Payment_ID_10");

                entity.Property(e => e.PaymentId11).HasColumnName("Payment_ID_11");

                entity.Property(e => e.PaymentId12).HasColumnName("Payment_ID_12");

                entity.Property(e => e.PaymentId13).HasColumnName("Payment_ID_13");

                entity.Property(e => e.PaymentId14).HasColumnName("Payment_ID_14");

                entity.Property(e => e.PaymentId15).HasColumnName("Payment_ID_15");

                entity.Property(e => e.PaymentId16).HasColumnName("Payment_ID_16");

                entity.Property(e => e.PaymentId17).HasColumnName("Payment_ID_17");

                entity.Property(e => e.PaymentId18).HasColumnName("Payment_ID_18");

                entity.Property(e => e.PaymentId19).HasColumnName("Payment_ID_19");

                entity.Property(e => e.PaymentId2).HasColumnName("Payment_ID_2");

                entity.Property(e => e.PaymentId20).HasColumnName("Payment_ID_20");

                entity.Property(e => e.PaymentId21).HasColumnName("Payment_ID_21");

                entity.Property(e => e.PaymentId22).HasColumnName("Payment_ID_22");

                entity.Property(e => e.PaymentId23).HasColumnName("Payment_ID_23");

                entity.Property(e => e.PaymentId24).HasColumnName("Payment_ID_24");

                entity.Property(e => e.PaymentId25).HasColumnName("Payment_ID_25");

                entity.Property(e => e.PaymentId26).HasColumnName("Payment_ID_26");

                entity.Property(e => e.PaymentId27).HasColumnName("Payment_ID_27");

                entity.Property(e => e.PaymentId28).HasColumnName("Payment_ID_28");

                entity.Property(e => e.PaymentId29).HasColumnName("Payment_ID_29");

                entity.Property(e => e.PaymentId3).HasColumnName("Payment_ID_3");

                entity.Property(e => e.PaymentId30).HasColumnName("Payment_ID_30");

                entity.Property(e => e.PaymentId4).HasColumnName("Payment_ID_4");

                entity.Property(e => e.PaymentId5).HasColumnName("Payment_ID_5");

                entity.Property(e => e.PaymentId6).HasColumnName("Payment_ID_6");

                entity.Property(e => e.PaymentId7).HasColumnName("Payment_ID_7");

                entity.Property(e => e.PaymentId8).HasColumnName("Payment_ID_8");

                entity.Property(e => e.PaymentId9).HasColumnName("Payment_ID_9");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.TheMonth).HasColumnName("The_Month");

                entity.Property(e => e.TheYear).HasColumnName("The_Year");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<SysAttendanceMachineSdkTbl>(entity =>
            {
                entity.HasKey(e => e.SysAttendanceMachineSdkId)
                    .HasName("PK_Table_1_1");

                entity.ToTable("Sys_Attendance_Machine_Sdk_Tbl");

                entity.Property(e => e.SysAttendanceMachineSdkId)
                    .HasColumnName("Sys_Attendance_Machine_Sdk_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisplayOrder).HasColumnName("Display_Order");

                entity.Property(e => e.SysAttendanceMachineSdkName)
                    .HasColumnName("Sys_Attendance_Machine_Sdk_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysBankFileDetailsFieldTbl>(entity =>
            {
                entity.HasKey(e => e.SysBankFileDetailsFieldId)
                    .HasName("PK_Sys_Bank_File_Tbl");

                entity.ToTable("Sys_Bank_File_Details_Field_Tbl");

                entity.Property(e => e.SysBankFileDetailsFieldId)
                    .HasColumnName("Sys_Bank_File_Details_Field_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.NeedNoDecimalsYn).HasColumnName("Need_No_Decimals_YN");

                entity.Property(e => e.NeedValueYn).HasColumnName("Need_Value_YN");

                entity.Property(e => e.SysBankFileDetailsFieldArName)
                    .HasColumnName("Sys_Bank_File_Details_Field_Ar_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.SysBankFileDetailsFieldEnName)
                    .HasColumnName("Sys_Bank_File_Details_Field_En_Name")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<SysColorTbl>(entity =>
            {
                entity.HasKey(e => e.SysColorId)
                    .HasName("PK_Sys_Colors_Tbl");

                entity.ToTable("Sys_Color_Tbl");

                entity.Property(e => e.SysColorId)
                    .HasColumnName("Sys_Color_ID")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.SysColorArName)
                    .HasColumnName("Sys_Color_Ar_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.SysColorEnName)
                    .HasColumnName("Sys_Color_En_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SysDateFormatTbl>(entity =>
            {
                entity.HasKey(e => e.DateFormatId);

                entity.ToTable("Sys_Date_Format_Tbl");

                entity.Property(e => e.DateFormatId)
                    .HasColumnName("Date_Format_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppDateFormat)
                    .HasColumnName("App_Date_Format")
                    .HasMaxLength(20);

                entity.Property(e => e.DateValidator).HasColumnName("Date_Validator");

                entity.Property(e => e.SqlCode).HasColumnName("SQL_Code");
            });

            modelBuilder.Entity<SysDbScriptsTbl>(entity =>
            {
                entity.HasKey(e => e.DbScriptId);

                entity.ToTable("Sys_DB_Scripts_Tbl");

                entity.Property(e => e.DbScriptId).HasColumnName("DB_Script_ID");

                entity.Property(e => e.DbScriptInsetDate)
                    .HasColumnName("DB_Script_Inset_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DbScriptName).HasColumnName("DB_Script_Name");
            });

            modelBuilder.Entity<SysDocumentTypeTbl>(entity =>
            {
                entity.HasKey(e => e.SysDocumentTypeId);

                entity.ToTable("Sys_Document_Type_Tbl");

                entity.Property(e => e.SysDocumentTypeId)
                    .HasColumnName("Sys_Document_Type_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.SysDocumentTypeAr)
                    .HasColumnName("Sys_Document_Type_Ar")
                    .HasMaxLength(100);

                entity.Property(e => e.SysDocumentTypeEn)
                    .HasColumnName("Sys_Document_Type_En")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SysEmailSetupTypeTbl>(entity =>
            {
                entity.HasKey(e => e.SysEmailSetupTypeId);

                entity.ToTable("Sys_Email_Setup_Type_Tbl");

                entity.Property(e => e.SysEmailSetupTypeId)
                    .HasColumnName("Sys_Email_Setup_Type_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.SysEmailSetupTypeArName)
                    .HasColumnName("Sys_Email_Setup_Type_Ar_Name")
                    .HasMaxLength(150);

                entity.Property(e => e.SysEmailSetupTypeEnName)
                    .HasColumnName("Sys_Email_Setup_Type_En_Name")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<SysEmailTypeTbl>(entity =>
            {
                entity.HasKey(e => e.SysEmailTypeId);

                entity.ToTable("Sys_Email_Type_Tbl");

                entity.Property(e => e.SysEmailTypeId)
                    .HasColumnName("Sys_Email_Type_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppSettingId).HasColumnName("App_Setting_ID");

                entity.Property(e => e.SysEmailTypeArName)
                    .HasColumnName("Sys_Email_Type_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.SysEmailTypeEnName)
                    .HasColumnName("Sys_Email_Type_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SysExchangeTypeTbl>(entity =>
            {
                entity.HasKey(e => e.SysExchangeTypeId);

                entity.ToTable("Sys_Exchange_Type_Tbl");

                entity.Property(e => e.SysExchangeTypeId)
                    .HasColumnName("Sys_Exchange_Type_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.SysExchangeTypeEnName)
                    .HasColumnName("Sys_Exchange_Type_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.SysExchangeTypeInternal)
                    .HasColumnName("Sys_Exchange_Type_Internal")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SysFieldNameTbl>(entity =>
            {
                entity.HasKey(e => e.FieldNameId);

                entity.ToTable("Sys_Field_Name_Tbl");

                entity.Property(e => e.FieldNameId).HasColumnName("Field_Name_ID");

                entity.Property(e => e.ArName)
                    .HasColumnName("Ar_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.EnName)
                    .IsRequired()
                    .HasColumnName("En_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.FieldName)
                    .IsRequired()
                    .HasColumnName("Field_Name")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<SysMedicalVacationTypeTbl>(entity =>
            {
                entity.HasKey(e => e.SysMedicalVacationTypeId)
                    .HasName("PK_Sys_Medical_Vacation_Tbl");

                entity.ToTable("Sys_Medical_Vacation_Type_Tbl");

                entity.Property(e => e.SysMedicalVacationTypeId)
                    .HasColumnName("Sys_Medical_Vacation_Type_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.SysMedicalVacationTypeArName)
                    .HasColumnName("Sys_Medical_Vacation_Type_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.SysMedicalVacationTypeEnName)
                    .HasColumnName("Sys_Medical_Vacation_Type_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SysMessageTypeTbl>(entity =>
            {
                entity.HasKey(e => e.SysMessageTypeId);

                entity.ToTable("Sys_Message_Type_Tbl");

                entity.Property(e => e.SysMessageTypeId)
                    .HasColumnName("Sys_Message_Type_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.SysMessageTypeArName)
                    .HasColumnName("Sys_Message_Type_Ar_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.SysMessageTypeEnName)
                    .HasColumnName("Sys_Message_Type_En_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SysNotificationCcTypeTbl>(entity =>
            {
                entity.HasKey(e => e.SysNotificationCcTypeId)
                    .HasName("PK_Sys_CC_Email_Type_Tbl_1");

                entity.ToTable("Sys_Notification_CC_Type_Tbl");

                entity.Property(e => e.SysNotificationCcTypeId)
                    .HasColumnName("Sys_Notification_CC_Type_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppSettingId).HasColumnName("App_Setting_ID");

                entity.Property(e => e.SysNotificationCcTypeArName)
                    .HasColumnName("Sys_Notification_CC_Type_Ar_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.SysNotificationCcTypeCode)
                    .HasColumnName("Sys_Notification_CC_Type_Code")
                    .HasMaxLength(5);

                entity.Property(e => e.SysNotificationCcTypeEnName)
                    .HasColumnName("Sys_Notification_CC_Type_En_Name")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<SysNotificationFieldTbl>(entity =>
            {
                entity.HasKey(e => e.SysNotificationFieldId);

                entity.ToTable("Sys_Notification_Field_Tbl");

                entity.Property(e => e.SysNotificationFieldId)
                    .HasColumnName("Sys_Notification_Field_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppSettingId).HasColumnName("App_Setting_ID");

                entity.Property(e => e.SysNotificationFieldArName)
                    .HasColumnName("Sys_Notification_Field_Ar_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.SysNotificationFieldCode)
                    .HasColumnName("Sys_Notification_Field_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.SysNotificationFieldEnName)
                    .HasColumnName("Sys_Notification_Field_En_Name")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<SysPeriodTbl>(entity =>
            {
                entity.ToTable("Sys_Period_Tbl");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PeriodArName)
                    .HasColumnName("Period_Ar_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.PeriodCode)
                    .HasColumnName("Period_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.PeriodEnName)
                    .HasColumnName("Period_En_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SysReportFilterTbl>(entity =>
            {
                entity.HasKey(e => e.SysReportFilterId);

                entity.ToTable("Sys_Report_Filter_Tbl");

                entity.Property(e => e.SysReportFilterId).HasColumnName("Sys_Report_Filter_ID");

                entity.Property(e => e.CommandName)
                    .HasColumnName("Command_Name")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Command')");

                entity.Property(e => e.DefaultValue)
                    .HasColumnName("Default_Value")
                    .HasMaxLength(100);

                entity.Property(e => e.FieldControlId)
                    .HasColumnName("Field_Control_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.FieldId)
                    .HasColumnName("Field_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.FieldName)
                    .HasColumnName("Field_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.FieldType)
                    .HasColumnName("Field_Type")
                    .HasMaxLength(100);

                entity.Property(e => e.LableArName)
                    .HasColumnName("Lable_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.LableControlId)
                    .HasColumnName("Lable_Control_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.LableEnName)
                    .HasColumnName("Lable_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.MendatoryYn).HasColumnName("Mendatory_YN");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Operator).HasMaxLength(5);

                entity.Property(e => e.RequiredYn)
                    .HasColumnName("Required_YN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SysReportId).HasColumnName("Sys_Report_ID");

                entity.Property(e => e.TableName)
                    .HasColumnName("Table_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.TdId)
                    .HasColumnName("TD_ID")
                    .HasMaxLength(100);

                entity.HasOne(d => d.SysReport)
                    .WithMany(p => p.SysReportFilterTbl)
                    .HasForeignKey(d => d.SysReportId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Sys_Report_Filter_Tbl_Sys_Report_Tbl");
            });

            modelBuilder.Entity<SysReportGeneratorFieldNameTbl>(entity =>
            {
                entity.HasKey(e => e.SysReportGeneratorFieldNameId)
                    .HasName("PK_Sys_Cutom_Report_Field_Name_Tbl");

                entity.ToTable("Sys_Report_Generator_Field_Name_Tbl");

                entity.Property(e => e.SysReportGeneratorFieldNameId)
                    .HasColumnName("Sys_Report_Generator_Field_Name_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.SysReportGeneratorDisplayArName).HasColumnName("Sys_Report_Generator_Display_Ar_Name");

                entity.Property(e => e.SysReportGeneratorDisplayEnName).HasColumnName("Sys_Report_Generator_Display_En_Name");

                entity.Property(e => e.SysReportGeneratorFieldName).HasColumnName("Sys_Report_Generator_Field_Name");

                entity.Property(e => e.SysReportGeneratorViewName).HasColumnName("Sys_Report_Generator_View_Name");

                entity.Property(e => e.SysTableYn)
                    .HasColumnName("Sys_Table_YN")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SysReportGeneratorTbl>(entity =>
            {
                entity.HasKey(e => e.SysReportGeneratorId)
                    .HasName("PK_Sys_Custom_Report_Tbl");

                entity.ToTable("Sys_Report_Generator_Tbl");

                entity.Property(e => e.SysReportGeneratorId)
                    .HasColumnName("Sys_Report_Generator_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppMenuId).HasColumnName("App_Menu_ID");

                entity.Property(e => e.SysReportGeneratorArName).HasColumnName("Sys_Report_Generator_Ar_Name");

                entity.Property(e => e.SysReportGeneratorEnName).HasColumnName("Sys_Report_Generator_En_Name");

                entity.Property(e => e.SysReportGeneratorFromQuery).HasColumnName("Sys_Report_Generator_From_Query");

                entity.Property(e => e.SysReportGeneratorQuery).HasColumnName("Sys_Report_Generator_Query");

                entity.Property(e => e.SysReportGeneratorSource).HasColumnName("Sys_Report_Generator_Source");
            });

            modelBuilder.Entity<SysReportParameterTbl>(entity =>
            {
                entity.HasKey(e => e.SysReportParameterId);

                entity.ToTable("Sys_Report_Parameter_Tbl");

                entity.Property(e => e.SysReportParameterId).HasColumnName("Sys_Report_Parameter_ID");

                entity.Property(e => e.ControlId)
                    .HasColumnName("Control_ID")
                    .HasMaxLength(100);

                entity.Property(e => e.ControlType)
                    .HasColumnName("Control_Type")
                    .HasMaxLength(100);

                entity.Property(e => e.ParameterName)
                    .HasColumnName("Parameter_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.SysReportId).HasColumnName("Sys_Report_ID");

                entity.HasOne(d => d.SysReport)
                    .WithMany(p => p.SysReportParameterTbl)
                    .HasForeignKey(d => d.SysReportId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Sys_Report_Parameter_Tbl_Sys_Report_Tbl");
            });

            modelBuilder.Entity<SysReportTbl>(entity =>
            {
                entity.HasKey(e => e.SysReportId);

                entity.ToTable("Sys_Report_Tbl");

                entity.Property(e => e.SysReportId)
                    .HasColumnName("Sys_Report_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppSettingId).HasColumnName("App_Setting_ID");

                entity.Property(e => e.ArabicReportReadyYn).HasColumnName("Arabic_Report_Ready_YN");

                entity.Property(e => e.CategoryId).HasColumnName("Category_ID");

                entity.Property(e => e.DisplayOrder).HasColumnName("Display_Order");

                entity.Property(e => e.DisplayYn)
                    .HasColumnName("Display_YN")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.HasFilterYn).HasColumnName("Has_Filter_YN");

                entity.Property(e => e.HasParameterYn).HasColumnName("Has_Parameter_YN");

                entity.Property(e => e.HistoryReportYn).HasColumnName("History_Report_YN");

                entity.Property(e => e.LicenseTypeId).HasColumnName("License_Type_ID");

                entity.Property(e => e.ModuleId).HasColumnName("Module_ID");

                entity.Property(e => e.ParentId).HasColumnName("Parent_ID");

                entity.Property(e => e.ReportFunction)
                    .HasColumnName("Report_Function")
                    .HasMaxLength(100);

                entity.Property(e => e.ReportValuePath)
                    .HasColumnName("Report_Value_Path")
                    .HasMaxLength(50);

                entity.Property(e => e.SubordinateYn)
                    .HasColumnName("Subordinate_YN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SysReportArName)
                    .HasColumnName("Sys_Report_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.SysReportEnName)
                    .HasColumnName("Sys_Report_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.SysReportFileArName)
                    .HasColumnName("Sys_Report_File_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.SysReportFileEnName)
                    .HasColumnName("Sys_Report_File_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SysReportToTypeTbl>(entity =>
            {
                entity.HasKey(e => e.ReportToTypeId);

                entity.ToTable("Sys_Report_To_Type_Tbl");

                entity.Property(e => e.ReportToTypeId).HasColumnName("Report_To_Type_ID");

                entity.Property(e => e.ReportToTypeArName)
                    .HasColumnName("Report_To_Type_Ar_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.ReportToTypeEnName)
                    .HasColumnName("Report_To_Type_En_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SysRequestStatusTbl>(entity =>
            {
                entity.HasKey(e => e.SysRequestStatusId);

                entity.ToTable("Sys_Request_Status_Tbl");

                entity.Property(e => e.SysRequestStatusId)
                    .HasColumnName("Sys_Request_Status_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.SysRequestStatusArName)
                    .HasColumnName("Sys_Request_Status_Ar_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.SysRequestStatusEnName)
                    .HasColumnName("Sys_Request_Status_En_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SysRequestTypeTbl>(entity =>
            {
                entity.HasKey(e => e.SysRequestTypeId);

                entity.ToTable("Sys_Request_Type_Tbl");

                entity.Property(e => e.SysRequestTypeId)
                    .HasColumnName("Sys_Request_Type_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppSettingId).HasColumnName("App_Setting_ID");

                entity.Property(e => e.SubordinateYn).HasColumnName("Subordinate_YN");

                entity.Property(e => e.SysRequestTypeArName)
                    .HasColumnName("Sys_Request_Type_Ar_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.SysRequestTypeEnName)
                    .HasColumnName("Sys_Request_Type_En_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.SysRequestTypeTableName)
                    .HasColumnName("Sys_Request_Type_Table_Name")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<SysSalaryCalculationWayTbl>(entity =>
            {
                entity.HasKey(e => e.SysSalaryCalculationWayId);

                entity.ToTable("sys_Salary_Calculation_Way_Tbl");

                entity.Property(e => e.SysSalaryCalculationWayId)
                    .HasColumnName("Sys_Salary_Calculation_Way_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SysSalaryCalculationWayArName)
                    .HasColumnName("Sys_Salary_Calculation_Way_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.SysSalaryCalculationWayEnName)
                    .HasColumnName("Sys_Salary_Calculation_Way_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SysSmsCategoryTbl>(entity =>
            {
                entity.HasKey(e => e.SysSmsCategoryId);

                entity.ToTable("Sys_SMS_Category_Tbl");

                entity.Property(e => e.SysSmsCategoryId)
                    .HasColumnName("Sys_SMS_Category_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.SysSmsCategoryArName)
                    .HasColumnName("Sys_SMS_Category_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.SysSmsCategoryEnName)
                    .HasColumnName("Sys_SMS_Category_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SysSmsTypeTbl>(entity =>
            {
                entity.HasKey(e => e.SysSmsTypeId);

                entity.ToTable("Sys_SMS_Type_Tbl");

                entity.Property(e => e.SysSmsTypeId)
                    .HasColumnName("Sys_SMS_Type_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.SysSmsCategoryId).HasColumnName("Sys_SMS_Category_ID");

                entity.Property(e => e.SysSmsTypeEnName)
                    .HasColumnName("Sys_SMS_Type_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SysTableTbl>(entity =>
            {
                entity.HasKey(e => e.TableId)
                    .HasName("PK_Table_Tbl");

                entity.ToTable("Sys_Table_Tbl");

                entity.Property(e => e.TableId).HasColumnName("Table_ID");

                entity.Property(e => e.DeleteOrder).HasColumnName("Delete_Order");

                entity.Property(e => e.RecordPerProperty).HasColumnName("Record_Per_Property");

                entity.Property(e => e.SqlIdentity)
                    .HasColumnName("SQL_Identity")
                    .HasMaxLength(255);

                entity.Property(e => e.TableName)
                    .HasColumnName("Table_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.TableType)
                    .HasColumnName("Table_Type")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SysTranslationLangTbl>(entity =>
            {
                entity.HasKey(e => e.SysTranslationLangSortId)
                    .HasName("PK_Sys_Trnaslation_Lang_Tbl");

                entity.ToTable("Sys_Translation_Lang_Tbl");

                entity.Property(e => e.SysTranslationLangSortId)
                    .HasColumnName("Sys_Translation_Lang_Sort_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.SysTranslationLangArName)
                    .HasColumnName("Sys_Translation_Lang_Ar_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.SysTranslationLangEnName)
                    .HasColumnName("Sys_Translation_Lang_En_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.SysTranslationLangId)
                    .IsRequired()
                    .HasColumnName("Sys_Translation_Lang_ID")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TaxBalanceConfigurationTbl>(entity =>
            {
                entity.ToTable("Tax_Balance_Configuration_Tbl");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CalculationMode).HasColumnName("Calculation_Mode");

                entity.Property(e => e.DeductionId1).HasColumnName("Deduction_ID_1");

                entity.Property(e => e.DeductionId10).HasColumnName("Deduction_ID_10");

                entity.Property(e => e.DeductionId11).HasColumnName("Deduction_ID_11");

                entity.Property(e => e.DeductionId12).HasColumnName("Deduction_ID_12");

                entity.Property(e => e.DeductionId13).HasColumnName("Deduction_ID_13");

                entity.Property(e => e.DeductionId14).HasColumnName("Deduction_ID_14");

                entity.Property(e => e.DeductionId15).HasColumnName("Deduction_ID_15");

                entity.Property(e => e.DeductionId16).HasColumnName("Deduction_ID_16");

                entity.Property(e => e.DeductionId17).HasColumnName("Deduction_ID_17");

                entity.Property(e => e.DeductionId18).HasColumnName("Deduction_ID_18");

                entity.Property(e => e.DeductionId19).HasColumnName("Deduction_ID_19");

                entity.Property(e => e.DeductionId2).HasColumnName("Deduction_ID_2");

                entity.Property(e => e.DeductionId20).HasColumnName("Deduction_ID_20");

                entity.Property(e => e.DeductionId21).HasColumnName("Deduction_ID_21");

                entity.Property(e => e.DeductionId22).HasColumnName("Deduction_ID_22");

                entity.Property(e => e.DeductionId23).HasColumnName("Deduction_ID_23");

                entity.Property(e => e.DeductionId24).HasColumnName("Deduction_ID_24");

                entity.Property(e => e.DeductionId25).HasColumnName("Deduction_ID_25");

                entity.Property(e => e.DeductionId26).HasColumnName("Deduction_ID_26");

                entity.Property(e => e.DeductionId27).HasColumnName("Deduction_ID_27");

                entity.Property(e => e.DeductionId28).HasColumnName("Deduction_ID_28");

                entity.Property(e => e.DeductionId29).HasColumnName("Deduction_ID_29");

                entity.Property(e => e.DeductionId3).HasColumnName("Deduction_ID_3");

                entity.Property(e => e.DeductionId30).HasColumnName("Deduction_ID_30");

                entity.Property(e => e.DeductionId4).HasColumnName("Deduction_ID_4");

                entity.Property(e => e.DeductionId5).HasColumnName("Deduction_ID_5");

                entity.Property(e => e.DeductionId6).HasColumnName("Deduction_ID_6");

                entity.Property(e => e.DeductionId7).HasColumnName("Deduction_ID_7");

                entity.Property(e => e.DeductionId8).HasColumnName("Deduction_ID_8");

                entity.Property(e => e.DeductionId9).HasColumnName("Deduction_ID_9");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PaymentId1).HasColumnName("Payment_ID_1");

                entity.Property(e => e.PaymentId10).HasColumnName("Payment_ID_10");

                entity.Property(e => e.PaymentId11).HasColumnName("Payment_ID_11");

                entity.Property(e => e.PaymentId12).HasColumnName("Payment_ID_12");

                entity.Property(e => e.PaymentId13).HasColumnName("Payment_ID_13");

                entity.Property(e => e.PaymentId14).HasColumnName("Payment_ID_14");

                entity.Property(e => e.PaymentId15).HasColumnName("Payment_ID_15");

                entity.Property(e => e.PaymentId16).HasColumnName("Payment_ID_16");

                entity.Property(e => e.PaymentId17).HasColumnName("Payment_ID_17");

                entity.Property(e => e.PaymentId18).HasColumnName("Payment_ID_18");

                entity.Property(e => e.PaymentId19).HasColumnName("Payment_ID_19");

                entity.Property(e => e.PaymentId2).HasColumnName("Payment_ID_2");

                entity.Property(e => e.PaymentId20).HasColumnName("Payment_ID_20");

                entity.Property(e => e.PaymentId21).HasColumnName("Payment_ID_21");

                entity.Property(e => e.PaymentId22).HasColumnName("Payment_ID_22");

                entity.Property(e => e.PaymentId23).HasColumnName("Payment_ID_23");

                entity.Property(e => e.PaymentId24).HasColumnName("Payment_ID_24");

                entity.Property(e => e.PaymentId25).HasColumnName("Payment_ID_25");

                entity.Property(e => e.PaymentId26).HasColumnName("Payment_ID_26");

                entity.Property(e => e.PaymentId27).HasColumnName("Payment_ID_27");

                entity.Property(e => e.PaymentId28).HasColumnName("Payment_ID_28");

                entity.Property(e => e.PaymentId29).HasColumnName("Payment_ID_29");

                entity.Property(e => e.PaymentId3).HasColumnName("Payment_ID_3");

                entity.Property(e => e.PaymentId30).HasColumnName("Payment_ID_30");

                entity.Property(e => e.PaymentId4).HasColumnName("Payment_ID_4");

                entity.Property(e => e.PaymentId5).HasColumnName("Payment_ID_5");

                entity.Property(e => e.PaymentId6).HasColumnName("Payment_ID_6");

                entity.Property(e => e.PaymentId7).HasColumnName("Payment_ID_7");

                entity.Property(e => e.PaymentId8).HasColumnName("Payment_ID_8");

                entity.Property(e => e.PaymentId9).HasColumnName("Payment_ID_9");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.TaxBalanceConfigurationId).HasColumnName("Tax_Balance_Configuration_ID");

                entity.Property(e => e.TheYear).HasColumnName("The_Year");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<TaxBalanceTransactionDetailsTbl>(entity =>
            {
                entity.HasKey(e => e.TaxBalanceTransactionDetailsId);

                entity.ToTable("Tax_Balance_Transaction_Details_Tbl");

                entity.Property(e => e.TaxBalanceTransactionDetailsId).HasColumnName("Tax_Balance_Transaction_Details_ID");

                entity.Property(e => e.CalculatedTax).HasColumnName("Calculated_Tax");

                entity.Property(e => e.CurrentTotalTax).HasColumnName("Current_Total_Tax");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.LifeInsuranceAmount).HasColumnName("Life_Insurance_Amount");

                entity.Property(e => e.MonthAdditionalPaymentPool).HasColumnName("Month_Additional_Payment_Pool");

                entity.Property(e => e.MonthBonusPool).HasColumnName("Month_Bonus_Pool");

                entity.Property(e => e.MonthProfitPool).HasColumnName("Month_Profit_Pool");

                entity.Property(e => e.MonthServiceChargePool).HasColumnName("Month_Service_Charge_Pool");

                entity.Property(e => e.TaxBalanceTransactionId).HasColumnName("Tax_Balance_Transaction_ID");

                entity.Property(e => e.TaxExcemption).HasColumnName("Tax_Excemption");

                entity.Property(e => e.TotalEmployeeInsurance).HasColumnName("Total_Employee_Insurance");

                entity.Property(e => e.TotalPayments).HasColumnName("Total_Payments");

                entity.Property(e => e.TotalTaxableDeductions).HasColumnName("Total_Taxable_Deductions");

                entity.Property(e => e.TotalTaxablePayments).HasColumnName("Total_Taxable_Payments");

                entity.Property(e => e.WorkingMonths).HasColumnName("Working_Months");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TaxBalanceTransactionDetailsTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Tax_Balance_Transaction_Details_Tbl_Employee_Tbl");

                entity.HasOne(d => d.TaxBalanceTransaction)
                    .WithMany(p => p.TaxBalanceTransactionDetailsTbl)
                    .HasForeignKey(d => d.TaxBalanceTransactionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Tax_Balance_Transaction_Details_Tbl_Tax_Balance_Transaction_Tbl");
            });

            modelBuilder.Entity<TaxBalanceTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.TaxBalanceTransactionId);

                entity.ToTable("Tax_Balance_Transaction_Tbl");

                entity.Property(e => e.TaxBalanceTransactionId).HasColumnName("Tax_Balance_Transaction_ID");

                entity.Property(e => e.CalculatedYn)
                    .HasColumnName("Calculated_YN")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.FromMonth).HasColumnName("From_Month");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PayDifferenceSalaryYn).HasColumnName("Pay_Difference_Salary_YN");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.TaxBalanceDate)
                    .HasColumnName("Tax_Balance_Date")
                    .HasColumnType("date");

                entity.Property(e => e.TaxRuleId).HasColumnName("Tax_Rule_ID");

                entity.Property(e => e.TheYear).HasColumnName("The_Year");

                entity.Property(e => e.ToMonth).HasColumnName("To_Month");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.TaxBalanceTransactionTbl)
                    .HasForeignKey(d => d.PropertyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tax_Balance_Transaction_Tbl_Property_Tbl");
            });

            modelBuilder.Entity<TaxFormulaTbl>(entity =>
            {
                entity.HasKey(e => e.FormulaId);

                entity.ToTable("Tax_Formula_Tbl");

                entity.Property(e => e.FormulaId)
                    .HasColumnName("Formula_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FormulaArName)
                    .HasColumnName("Formula_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.FormulaEnName)
                    .HasColumnName("Formula_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.FormulaType).HasColumnName("Formula_Type");

                entity.Property(e => e.LabelEnText)
                    .HasColumnName("Label_En_Text")
                    .HasMaxLength(100);

                entity.Property(e => e.LableArText)
                    .HasColumnName("Lable_Ar_Text")
                    .HasMaxLength(100);

                entity.Property(e => e.TextFieldName)
                    .HasColumnName("Text_Field_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TaxGrossUpFormulaTbl>(entity =>
            {
                entity.ToTable("Tax_Gross_Up_Formula_Tbl");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GrossUpFormulaArName)
                    .HasColumnName("Gross_Up_Formula_Ar_Name")
                    .HasMaxLength(500);

                entity.Property(e => e.GrossUpFormulaEnName)
                    .HasColumnName("Gross_Up_Formula_En_Name")
                    .HasMaxLength(500);

                entity.Property(e => e.GrossUpFormulaId).HasColumnName("Gross_Up_Formula_ID");
            });

            modelBuilder.Entity<TaxRuleTbl>(entity =>
            {
                entity.HasKey(e => e.TaxRuleId);

                entity.ToTable("Tax_Rule_Tbl");

                entity.Property(e => e.TaxRuleId).HasColumnName("Tax_Rule_ID");

                entity.Property(e => e.AllowExemptionYn).HasColumnName("Allow_Exemption_YN");

                entity.Property(e => e.CalcPaymentsDeductionsDetailedYn).HasColumnName("Calc_Payments_Deductions_Detailed_YN");

                entity.Property(e => e.FixedSliceYn).HasColumnName("Fixed_Slice_YN");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.GrossUpFormulaId).HasColumnName("Gross_Up_Formula_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.MarriedExemption).HasColumnName("Married_Exemption");

                entity.Property(e => e.MarriedWithChildrenExemption).HasColumnName("Married_With_Children_Exemption");

                entity.Property(e => e.PersonalExemption).HasColumnName("Personal_Exemption");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.ProportionTheExemptionYn).HasColumnName("Proportion_The_Exemption_YN");

                entity.Property(e => e.SingleExemption).HasColumnName("Single_Exemption");

                entity.Property(e => e.SliceRate).HasColumnName("Slice_Rate");

                entity.Property(e => e.SpecialExemption).HasColumnName("Special_Exemption");

                entity.Property(e => e.TaxCaculationAlgorithm).HasColumnName("Tax_Caculation_Algorithm");

                entity.Property(e => e.TaxFormula)
                    .HasColumnName("Tax_Formula")
                    .HasMaxLength(500);

                entity.Property(e => e.TaxRuleArName)
                    .HasColumnName("Tax_Rule_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.TaxRuleArNameShadow)
                    .HasColumnName("Tax_Rule_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.TaxRuleCode)
                    .HasColumnName("Tax_Rule_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.TaxRuleEnName)
                    .HasColumnName("Tax_Rule_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.TaxableYn).HasColumnName("Taxable_YN");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<TaxSliceTbl>(entity =>
            {
                entity.HasKey(e => e.TaxSliceId);

                entity.ToTable("Tax_Slice_Tbl");

                entity.Property(e => e.TaxSliceId).HasColumnName("Tax_Slice_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.TaxRuleId).HasColumnName("Tax_Rule_ID");

                entity.Property(e => e.TaxSliceAmount).HasColumnName("Tax_Slice_Amount");

                entity.Property(e => e.TaxSliceArName)
                    .HasColumnName("Tax_Slice_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.TaxSliceArNameShadow)
                    .HasColumnName("Tax_Slice_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.TaxSliceCode)
                    .HasColumnName("Tax_Slice_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.TaxSliceEnName)
                    .HasColumnName("Tax_Slice_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.TaxSliceRate).HasColumnName("Tax_Slice_Rate");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<TempPayrollData5Tbl>(entity =>
            {
                entity.ToTable("Temp_Payroll_Data_5_Tbl");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BasicSalary).HasColumnName("Basic Salary");

                entity.Property(e => e.Bonus1).HasColumnName("Bonus 1");

                entity.Property(e => e.Bonus3).HasColumnName("Bonus 3");

                entity.Property(e => e.BranchArName).HasColumnName("Branch_Ar_Name");

                entity.Property(e => e.BranchEnName).HasColumnName("Branch_En_Name");

                entity.Property(e => e.CLCorrection).HasColumnName("C\\L Correction");

                entity.Property(e => e.CityLedger).HasColumnName("City Ledger");

                entity.Property(e => e.ContractExpireDate)
                    .HasColumnName("Contract_Expire_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContractIssueDate)
                    .HasColumnName("Contract_Issue_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartmentArName).HasColumnName("Department_Ar_Name");

                entity.Property(e => e.DepartmentEnName).HasColumnName("Department_En_Name");

                entity.Property(e => e.DivisionArName).HasColumnName("Division_Ar_Name");

                entity.Property(e => e.DivisionEnName).HasColumnName("Division_En_Name");

                entity.Property(e => e.EmpInsuranceLastPeriod).HasColumnName("Emp.Insurance (Last Period)");

                entity.Property(e => e.EmployeeCode).HasColumnName("Employee_Code");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FixedInsuranceAmount).HasColumnName("Fixed_Insurance_Amount");

                entity.Property(e => e.FoodAllowance).HasColumnName("Food Allowance");

                entity.Property(e => e.FullArName).HasColumnName("Full_Ar_Name");

                entity.Property(e => e.FullEnName).HasColumnName("Full_En_Name");

                entity.Property(e => e.HiringDate)
                    .HasColumnName("Hiring_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsuranceAdjustment).HasColumnName("Insurance_Adjustment");

                entity.Property(e => e.NetSalary).HasColumnName("Net_Salary");

                entity.Property(e => e.NetServiceCharge).HasColumnName("Net_Service_Charge");

                entity.Property(e => e.OtherAllowances).HasColumnName("Other Allowances");

                entity.Property(e => e.OutSite).HasColumnName("Out Site");

                entity.Property(e => e.PositionArName).HasColumnName("Position_Ar_Name");

                entity.Property(e => e.PositionEnName).HasColumnName("Position_En_Name");

                entity.Property(e => e.PublicHolidayAdjust).HasColumnName("Public Holiday Adjust");

                entity.Property(e => e.PublicHolidayGSc).HasColumnName("Public Holiday G.SC");

                entity.Property(e => e.PublicHolidayPayment).HasColumnName("Public Holiday Payment");

                entity.Property(e => e.PublicHolidaySerCharge).HasColumnName("Public Holiday Ser.charge");

                entity.Property(e => e.SalaryAdjustment).HasColumnName("Salary Adjustment");

                entity.Property(e => e.SalaryIncrease).HasColumnName("Salary Increase ");

                entity.Property(e => e.SalaryTax).HasColumnName("Salary_Tax");

                entity.Property(e => e.SectionArName).HasColumnName("Section_Ar_Name");

                entity.Property(e => e.SectionEnName).HasColumnName("Section_En_Name");

                entity.Property(e => e.ServiceChargeTax).HasColumnName("Service_Charge_Tax");

                entity.Property(e => e.ServiceChargeValue).HasColumnName("Service_Charge_Value");

                entity.Property(e => e.ServicePenalty).HasColumnName("Service Penalty");

                entity.Property(e => e.SickLeave).HasColumnName("Sick Leave");

                entity.Property(e => e.SocialIncrease2008).HasColumnName("Social Increase 2008");

                entity.Property(e => e.SocialIncrease2012).HasColumnName("Social Increase 2012");

                entity.Property(e => e.SocialIncrease2013).HasColumnName("Social Increase 2013");

                entity.Property(e => e.SocialIncrease2014).HasColumnName("Social Increase 2014");

                entity.Property(e => e.SocialIncreaseSc).HasColumnName("Social Increase SC");

                entity.Property(e => e.TaxAdjustment).HasColumnName("Tax_Adjustment");

                entity.Property(e => e.TaxAdjustment1).HasColumnName("Tax Adjustment");

                entity.Property(e => e.TheMonth).HasColumnName("The_Month");

                entity.Property(e => e.TheYear).HasColumnName("The_Year");

                entity.Property(e => e.TotalCompanyInsurance).HasColumnName("Total_Company_Insurance");

                entity.Property(e => e.TotalDeductions).HasColumnName("Total_Deductions");

                entity.Property(e => e.TotalEmployeeInsurance).HasColumnName("Total_Employee_Insurance");

                entity.Property(e => e.TotalLoans).HasColumnName("Total_Loans");

                entity.Property(e => e.TotalPayments).HasColumnName("Total_Payments");

                entity.Property(e => e.TransportationAllowance).HasColumnName("Transportation Allowance");

                entity.Property(e => e.UnitArName).HasColumnName("Unit_Ar_Name");

                entity.Property(e => e.UnitEnName).HasColumnName("Unit_En_Name");

                entity.Property(e => e.VacationPaymant).HasColumnName("Vacation Paymant");

                entity.Property(e => e.VariableInsuranceAmount).HasColumnName("Variable_Insurance_Amount");

                entity.Property(e => e._12Avr).HasColumnName("12% AVR");

                entity.Property(e => e._1Inc).HasColumnName("1% Inc");
            });

            modelBuilder.Entity<TerminationReasonTbl>(entity =>
            {
                entity.HasKey(e => e.TerminationReasonId);

                entity.ToTable("Termination_Reason_Tbl");

                entity.Property(e => e.TerminationReasonId).HasColumnName("Termination_Reason_ID");

                entity.Property(e => e.BlackListYn).HasColumnName("Black_List_YN");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.TerminationReasonArName)
                    .HasColumnName("Termination_Reason_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.TerminationReasonArNameShadow)
                    .HasColumnName("Termination_Reason_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.TerminationReasonCode)
                    .HasColumnName("Termination_Reason_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.TerminationReasonEnName)
                    .HasColumnName("Termination_Reason_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<TerminationTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.TerminationTransactionId);

                entity.ToTable("Termination_Transaction_Tbl");

                entity.Property(e => e.TerminationTransactionId).HasColumnName("Termination_Transaction_ID");

                entity.Property(e => e.AfterCloseMonthYn).HasColumnName("After_Close_Month_YN");

                entity.Property(e => e.DayOffBalance).HasColumnName("Day_Off_Balance");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.HolidayBalance).HasColumnName("Holiday_Balance");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.OldEmployeeStatusId).HasColumnName("Old_Employee_Status_ID");

                entity.Property(e => e.PreviousHiringDate)
                    .HasColumnName("Previous_Hiring_Date")
                    .HasColumnType("date");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.ReturnYn).HasColumnName("Return_YN");

                entity.Property(e => e.SysRequestStatusId).HasColumnName("Sys_Request_Status_ID");

                entity.Property(e => e.TerminationDate)
                    .HasColumnName("Termination_Date")
                    .HasColumnType("date");

                entity.Property(e => e.TerminationReasonId).HasColumnName("Termination_Reason_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.Property(e => e.UseInsuranceYn).HasColumnName("Use_Insurance_YN");

                entity.Property(e => e.UseLifeInsuranceYn).HasColumnName("Use_Life_Insurance_YN");

                entity.Property(e => e.VacationBalance).HasColumnName("Vacation_Balance");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TerminationTransactionTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Termination_Transaction_Tbl_Employee_Tbl");

                entity.HasOne(d => d.SysRequestStatus)
                    .WithMany(p => p.TerminationTransactionTbl)
                    .HasForeignKey(d => d.SysRequestStatusId)
                    .HasConstraintName("FK_Termination_Transaction_Tbl_Sys_Request_Status_ID");

                entity.HasOne(d => d.TerminationReason)
                    .WithMany(p => p.TerminationTransactionTbl)
                    .HasForeignKey(d => d.TerminationReasonId)
                    .HasConstraintName("FK_Termination_Transaction_Tbl_Termination_Reason_Tbl");
            });

            modelBuilder.Entity<TicketTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.TicketTransactionId);

                entity.ToTable("Ticket_Transaction_Tbl");

                entity.Property(e => e.TicketTransactionId).HasColumnName("Ticket_Transaction_ID");

                entity.Property(e => e.ChildrenTicketsConsumed).HasColumnName("Children_Tickets_Consumed");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.EmployeeTicketsConsumed).HasColumnName("Employee_Tickets_Consumed");

                entity.Property(e => e.FamilyTicketsConsumed).HasColumnName("Family_Tickets_Consumed");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.TicketDate)
                    .HasColumnName("Ticket_Date")
                    .HasColumnType("date");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TicketTransactionTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Ticket_Transaction_Tbl_Employee_Tbl");
            });

            modelBuilder.Entity<TransactionTypeTbl>(entity =>
            {
                entity.HasKey(e => e.TransactionTypeId);

                entity.ToTable("Transaction_Type_Tbl");

                entity.Property(e => e.TransactionTypeId)
                    .HasColumnName("Transaction_Type_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppSettingId).HasColumnName("App_Setting_ID");

                entity.Property(e => e.TransactionTypeArName)
                    .HasColumnName("Transaction_Type_Ar_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.TransactionTypeEnName)
                    .HasColumnName("Transaction_Type_En_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TransportationTypeTbl>(entity =>
            {
                entity.HasKey(e => e.TransportationTypeId);

                entity.ToTable("Transportation_Type_Tbl");

                entity.Property(e => e.TransportationTypeId).HasColumnName("Transportation_Type_ID");

                entity.Property(e => e.TransportationTypeArName)
                    .HasColumnName("Transportation_Type_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.TransportationTypeEnName)
                    .HasColumnName("Transportation_Type_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<UniversityTbl>(entity =>
            {
                entity.HasKey(e => e.UniversityId);

                entity.ToTable("University_Tbl");

                entity.Property(e => e.UniversityId).HasColumnName("University_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UniversityArName)
                    .HasColumnName("University_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.UniversityArNameShadow)
                    .HasColumnName("University_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.UniversityCode)
                    .HasColumnName("University_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.UniversityEnName)
                    .HasColumnName("University_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");
            });

            modelBuilder.Entity<UnlockTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.UnlockTransactionId);

                entity.ToTable("Unlock_Transaction_Tbl");

                entity.Property(e => e.UnlockTransactionId).HasColumnName("Unlock_Transaction_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.TransactionId).HasColumnName("Transaction_ID");

                entity.Property(e => e.TransactionTypeId).HasColumnName("Transaction_Type_ID");

                entity.Property(e => e.UnlockType).HasColumnName("Unlock_Type");
            });

            modelBuilder.Entity<UserFavoriteReportTbl>(entity =>
            {
                entity.HasKey(e => e.UserFavoriteReportId);

                entity.ToTable("User_Favorite_Report_Tbl");

                entity.Property(e => e.UserFavoriteReportId).HasColumnName("User_Favorite_Report_ID");

                entity.Property(e => e.DisplayOrder).HasColumnName("Display_Order");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.SysReportId).HasColumnName("Sys_Report_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.SysReport)
                    .WithMany(p => p.UserFavoriteReportTbl)
                    .HasForeignKey(d => d.SysReportId)
                    .HasConstraintName("FK_User_Favorite_Report_Tbl_Sys_Report_Tbl");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserFavoriteReportTbl)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_User_Favorite_Report_Tbl_User_Tbl");
            });

            modelBuilder.Entity<UserFormSecurityTbl>(entity =>
            {
                entity.HasKey(e => e.UserFormSecurityId)
                    .HasName("PK_Form_Security_Tbl");

                entity.ToTable("User_Form_Security_Tbl");

                entity.Property(e => e.UserFormSecurityId).HasColumnName("User_Form_Security_ID");

                entity.Property(e => e.AppMenuId).HasColumnName("App_Menu_ID");

                entity.Property(e => e.AppMenuValuePath)
                    .HasColumnName("App_Menu_Value_Path")
                    .HasMaxLength(50);

                entity.Property(e => e.DeleteYn)
                    .HasColumnName("Delete_YN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.InsertYn)
                    .HasColumnName("Insert_YN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.Property(e => e.UpdateYn)
                    .HasColumnName("Update_YN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UserGroupId).HasColumnName("User_Group_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.Property(e => e.ViewOwnedOnlyYn)
                    .HasColumnName("View_Owned_Only_YN")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ViewYn)
                    .HasColumnName("View_YN")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.AppMenu)
                    .WithMany(p => p.UserFormSecurityTbl)
                    .HasForeignKey(d => d.AppMenuId)
                    .HasConstraintName("FK_User_Form_Security_Tbl_App_Menu_Tbl");
            });

            modelBuilder.Entity<UserGeneralFunctionSecurityTbl>(entity =>
            {
                entity.HasKey(e => e.UserGeneralFunctionSecurityId);

                entity.ToTable("User_General_Function_Security_Tbl");

                entity.Property(e => e.UserGeneralFunctionSecurityId).HasColumnName("User_General_Function_Security_ID");

                entity.Property(e => e.AppMenuValuePath)
                    .HasColumnName("App_Menu_Value_Path")
                    .HasMaxLength(50);

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.Property(e => e.UserGeneralFunctionCode)
                    .IsRequired()
                    .HasColumnName("User_General_Function_Code")
                    .HasMaxLength(100);

                entity.Property(e => e.UserGeneralFunctionId).HasColumnName("User_General_Function_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");
            });

            modelBuilder.Entity<UserGeneralFunctionTbl>(entity =>
            {
                entity.HasKey(e => e.UserGeneralFunctionId)
                    .HasName("PK_User_Special_Function_Tbl");

                entity.ToTable("User_General_Function_Tbl");

                entity.Property(e => e.UserGeneralFunctionId)
                    .HasColumnName("User_General_Function_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppMenuValuePath)
                    .HasColumnName("App_Menu_Value_Path")
                    .HasMaxLength(50);

                entity.Property(e => e.DisplayOrder).HasColumnName("Display_Order");

                entity.Property(e => e.LicenseTypeId).HasColumnName("License_Type_ID");

                entity.Property(e => e.ParentId).HasColumnName("Parent_ID");

                entity.Property(e => e.UserGeneralFunctionArName)
                    .IsRequired()
                    .HasColumnName("User_General_Function_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.UserGeneralFunctionCode)
                    .IsRequired()
                    .HasColumnName("User_General_Function_Code")
                    .HasMaxLength(100);

                entity.Property(e => e.UserGeneralFunctionEnName)
                    .IsRequired()
                    .HasColumnName("User_General_Function_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<UserGeneratedReportSecurityTbl>(entity =>
            {
                entity.HasKey(e => e.UserGeneratedReportSecurityId);

                entity.ToTable("User_Generated_Report_Security_Tbl");

                entity.Property(e => e.UserGeneratedReportSecurityId).HasColumnName("User_Generated_Report_Security_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.GeneratedReportId).HasColumnName("Generated_Report_ID");

                entity.Property(e => e.GeneratedReportValuePath)
                    .HasColumnName("Generated_Report_Value_Path")
                    .HasMaxLength(50);

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.GeneratedReport)
                    .WithMany(p => p.UserGeneratedReportSecurityTbl)
                    .HasForeignKey(d => d.GeneratedReportId)
                    .HasConstraintName("FK_User_Generated_Report_Security_Tbl_Report_Generator_Tbl");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserGeneratedReportSecurityTbl)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_User_Generated_Report_Security_Tbl_User_Tbl");
            });

            modelBuilder.Entity<UserGroupFormSecurityTbl>(entity =>
            {
                entity.HasKey(e => e.UserGroupFormSecurityId);

                entity.ToTable("User_Group_Form_Security_Tbl");

                entity.Property(e => e.UserGroupFormSecurityId).HasColumnName("User_Group_Form_Security_ID");

                entity.Property(e => e.AppMenuId).HasColumnName("App_Menu_ID");

                entity.Property(e => e.AppMenuValuePath)
                    .HasColumnName("App_Menu_Value_Path")
                    .HasMaxLength(50);

                entity.Property(e => e.DeleteYn)
                    .HasColumnName("Delete_YN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.InsertYn)
                    .HasColumnName("Insert_YN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.Property(e => e.UpdateYn)
                    .HasColumnName("Update_YN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UserGroupId).HasColumnName("User_Group_ID");

                entity.Property(e => e.ViewOwnedOnlyYn)
                    .HasColumnName("View_Owned_Only_YN")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ViewYn)
                    .HasColumnName("View_YN")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<UserGroupModuleTbl>(entity =>
            {
                entity.HasKey(e => e.UserGroupModuleId);

                entity.ToTable("User_Group_Module_Tbl");

                entity.Property(e => e.UserGroupModuleId).HasColumnName("User_Group_Module_ID");

                entity.Property(e => e.AppMenuId).HasColumnName("App_Menu_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UserGroupId).HasColumnName("User_Group_ID");
            });

            modelBuilder.Entity<UserGroupReportSecurityTbl>(entity =>
            {
                entity.HasKey(e => e.UserGroupReportSecurityId);

                entity.ToTable("User_Group_Report_Security_Tbl");

                entity.Property(e => e.UserGroupReportSecurityId).HasColumnName("User_Group_Report_Security_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.ReportValuePath)
                    .HasColumnName("Report_Value_Path")
                    .HasMaxLength(50);

                entity.Property(e => e.SysReportId).HasColumnName("Sys_Report_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.Property(e => e.UserGroupId).HasColumnName("User_Group_ID");
            });

            modelBuilder.Entity<UserGroupRightsTbl>(entity =>
            {
                entity.HasKey(e => e.UserGroupRightsId)
                    .HasName("PK_User_Group_Rrights_Tbl");

                entity.ToTable("User_Group_Rights_Tbl");

                entity.Property(e => e.UserGroupRightsId).HasColumnName("User_Group_Rights_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.Property(e => e.UserGroupId).HasColumnName("User_Group_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");
            });

            modelBuilder.Entity<UserGroupTbl>(entity =>
            {
                entity.HasKey(e => e.UserGroupId);

                entity.ToTable("User_Group_Tbl");

                entity.Property(e => e.UserGroupId).HasColumnName("User_Group_ID");

                entity.Property(e => e.AppMenuId).HasColumnName("App_Menu_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.Property(e => e.UserGroupArName)
                    .HasColumnName("User_Group_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.UserGroupArNameShadow)
                    .HasColumnName("User_Group_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.UserGroupCode)
                    .HasColumnName("User_Group_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.UserGroupEnName)
                    .HasColumnName("User_Group_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<UserModuleTbl>(entity =>
            {
                entity.HasKey(e => e.UserModuleId);

                entity.ToTable("User_Module_Tbl");

                entity.Property(e => e.UserModuleId).HasColumnName("User_Module_ID");

                entity.Property(e => e.AllowedGrades).HasColumnName("Allowed_Grades");

                entity.Property(e => e.AppMenuId).HasColumnName("App_Menu_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.UserModuleTbl)
                    .HasForeignKey(d => d.PropertyId)
                    .HasConstraintName("FK_User_Module_Tbl_Property_Tbl");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserModuleTbl)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_User_Module_Tbl_User_Tbl");
            });

            modelBuilder.Entity<UserReportSecurityTbl>(entity =>
            {
                entity.HasKey(e => e.UserReportSecurityId);

                entity.ToTable("User_Report_Security_Tbl");

                entity.Property(e => e.UserReportSecurityId).HasColumnName("User_Report_Security_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.ReportValuePath)
                    .HasColumnName("Report_Value_Path")
                    .HasMaxLength(50);

                entity.Property(e => e.SysReportId).HasColumnName("Sys_Report_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.Property(e => e.UserGroupId).HasColumnName("User_Group_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.SysReport)
                    .WithMany(p => p.UserReportSecurityTbl)
                    .HasForeignKey(d => d.SysReportId)
                    .HasConstraintName("FK_User_Report_Security_Tbl_Sys_Report_Tbl");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserReportSecurityTbl)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Report_Security_Tbl_User_Tbl");
            });

            modelBuilder.Entity<UserTbl>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("User_Tbl");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.Property(e => e.ActiveUserYn).HasColumnName("Active_User_YN");

                entity.Property(e => e.DeletedYn)
                    .HasColumnName("Deleted_YN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.LastLogin)
                    .HasColumnName("Last_Login")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChanged)
                    .HasColumnName("Last_Password_Changed")
                    .HasColumnType("datetime");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.RelatedEmployeeId).HasColumnName("Related_Employee_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.Property(e => e.UserArName)
                    .HasColumnName("User_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.UserLoginName)
                    .HasColumnName("User_Login_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.UserName)
                    .HasColumnName("User_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.UserPassword).HasColumnName("User_Password");

                entity.Property(e => e.UserSecurityLevel).HasColumnName("User_Security_Level");

                entity.Property(e => e.UserType).HasColumnName("User_Type");
            });

            modelBuilder.Entity<VacationBalanceDetailsTbl>(entity =>
            {
                entity.HasKey(e => e.VacationBalanceDetailsId);

                entity.ToTable("Vacation_Balance_Details_Tbl");

                entity.Property(e => e.VacationBalanceDetailsId).HasColumnName("Vacation_Balance_Details_ID");

                entity.Property(e => e.Balance).HasDefaultValueSql("((0))");

                entity.Property(e => e.Consumption).HasDefaultValueSql("((0))");

                entity.Property(e => e.HolidayDeduction)
                    .HasColumnName("Holiday_Deduction")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LimitConsumption)
                    .HasColumnName("Limit_Consumption")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OtherConsumption)
                    .HasColumnName("Other_Consumption")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PaidConsumption)
                    .HasColumnName("Paid_Consumption")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TheMonth).HasColumnName("The_Month");

                entity.Property(e => e.TheYear).HasColumnName("The_Year");

                entity.Property(e => e.VacationBalanceId).HasColumnName("Vacation_Balance_ID");

                entity.Property(e => e.VacationDueBalance).HasColumnName("Vacation_Due_Balance");

                entity.Property(e => e.VacationRuleId).HasColumnName("Vacation_Rule_ID");

                entity.HasOne(d => d.VacationBalance)
                    .WithMany(p => p.VacationBalanceDetailsTbl)
                    .HasForeignKey(d => d.VacationBalanceId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Vacation_Balance_Details_Tbl_Vacation_Balance_Tbl");

                entity.HasOne(d => d.VacationRule)
                    .WithMany(p => p.VacationBalanceDetailsTbl)
                    .HasForeignKey(d => d.VacationRuleId)
                    .HasConstraintName("FK_Vacation_Balance_Details_Tbl_Vacation_Rule_Tbl");
            });

            modelBuilder.Entity<VacationBalanceTbl>(entity =>
            {
                entity.HasKey(e => e.VacationBalanceId);

                entity.ToTable("Vacation_Balance_Tbl");

                entity.Property(e => e.VacationBalanceId).HasColumnName("Vacation_Balance_ID");

                entity.Property(e => e.ActiveYn).HasColumnName("Active_YN");

                entity.Property(e => e.ContractDate)
                    .HasColumnName("Contract_Date")
                    .HasColumnType("date");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.SettlementYn)
                    .HasColumnName("Settlement_YN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TheYear).HasColumnName("The_Year");

                entity.Property(e => e.VacationCategoryId).HasColumnName("Vacation_Category_ID");

                entity.Property(e => e.VacationOpeningBalance).HasColumnName("Vacation_Opening_Balance");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.VacationBalanceTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Vacation_Balance_Tbl_Employee_Tbl");

                entity.HasOne(d => d.VacationCategory)
                    .WithMany(p => p.VacationBalanceTbl)
                    .HasForeignKey(d => d.VacationCategoryId)
                    .HasConstraintName("FK_Vacation_Balance_Tbl_Vacation_Category_Tbl");
            });

            modelBuilder.Entity<VacationCategoryTbl>(entity =>
            {
                entity.HasKey(e => e.VacationCategoryId);

                entity.ToTable("Vacation_Category_Tbl");

                entity.Property(e => e.VacationCategoryId).HasColumnName("Vacation_Category_ID");

                entity.Property(e => e.VacationCategoryArName)
                    .HasColumnName("Vacation_Category_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.VacationCategoryEnName)
                    .HasColumnName("Vacation_Category_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<VacationDeductionInterfaceTbl>(entity =>
            {
                entity.HasKey(e => e.VacationDeductionInterfaceId);

                entity.ToTable("Vacation_Deduction_Interface_Tbl");

                entity.Property(e => e.VacationDeductionInterfaceId).HasColumnName("Vacation_Deduction_Interface_ID");

                entity.Property(e => e.DeductionId).HasColumnName("Deduction_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.Property(e => e.VacationTypeId).HasColumnName("Vacation_Type_ID");

                entity.HasOne(d => d.Deduction)
                    .WithMany(p => p.VacationDeductionInterfaceTbl)
                    .HasForeignKey(d => d.DeductionId)
                    .HasConstraintName("FK_Vacation_Deduction_Interface_Tbl_Deduction_Tbl");

                entity.HasOne(d => d.VacationType)
                    .WithMany(p => p.VacationDeductionInterfaceTbl)
                    .HasForeignKey(d => d.VacationTypeId)
                    .HasConstraintName("FK_Vacation_Deduction_Interface_Tbl_Vacation_Type_Tbl");
            });

            modelBuilder.Entity<VacationPaymentInterfaceTbl>(entity =>
            {
                entity.HasKey(e => e.VacationPaymentInterfaceId);

                entity.ToTable("Vacation_Payment_Interface_Tbl");

                entity.Property(e => e.VacationPaymentInterfaceId).HasColumnName("Vacation_Payment_Interface_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.PaymentId).HasColumnName("Payment_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.Property(e => e.VacationTypeId).HasColumnName("Vacation_Type_ID");
            });

            modelBuilder.Entity<VacationRangeDeductionTbl>(entity =>
            {
                entity.HasKey(e => e.VacationRangeDeductionId);

                entity.ToTable("Vacation_Range_Deduction_Tbl");

                entity.Property(e => e.VacationRangeDeductionId).HasColumnName("Vacation_Range_Deduction_ID");

                entity.Property(e => e.ActiveYn).HasColumnName("Active_YN");

                entity.Property(e => e.DaysNumber).HasColumnName("Days_Number");

                entity.Property(e => e.DeductionPercentage).HasColumnName("Deduction_Percentage");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.TheMonth).HasColumnName("The_Month");

                entity.Property(e => e.TheYear).HasColumnName("The_Year");

                entity.Property(e => e.VacationRangeSliceId).HasColumnName("Vacation_Range_Slice_ID");

                entity.Property(e => e.VacationTransactionId).HasColumnName("Vacation_Transaction_ID");

                entity.Property(e => e.VacationTypeId).HasColumnName("Vacation_Type_ID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.VacationRangeDeductionTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Vacation_Range_Deduction_Tbl_Employee_Tbl");

                entity.HasOne(d => d.VacationRangeSlice)
                    .WithMany(p => p.VacationRangeDeductionTbl)
                    .HasForeignKey(d => d.VacationRangeSliceId)
                    .HasConstraintName("FK_Vacation_Range_Deduction_Tbl_Vacation_Range_Slice_Tbl");

                entity.HasOne(d => d.VacationType)
                    .WithMany(p => p.VacationRangeDeductionTbl)
                    .HasForeignKey(d => d.VacationTypeId)
                    .HasConstraintName("FK_Vacation_Range_Deduction_Tbl_Deduction_Tbl");

                entity.HasOne(d => d.VacationTypeNavigation)
                    .WithMany(p => p.VacationRangeDeductionTbl)
                    .HasForeignKey(d => d.VacationTypeId)
                    .HasConstraintName("FK_Vacation_Range_Deduction_Tbl_Vacation_Type_Tbl");
            });

            modelBuilder.Entity<VacationRangeSliceTbl>(entity =>
            {
                entity.HasKey(e => e.VacationRangeSliceId);

                entity.ToTable("Vacation_Range_Slice_Tbl");

                entity.Property(e => e.VacationRangeSliceId).HasColumnName("Vacation_Range_Slice_ID");

                entity.Property(e => e.DeductionPercentage).HasColumnName("Deduction_Percentage");

                entity.Property(e => e.FromDay).HasColumnName("From_Day");

                entity.Property(e => e.ToDay).HasColumnName("To_Day");

                entity.Property(e => e.VacationTypeId).HasColumnName("Vacation_Type_ID");

                entity.HasOne(d => d.VacationType)
                    .WithMany(p => p.VacationRangeSliceTbl)
                    .HasForeignKey(d => d.VacationTypeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Vacation_Range_Slice_Tbl_Vacation_Type_Tbl");
            });

            modelBuilder.Entity<VacationRuleAgeYearsTbl>(entity =>
            {
                entity.HasKey(e => e.VacationRuleAgeYearsId);

                entity.ToTable("Vacation_Rule_Age_Years_Tbl");

                entity.Property(e => e.VacationRuleAgeYearsId).HasColumnName("Vacation_Rule_Age_Years_ID");

                entity.Property(e => e.UpToYears).HasColumnName("Up_To_Years");

                entity.Property(e => e.VacationCategoryRate).HasColumnName("Vacation_Category_Rate");

                entity.Property(e => e.VacationRuleId).HasColumnName("Vacation_Rule_ID");

                entity.HasOne(d => d.VacationRule)
                    .WithMany(p => p.VacationRuleAgeYearsTbl)
                    .HasForeignKey(d => d.VacationRuleId)
                    .HasConstraintName("FK_Vacation_Rule_Age_Years_Tbl_Vacation_Rule_Tbl");
            });

            modelBuilder.Entity<VacationRuleTbl>(entity =>
            {
                entity.HasKey(e => e.VacationRuleId);

                entity.ToTable("Vacation_Rule_Tbl");

                entity.Property(e => e.VacationRuleId).HasColumnName("Vacation_Rule_ID");

                entity.Property(e => e.AbsenceEffectInAnnualOtherConsumbtionYn).HasColumnName("Absence_Effect_In_Annual_Other_Consumbtion_YN");

                entity.Property(e => e.AbsenceEffectInDayOffOtherConsumbtionYn).HasColumnName("Absence_Effect_In_Day_Off_Other_Consumbtion_YN");

                entity.Property(e => e.AbsenceEffectInHolidayOtherConsumbtionYn).HasColumnName("Absence_Effect_In_Holiday_Other_Consumbtion_YN");

                entity.Property(e => e.AutoAddDayOffTransactionYn).HasColumnName("Auto_Add_Day_Off_Transaction_YN");

                entity.Property(e => e.ComputeDayOffWhenOccurresInHolidayYn).HasColumnName("Compute_Day_Off_When_Occurres_In_Holiday_YN");

                entity.Property(e => e.DayOffCalculation).HasColumnName("Day_Off_Calculation");

                entity.Property(e => e.FirstDayOffId).HasColumnName("First_Day_Off_ID");

                entity.Property(e => e.FixedDayOff).HasColumnName("Fixed_Day_Off");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.HolidayCalculation).HasColumnName("Holiday_Calculation");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.MaxAnnualAmountTransferable).HasColumnName("Max_Annual_Amount_Transferable");

                entity.Property(e => e.MaxDayOffAmountTransferable).HasColumnName("Max_Day_Off_Amount_Transferable");

                entity.Property(e => e.MaxHolidayAmountTransferable).HasColumnName("Max_Holiday_Amount_Transferable");

                entity.Property(e => e.MaxMonthForAnnual).HasColumnName("Max_Month_For_Annual");

                entity.Property(e => e.MaxMonthForAnnualTransferredYn).HasColumnName("Max_Month_For_Annual_Transferred_YN");

                entity.Property(e => e.MaxMonthForDayOff).HasColumnName("Max_Month_For_Day_Off");

                entity.Property(e => e.MaxMonthForDayOffTransferredYn).HasColumnName("Max_Month_For_Day_Off_Transferred_YN");

                entity.Property(e => e.MaxMonthForHoliday).HasColumnName("Max_Month_For_Holiday");

                entity.Property(e => e.MaxMonthForHolidayTransferredYn).HasColumnName("Max_Month_For_Holiday_Transferred_YN");

                entity.Property(e => e.PercentVacationBalanceInHiringMonthYn).HasColumnName("Percent_Vacation_Balance_In_Hiring_Month_YN");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.PublicHolidayAllowanceDeductFromEmployeeBalanceYn).HasColumnName("Public_Holiday_Allowance_Deduct_From_Employee_Balance_YN");

                entity.Property(e => e.RemoteAreaDays).HasColumnName("Remote_Area_Days");

                entity.Property(e => e.RemoteAreaYn).HasColumnName("Remote_Area_YN");

                entity.Property(e => e.SecondDayOffEveryTwoWeeksYn).HasColumnName("Second_Day_Off_Every_Two_Weeks_YN");

                entity.Property(e => e.SecondDayOffId).HasColumnName("Second_Day_Off_ID");

                entity.Property(e => e.SpecialHolidayReligionId).HasColumnName("Special_Holiday_Religion_ID");

                entity.Property(e => e.StartMonth).HasColumnName("Start_Month");

                entity.Property(e => e.TransferAnnualBalanceYearlyYn).HasColumnName("Transfer_Annual_Balance_Yearly_YN");

                entity.Property(e => e.TransferDayOffBalanceYearlyYn).HasColumnName("Transfer_Day_Off_Balance_Yearly_YN");

                entity.Property(e => e.TransferHolidayBalanceYearlyYn).HasColumnName("Transfer_Holiday_Balance_Yearly_YN");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.Property(e => e.UsePublicHolidayYn).HasColumnName("Use_Public_Holiday_YN");

                entity.Property(e => e.UseSpecialHolidayYn).HasColumnName("Use_Special_Holiday_YN");

                entity.Property(e => e.VacationBalanceView).HasColumnName("Vacation_Balance_View");

                entity.Property(e => e.VacationRuleArName)
                    .HasColumnName("Vacation_Rule_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.VacationRuleArNameShadow)
                    .HasColumnName("Vacation_Rule_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.VacationRuleCode)
                    .HasColumnName("Vacation_Rule_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.VacationRuleEnName)
                    .HasColumnName("Vacation_Rule_En_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.VacationRulePeriodYearlyContract).HasColumnName("Vacation_Rule_Period_Yearly_Contract");

                entity.Property(e => e.VacationRuleWayCityResort).HasColumnName("Vacation_Rule_Way_City_Resort");

                entity.Property(e => e.ViewVacationBalanceTill).HasColumnName("View_Vacation_Balance_Till");

                entity.Property(e => e.WorkingMonthsHiringInsurance).HasColumnName("Working_Months_Hiring_Insurance");

                entity.Property(e => e.YearlyDayOffAmount).HasColumnName("Yearly_Day_Off_Amount");

                entity.HasOne(d => d.FirstDayOff)
                    .WithMany(p => p.VacationRuleTblFirstDayOff)
                    .HasForeignKey(d => d.FirstDayOffId)
                    .HasConstraintName("FK_Vacation_Rule_Tbl_Day_Of_The_Week_Tbl");

                entity.HasOne(d => d.SecondDayOff)
                    .WithMany(p => p.VacationRuleTblSecondDayOff)
                    .HasForeignKey(d => d.SecondDayOffId)
                    .HasConstraintName("FK_Vacation_Rule_Tbl_Day_Of_The_Week_Tbl1");
            });

            modelBuilder.Entity<VacationRuleWorkingMonthTbl>(entity =>
            {
                entity.HasKey(e => e.VacationRuleWorkingMonthId)
                    .HasName("PK_Rule_Working_Month_Tbl");

                entity.ToTable("Vacation_Rule_Working_Month_Tbl");

                entity.Property(e => e.VacationRuleWorkingMonthId).HasColumnName("Vacation_Rule_Working_Month_ID");

                entity.Property(e => e.UpToMonths).HasColumnName("Up_To_Months");

                entity.Property(e => e.VacationCategoryRate).HasColumnName("Vacation_Category_Rate");

                entity.Property(e => e.VacationRuleId).HasColumnName("Vacation_Rule_ID");

                entity.HasOne(d => d.VacationRule)
                    .WithMany(p => p.VacationRuleWorkingMonthTbl)
                    .HasForeignKey(d => d.VacationRuleId)
                    .HasConstraintName("FK_Vacation_Rule_Working_Month_Tbl_Vacation_Rule_Tbl");
            });

            modelBuilder.Entity<VacationTransactionTbl>(entity =>
            {
                entity.HasKey(e => new { e.VacationTransactionId, e.AttendanceTypeId });

                entity.ToTable("Vacation_Transaction_Tbl");

                entity.Property(e => e.VacationTransactionId)
                    .HasColumnName("Vacation_Transaction_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AttendanceTypeId)
                    .HasColumnName("Attendance_Type_ID")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('V')");

                entity.Property(e => e.AddressDuringThisVacation)
                    .HasColumnName("Address_During_This_Vacation")
                    .HasMaxLength(100);

                entity.Property(e => e.BalanceAfter).HasColumnName("Balance_After");

                entity.Property(e => e.ByTransportationYn).HasColumnName("By_Transportation_YN");

                entity.Property(e => e.CurrentBalance).HasColumnName("Current_Balance");

                entity.Property(e => e.DaysNumber).HasColumnName("Days_Number");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.FromDate)
                    .HasColumnName("From_Date")
                    .HasColumnType("date");

                entity.Property(e => e.IdBeforeDistribution).HasColumnName("ID_Before_Distribution");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.PendingBalance).HasColumnName("Pending_Balance");

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.ReturnDate)
                    .HasColumnName("Return_Date")
                    .HasColumnType("date");

                entity.Property(e => e.SysRequestStatusId).HasColumnName("Sys_Request_Status_ID");

                entity.Property(e => e.ThrowMachineYn).HasColumnName("Throw_Machine_YN");

                entity.Property(e => e.ToDate)
                    .HasColumnName("To_Date")
                    .HasColumnType("date");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.Property(e => e.VacationRequestDate)
                    .HasColumnName("Vacation_Request_Date")
                    .HasColumnType("date");

                entity.Property(e => e.VacationTypeId).HasColumnName("Vacation_Type_ID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.VacationTransactionTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Vacation_Transaction_Tbl_Employee_Tbl");

                entity.HasOne(d => d.SysRequestStatus)
                    .WithMany(p => p.VacationTransactionTbl)
                    .HasForeignKey(d => d.SysRequestStatusId)
                    .HasConstraintName("FK_Vacation_Transaction_Tbl_Sys_Request_Status_ID");

                entity.HasOne(d => d.VacationType)
                    .WithMany(p => p.VacationTransactionTbl)
                    .HasForeignKey(d => d.VacationTypeId)
                    .HasConstraintName("FK_Vacation_Transaction_Tbl_Vacation_Type_Tbl");
            });

            modelBuilder.Entity<VacationTypeTbl>(entity =>
            {
                entity.HasKey(e => e.VacationTypeId);

                entity.ToTable("Vacation_Type_Tbl");

                entity.Property(e => e.VacationTypeId).HasColumnName("Vacation_Type_ID");

                entity.Property(e => e.Abbreviation).HasMaxLength(5);

                entity.Property(e => e.ByRequestYn).HasColumnName("By_Request_YN");

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.DeductionRangeYn).HasColumnName("Deduction_Range_YN");

                entity.Property(e => e.DisplayInHeadCountReportYn).HasColumnName("Display_In_Head_Count_Report_YN");

                entity.Property(e => e.EffectInAnnualDueYn).HasColumnName("Effect_In_Annual_Due_YN");

                entity.Property(e => e.EffectInDayOffDueYn).HasColumnName("Effect_In_Day_Off_Due_YN");

                entity.Property(e => e.EffectInEosYn).HasColumnName("Effect_In_EOS_YN");

                entity.Property(e => e.EffectInHolidayDueYn).HasColumnName("Effect_In_Holiday_Due_YN");

                entity.Property(e => e.FixedPercentage).HasColumnName("Fixed_Percentage");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.MaxLimit).HasColumnName("Max_Limit");

                entity.Property(e => e.OtherConsumptionType).HasColumnName("Other_Consumption_Type");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.Property(e => e.VacationCategoryId).HasColumnName("Vacation_Category_ID");

                entity.Property(e => e.VacationOverlappingType).HasColumnName("Vacation_Overlapping_Type");

                entity.Property(e => e.VacationTypeArName)
                    .HasColumnName("Vacation_Type_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.VacationTypeArNameShadow)
                    .HasColumnName("Vacation_Type_Ar_Name_Shadow")
                    .HasMaxLength(100);

                entity.Property(e => e.VacationTypeCode)
                    .HasColumnName("Vacation_Type_Code")
                    .HasMaxLength(10);

                entity.Property(e => e.VacationTypeEnName)
                    .HasColumnName("Vacation_Type_En_Name")
                    .HasMaxLength(100);

                entity.HasOne(d => d.VacationCategory)
                    .WithMany(p => p.VacationTypeTbl)
                    .HasForeignKey(d => d.VacationCategoryId)
                    .HasConstraintName("FK_Vacation_Type_Tbl_Vacation_Category_Tbl");
            });

            modelBuilder.Entity<WorkInGovernmentTypeTbl>(entity =>
            {
                entity.HasKey(e => e.WorkInGovernmentTypeId);

                entity.ToTable("Work_In_Government_Type_Tbl");

                entity.Property(e => e.WorkInGovernmentTypeId).HasColumnName("Work_In_Government_Type_ID");

                entity.Property(e => e.WorkInGovernmentTypeArName)
                    .HasColumnName("Work_In_Government_Type_Ar_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.WorkInGovernmentTypeEnName)
                    .HasColumnName("Work_In_Government_Type_En_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<WorkPermissionTransactionTbl>(entity =>
            {
                entity.HasKey(e => e.WorkPermissionTransactionId);

                entity.ToTable("Work_Permission_Transaction_Tbl");

                entity.Property(e => e.WorkPermissionTransactionId).HasColumnName("Work_Permission_Transaction_ID");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.ExpireDate)
                    .HasColumnName("Expire_Date")
                    .HasColumnType("date");

                entity.Property(e => e.FormId).HasColumnName("Form_ID");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("Insert_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUserId).HasColumnName("Insert_User_ID");

                entity.Property(e => e.IssueDate)
                    .HasColumnName("Issue_Date")
                    .HasColumnType("date");

                entity.Property(e => e.IssuePlace)
                    .HasColumnName("Issue_Place")
                    .HasMaxLength(50);

                entity.Property(e => e.MachineId).HasColumnName("Machine_ID");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.PermissionNumber)
                    .HasColumnName("Permission_Number")
                    .HasMaxLength(20);

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("Update_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId).HasColumnName("Update_User_ID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.WorkPermissionTransactionTbl)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Work_Permission_Transaction_Tbl_Employee_Tbl");
            });

            modelBuilder.Entity<YearTbl>(entity =>
            {
                entity.HasKey(e => e.YearId);

                entity.ToTable("Year_Tbl");

                entity.Property(e => e.YearId)
                    .HasColumnName("Year_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.YearArName)
                    .HasColumnName("Year_Ar_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.YearEnName)
                    .HasColumnName("Year_EN_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<YearlyHeadCountReportDetailsTbl>(entity =>
            {
                entity.HasKey(e => e.YearlyHeadCountReportDetailsId);

                entity.ToTable("Yearly_Head_Count_Report_Details_Tbl");

                entity.Property(e => e.YearlyHeadCountReportDetailsId).HasColumnName("Yearly_Head_Count_Report_Details_ID");

                entity.Property(e => e.HierarchyId).HasColumnName("Hierarchy_ID");

                entity.Property(e => e.HierarchyType)
                    .HasColumnName("Hierarchy_Type")
                    .HasMaxLength(5);

                entity.Property(e => e.Month1).HasColumnName("Month_1");

                entity.Property(e => e.Month10).HasColumnName("Month_10");

                entity.Property(e => e.Month11).HasColumnName("Month_11");

                entity.Property(e => e.Month12).HasColumnName("Month_12");

                entity.Property(e => e.Month2).HasColumnName("Month_2");

                entity.Property(e => e.Month3).HasColumnName("Month_3");

                entity.Property(e => e.Month4).HasColumnName("Month_4");

                entity.Property(e => e.Month5).HasColumnName("Month_5");

                entity.Property(e => e.Month6).HasColumnName("Month_6");

                entity.Property(e => e.Month7).HasColumnName("Month_7");

                entity.Property(e => e.Month8).HasColumnName("Month_8");

                entity.Property(e => e.Month9).HasColumnName("Month_9");

                entity.Property(e => e.PropertyId).HasColumnName("Property_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");
            });
        }
    }
}
