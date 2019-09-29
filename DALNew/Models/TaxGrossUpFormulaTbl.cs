using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class TaxGrossUpFormulaTbl
    {
        public long Id { get; set; }
        public int GrossUpFormulaId { get; set; }
        public string GrossUpFormulaEnName { get; set; }
        public string GrossUpFormulaArName { get; set; }
    }
}
