using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class DeductionTypeTbl
    {
        public long Id { get; set; }
        public byte DeductionTypeId { get; set; }
        public string DeductionTypeEnName { get; set; }
        public string DeductionTypeArName { get; set; }
    }
}
