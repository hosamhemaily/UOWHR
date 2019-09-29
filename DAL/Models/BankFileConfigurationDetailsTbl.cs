using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class BankFileConfigurationDetailsTbl
    {
        public long BankFileConfigurationDetailsId { get; set; }
        public long? BankFileConfigurationId { get; set; }
        public string DetailsType { get; set; }
        public long? DetailsId { get; set; }
        public string DetailsColumnHeader { get; set; }
        public string DetailsSeprator { get; set; }
        public int? DetailsSpaceNumber { get; set; }
        public int? DetailsWidth { get; set; }
        public int? DetailsOrder { get; set; }
        public int? DetailsNoDecimals { get; set; }
        public string DetailsValue { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public string DetailsBlankFillPlace { get; set; }
        public string DetailsBlankCharacter { get; set; }

        public virtual BankFileConfigurationTbl BankFileConfiguration { get; set; }
    }
}
