using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class DocumentArchiveTbl
    {
        public long DocumentArchiveId { get; set; }
        public long? PropertyId { get; set; }
        public long? MasterId { get; set; }
        public long? EmployeeId { get; set; }
        public string DocumentTableName { get; set; }
        public string DocumentFileName { get; set; }
        public string DocumentPath { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public int? SysDocumentTypeId { get; set; }
    }
}
