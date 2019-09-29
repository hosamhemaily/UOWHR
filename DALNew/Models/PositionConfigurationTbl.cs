using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class PositionConfigurationTbl
    {
        public long PositionConfigurationId { get; set; }
        public long PositionId { get; set; }
        public long CertificateId { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual CertificateTbl Certificate { get; set; }
        public virtual PositionTbl Position { get; set; }
    }
}
