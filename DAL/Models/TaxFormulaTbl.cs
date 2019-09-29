using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TaxFormulaTbl
    {
        public int FormulaId { get; set; }
        public string FormulaEnName { get; set; }
        public string FormulaArName { get; set; }
        public string TextFieldName { get; set; }
        public string LabelEnText { get; set; }
        public string LableArText { get; set; }
        public int? FormulaType { get; set; }
    }
}
