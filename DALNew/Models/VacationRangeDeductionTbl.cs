using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class VacationRangeDeductionTbl
    {
        public long VacationRangeDeductionId { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public int? TheYear { get; set; }
        public int? TheMonth { get; set; }
        public long? VacationTransactionId { get; set; }
        public long? VacationTypeId { get; set; }
        public long? VacationRangeSliceId { get; set; }
        public int? DaysNumber { get; set; }
        public double? DeductionPercentage { get; set; }
        public bool? ActiveYn { get; set; }

        public virtual EmployeeTbl Employee { get; set; }
        public virtual VacationRangeSliceTbl VacationRangeSlice { get; set; }
        public virtual DeductionTbl VacationType { get; set; }
        public virtual VacationTypeTbl VacationTypeNavigation { get; set; }
    }
}
