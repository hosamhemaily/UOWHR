using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class VacationRangeSliceTbl
    {
        public VacationRangeSliceTbl()
        {
            VacationRangeDeductionTbl = new HashSet<VacationRangeDeductionTbl>();
        }

        public long VacationRangeSliceId { get; set; }
        public long? VacationTypeId { get; set; }
        public int? FromDay { get; set; }
        public int? ToDay { get; set; }
        public double? DeductionPercentage { get; set; }

        public virtual VacationTypeTbl VacationType { get; set; }
        public virtual ICollection<VacationRangeDeductionTbl> VacationRangeDeductionTbl { get; set; }
    }
}
