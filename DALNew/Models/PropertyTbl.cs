using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class PropertyTbl
    {
        public PropertyTbl()
        {
            EmailConfigurationTbl = new HashSet<EmailConfigurationTbl>();
            EmployeeCostCenterTbl = new HashSet<EmployeeCostCenterTbl>();
            EmployeeMonthlySalaryTbl = new HashSet<EmployeeMonthlySalaryTbl>();
            EmployeeSharedPropertyTbl = new HashSet<EmployeeSharedPropertyTbl>();
            EmployeeTbl = new HashSet<EmployeeTbl>();
            ModuleGenericEmailTbl = new HashSet<ModuleGenericEmailTbl>();
            ServiceChargeTransactionTbl = new HashSet<ServiceChargeTransactionTbl>();
            SmsConfigurationTbl = new HashSet<SmsConfigurationTbl>();
            TaxBalanceTransactionTbl = new HashSet<TaxBalanceTransactionTbl>();
            UserModuleTbl = new HashSet<UserModuleTbl>();
        }

        public long PropertyId { get; set; }
        public string PropertyCode { get; set; }
        public string PropertyEnName { get; set; }
        public string PropertyArName { get; set; }
        public string PropertyArNameShadow { get; set; }
        public string CostCenter { get; set; }
        public int? StartPeriod { get; set; }
        public int? EndPeriod { get; set; }
        public int? CurrentMonth { get; set; }
        public int? CurrentYear { get; set; }
        public long? GmId { get; set; }
        public long? HrmId { get; set; }
        public long? FcId { get; set; }
        public string CustomerCode { get; set; }
        public string LicenseCode { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int? NoOfEmployees { get; set; }
        public byte? LicenseTypeId { get; set; }
        public long? ChainId { get; set; }
        public string PropertyLogoFileName { get; set; }
        public string PropertyLogoFilePath { get; set; }
        public DateTime? StartLiveDate { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public int? FirstMonth { get; set; }
        public int? FirstYear { get; set; }
        public string UnlimitedYn { get; set; }
        public string MultiPropertyYn { get; set; }
        public string TranslatorKey { get; set; }
        public int? ExpiredMonth { get; set; }
        public int? ExpiredYear { get; set; }

        public virtual LicenseTypeTbl LicenseType { get; set; }
        public virtual ICollection<EmailConfigurationTbl> EmailConfigurationTbl { get; set; }
        public virtual ICollection<EmployeeCostCenterTbl> EmployeeCostCenterTbl { get; set; }
        public virtual ICollection<EmployeeMonthlySalaryTbl> EmployeeMonthlySalaryTbl { get; set; }
        public virtual ICollection<EmployeeSharedPropertyTbl> EmployeeSharedPropertyTbl { get; set; }
        public virtual ICollection<EmployeeTbl> EmployeeTbl { get; set; }
        public virtual ICollection<ModuleGenericEmailTbl> ModuleGenericEmailTbl { get; set; }
        public virtual ICollection<ServiceChargeTransactionTbl> ServiceChargeTransactionTbl { get; set; }
        public virtual ICollection<SmsConfigurationTbl> SmsConfigurationTbl { get; set; }
        public virtual ICollection<TaxBalanceTransactionTbl> TaxBalanceTransactionTbl { get; set; }
        public virtual ICollection<UserModuleTbl> UserModuleTbl { get; set; }
    }
}
