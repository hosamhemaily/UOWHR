using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class TaxSliceTbl
    {
        public long TaxSliceId { get; set; }
        public long? PropertyId { get; set; }
        public long? TaxRuleId { get; set; }
        public string TaxSliceCode { get; set; }
        public string TaxSliceEnName { get; set; }
        public string TaxSliceArName { get; set; }
        public string TaxSliceArNameShadow { get; set; }
        public double? TaxSliceAmount { get; set; }
        public double? TaxSliceRate { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
    }
}
