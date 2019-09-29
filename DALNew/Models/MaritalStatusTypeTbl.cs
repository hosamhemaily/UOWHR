using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class MaritalStatusTypeTbl
    {
        public MaritalStatusTypeTbl()
        {
            MaritalStatusTbl = new HashSet<MaritalStatusTbl>();
        }

        public byte MaritalStatusTypeId { get; set; }
        public string MaritalStatusTypeEnName { get; set; }
        public string MaritalStatusTypeArName { get; set; }

        public virtual ICollection<MaritalStatusTbl> MaritalStatusTbl { get; set; }
    }
}
