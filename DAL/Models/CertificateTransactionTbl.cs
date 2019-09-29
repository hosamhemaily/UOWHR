using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CertificateTransactionTbl
    {
        public long CertificateTransactionId { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public long? CertificateId { get; set; }
        public string CertificateNumber { get; set; }
        public string IssuePlace { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public long? CertificateTypeId { get; set; }
        public string Notes { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual CertificateTbl Certificate { get; set; }
        public virtual CertificateTypeTbl CertificateType { get; set; }
        public virtual EmployeeTbl Employee { get; set; }
    }
}
