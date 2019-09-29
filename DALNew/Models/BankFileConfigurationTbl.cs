using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class BankFileConfigurationTbl
    {
        public BankFileConfigurationTbl()
        {
            BankFileConfigurationDetailsTbl = new HashSet<BankFileConfigurationDetailsTbl>();
        }

        public long BankFileConfigurationId { get; set; }
        public long? PropertyId { get; set; }
        public long? BankId { get; set; }
        public int? FileTypeExcelText { get; set; }
        public bool? UseHeaderDateYn { get; set; }
        public string HeaderDateSeprator { get; set; }
        public int? HeaderDateSpaceNumber { get; set; }
        public int? HeaderDateWidth { get; set; }
        public int? HeaderDateOrder { get; set; }
        public bool? UseHeaderPropertyNameYn { get; set; }
        public string HeaderPropertyNameSeprator { get; set; }
        public int? HeaderPropertyNameSpaceNumber { get; set; }
        public int? HeaderPropertyNameWidth { get; set; }
        public int? HeaderPropertyNameOrder { get; set; }
        public bool? UseHeaderPropertyAccountNumberYn { get; set; }
        public string HeaderPropertyAccountNumber { get; set; }
        public string HeaderPropertyAccountNumberSeprator { get; set; }
        public int? HeaderPropertyAccountNumberSpaceNumber { get; set; }
        public int? HeaderPropertyAccountNumberWidth { get; set; }
        public int? HeaderPropertyAccountNumberOrder { get; set; }
        public bool? DisplayColumnsHeadersYn { get; set; }
        public bool? UseFooterTotalEmployeesNumberYn { get; set; }
        public string FooterTotalEmployeesNumberSeprator { get; set; }
        public int? FooterTotalEmployeesNumberSpaceNumber { get; set; }
        public int? FooterTotalEmployeesNumberWidth { get; set; }
        public int? FooterTotalEmployeesNumberOrder { get; set; }
        public bool? UseFooterTotalAmountYn { get; set; }
        public int? FooterTotalAmountDecimal { get; set; }
        public string FooterTotalAmountSeprator { get; set; }
        public int? FooterTotalAmountSpaceNumber { get; set; }
        public int? FooterTotalAmountWidth { get; set; }
        public int? FooterTotalAmountOrder { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public byte? BankWbs { get; set; }
        public bool? UseHeaderReferenceCodeYn { get; set; }
        public string HeaderReferenceCode { get; set; }
        public string HeaderReferenceCodeSeprator { get; set; }
        public int? HeaderReferenceCodeSpaceNumber { get; set; }
        public int? HeaderReferenceCodeWidth { get; set; }
        public int? HeaderReferenceCodeOrder { get; set; }
        public int? HeaderDateFormatId { get; set; }
        public string HeaderPropertyAccountNumberFillPlace { get; set; }
        public string HeaderPropertyAccountNumberBlankCharacter { get; set; }
        public string FooterTotalEmpFillPlace { get; set; }
        public string FooterTotalEmpBlankCharacter { get; set; }
        public string FooterTotalAmountFillPlace { get; set; }
        public string FooterTotalAmountBlankCharacter { get; set; }
        public bool? UseFooterReferenceCodeYn { get; set; }
        public string FooterReferenceCode { get; set; }
        public string FooterReferenceCodeSeprator { get; set; }
        public int? FooterReferenceCodeSpaceNumber { get; set; }
        public int? FooterReferenceCodeWidth { get; set; }
        public int? FooterReferenceCodeOrder { get; set; }
        public bool? UseHeaderActionDateYn { get; set; }
        public string HeaderActionDateSeprator { get; set; }
        public int? HeaderActionDateSpaceNumber { get; set; }
        public int? HeaderActionDateWidth { get; set; }
        public int? HeaderActionDateOrder { get; set; }
        public int? HeaderActionDateFormatId { get; set; }

        public virtual ICollection<BankFileConfigurationDetailsTbl> BankFileConfigurationDetailsTbl { get; set; }
    }
}
