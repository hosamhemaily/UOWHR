using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class ReportSignatureTbl
    {
        public long ReportSignatureId { get; set; }
        public long? PropertyId { get; set; }
        public long? SysReportId { get; set; }
        public string SignatureTitleEnNo1 { get; set; }
        public string SignatureTitleArNo1 { get; set; }
        public long? SignatureEmployeeIdNo1 { get; set; }
        public string SignatureTitleEnNo2 { get; set; }
        public string SignatureTitleArNo2 { get; set; }
        public long? SignatureEmployeeIdNo2 { get; set; }
        public string SignatureTitleEnNo3 { get; set; }
        public string SignatureTitleArNo3 { get; set; }
        public long? SignatureEmployeeIdNo3 { get; set; }
        public string SignatureTitleEnNo4 { get; set; }
        public string SignatureTitleArNo4 { get; set; }
        public long? SignatureEmployeeIdNo4 { get; set; }
        public string SignatureTitleEnNo5 { get; set; }
        public string SignatureTitleArNo5 { get; set; }
        public long? SignatureEmployeeIdNo5 { get; set; }
        public string SignatureTitleEnNo6 { get; set; }
        public string SignatureTitleArNo6 { get; set; }
        public long? SignatureEmployeeIdNo6 { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
    }
}
