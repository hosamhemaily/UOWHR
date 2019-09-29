using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class CertificateTypeTbl
    {
        public CertificateTypeTbl()
        {
            CertificateTransactionTbl = new HashSet<CertificateTransactionTbl>();
        }

        public long CertificateTypeId { get; set; }
        public long? CertificateId { get; set; }
        public string CertificateTypeCode { get; set; }
        public string CertificateTypeEnName { get; set; }
        public string CertificateTypeArName { get; set; }
        public string CertificateTypeArNameShadow { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<CertificateTransactionTbl> CertificateTransactionTbl { get; set; }
    }
}
