using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class SponsorTypeTbl
    {
        public SponsorTypeTbl()
        {
            SponsorTbl = new HashSet<SponsorTbl>();
        }

        public byte SponsorTypeId { get; set; }
        public string SponsorTypeEnName { get; set; }
        public string SponsorTypeArName { get; set; }

        public virtual ICollection<SponsorTbl> SponsorTbl { get; set; }
    }
}
