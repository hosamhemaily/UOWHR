using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class LicenseTypeTbl
    {
        public LicenseTypeTbl()
        {
            AppMenuTbl = new HashSet<AppMenuTbl>();
            PropertyTbl = new HashSet<PropertyTbl>();
        }

        public byte LicenseTypeId { get; set; }
        public string LicenseTypeEnName { get; set; }
        public string LicenseTypeArName { get; set; }
        public string LicenseName { get; set; }

        public virtual ICollection<AppMenuTbl> AppMenuTbl { get; set; }
        public virtual ICollection<PropertyTbl> PropertyTbl { get; set; }
    }
}
