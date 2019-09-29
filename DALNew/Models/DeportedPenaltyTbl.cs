using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class DeportedPenaltyTbl
    {
        public long DeportedPenaltyId { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public int? TheYear { get; set; }
        public int? TheMonth { get; set; }
        public double? PenaltyAmount { get; set; }
    }
}
