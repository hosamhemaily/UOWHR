using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class OrganizationLegalFormTbl
    {
        public OrganizationLegalFormTbl()
        {
            EmployeeTbl = new HashSet<EmployeeTbl>();
        }

        public long OrganizationLegalFormId { get; set; }
        public long? PropertyId { get; set; }
        public string OrganizationCode { get; set; }
        public string OrganizationLegalFormEnName { get; set; }
        public string OrganizationLegalFormArName { get; set; }
        public string OrganizationLegalFormArNameShadow { get; set; }
        public long? InsuranceOfficeId { get; set; }
        public string OrganizationLegalFormDescription { get; set; }
        public string Area { get; set; }
        public string InsuranceNumber { get; set; }
        public string BuildingNumber { get; set; }
        public string StreetName { get; set; }
        public string Village { get; set; }
        public string Station { get; set; }
        public long? GovernorateId { get; set; }
        public string InfectInsuranceRate { get; set; }
        public DateTime? InfectStartingDate { get; set; }
        public string DiseaseInsuranceRate { get; set; }
        public DateTime? DiseaseStartingDate { get; set; }
        public DateTime? StopContinuationDate { get; set; }
        public string StopReason { get; set; }
        public string StartActivity { get; set; }
        public string PositionOfArticle42 { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public string TaxOffice { get; set; }
        public string TaxOfficeAddress { get; set; }
        public string TaxFileNumber { get; set; }
        public long? EmployeeInsuranceAccountNumberId { get; set; }
        public long? CompanyInsuranceCreditAccountNumberId { get; set; }
        public long? CompanyInsuranceDebitAccountNumberId { get; set; }
        public string InsuranceJournalType { get; set; }
        public long? EmployeeHealthInsuranceAccountNumberId { get; set; }
        public long? CompanyInsuranceCreditHealthAccountNumberId { get; set; }
        public long? CompanyInsuranceDebitHealthAccountNumberId { get; set; }

        public virtual GovernorateTbl Governorate { get; set; }
        public virtual InsuranceOfficeTbl InsuranceOffice { get; set; }
        public virtual ICollection<EmployeeTbl> EmployeeTbl { get; set; }
    }
}
