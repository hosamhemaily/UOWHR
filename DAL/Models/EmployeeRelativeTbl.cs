using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class EmployeeRelativeTbl
    {
        public EmployeeRelativeTbl()
        {
            MedicalFamilyCardsTransactionTbl = new HashSet<MedicalFamilyCardsTransactionTbl>();
            MedicalFamilyInvoiceTransactionTbl = new HashSet<MedicalFamilyInvoiceTransactionTbl>();
            MedicalFamilyMonthlyMedicineTransactionTbl = new HashSet<MedicalFamilyMonthlyMedicineTransactionTbl>();
            MedicalFamilyVisitTransactionTbl = new HashSet<MedicalFamilyVisitTransactionTbl>();
        }

        public long EmployeeRelativeId { get; set; }
        public long? EmployeeId { get; set; }
        public bool? InternalEmployeeYn { get; set; }
        public long? RelatedEmployeeId { get; set; }
        public long? RelativeDegreeId { get; set; }
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
        public bool? EmployeeIsSponsorYn { get; set; }
        public long? SponsorId { get; set; }
        public DateTime? Birthdate { get; set; }
        public byte? GenderId { get; set; }
        public long? ReligionId { get; set; }
        public long? MaritalStatusId { get; set; }
        public long? NationalityId { get; set; }
        public string Position { get; set; }
        public string AddressEn { get; set; }
        public string AddressAr { get; set; }
        public long? GovernorateId { get; set; }
        public long? CountryId { get; set; }
        public string PostalCode { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public string BusinessEmail { get; set; }
        public string PersonalEmail { get; set; }
        public string CivilIdNumber { get; set; }
        public byte? CivilIdTypeId { get; set; }
        public DateTime? CivilIdIssueDate { get; set; }
        public DateTime? CivilIdExpireDate { get; set; }
        public string PassportNumber { get; set; }
        public string PassportIssuePlace { get; set; }
        public DateTime? PassportIssueDate { get; set; }
        public DateTime? PassportExpireDate { get; set; }
        public string ResidencyNumber { get; set; }
        public long? ResidencyTypeId { get; set; }
        public string ResidencyIssuePlace { get; set; }
        public DateTime? ResidencyIssueDate { get; set; }
        public DateTime? ResidencyExpireDate { get; set; }
        public bool? ForeignerYn { get; set; }
        public string Notes { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual CivilIdTypeTbl CivilIdType { get; set; }
        public virtual CountryTbl Country { get; set; }
        public virtual EmployeeTbl Employee { get; set; }
        public virtual GenderTbl Gender { get; set; }
        public virtual GovernorateTbl Governorate { get; set; }
        public virtual MaritalStatusTbl MaritalStatus { get; set; }
        public virtual NationalityTbl Nationality { get; set; }
        public virtual PrefixTbl Prefix { get; set; }
        public virtual RelativeDegreeTbl RelativeDegree { get; set; }
        public virtual ReligionTbl Religion { get; set; }
        public virtual ResidencyTypeTbl ResidencyType { get; set; }
        public virtual SponsorTbl Sponsor { get; set; }
        public virtual ICollection<MedicalFamilyCardsTransactionTbl> MedicalFamilyCardsTransactionTbl { get; set; }
        public virtual ICollection<MedicalFamilyInvoiceTransactionTbl> MedicalFamilyInvoiceTransactionTbl { get; set; }
        public virtual ICollection<MedicalFamilyMonthlyMedicineTransactionTbl> MedicalFamilyMonthlyMedicineTransactionTbl { get; set; }
        public virtual ICollection<MedicalFamilyVisitTransactionTbl> MedicalFamilyVisitTransactionTbl { get; set; }
    }
}
