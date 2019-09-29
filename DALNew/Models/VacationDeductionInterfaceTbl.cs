using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class VacationDeductionInterfaceTbl
    {
        public long VacationDeductionInterfaceId { get; set; }
        public long? PropertyId { get; set; }
        public long? VacationTypeId { get; set; }
        public long? DeductionId { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual DeductionTbl Deduction { get; set; }
        public virtual VacationTypeTbl VacationType { get; set; }
    }
}
