using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class RelativeDegreeTypeTbl
    {
        public RelativeDegreeTypeTbl()
        {
            RelativeDegreeTbl = new HashSet<RelativeDegreeTbl>();
        }

        public byte RelativeDegreeTypeId { get; set; }
        public string RelativeDegreeTypeEnName { get; set; }
        public string RelativeDegreeTypeArName { get; set; }

        public virtual ICollection<RelativeDegreeTbl> RelativeDegreeTbl { get; set; }
    }
}
