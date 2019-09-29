using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class CertificateTbl
    {
        public CertificateTbl()
        {
            CertificateTransactionTbl = new HashSet<CertificateTransactionTbl>();
            PositionConfigurationTbl = new HashSet<PositionConfigurationTbl>();
        }

        public long CertificateId { get; set; }
        public long? PropertyId { get; set; }
        public string CertificateCode { get; set; }
        public string CertificateEnName { get; set; }
        public string CertificateArName { get; set; }
        public string CertificateArNameShadow { get; set; }
        public bool? ExpireYn { get; set; }
        public int? ExpireMonths { get; set; }
        public bool? HasTypeYn { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<CertificateTransactionTbl> CertificateTransactionTbl { get; set; }
        public virtual ICollection<PositionConfigurationTbl> PositionConfigurationTbl { get; set; }
    }
}
