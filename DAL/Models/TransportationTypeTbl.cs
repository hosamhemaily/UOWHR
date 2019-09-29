using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TransportationTypeTbl
    {
        public TransportationTypeTbl()
        {
            EmployeeTbl = new HashSet<EmployeeTbl>();
        }

        public byte TransportationTypeId { get; set; }
        public string TransportationTypeEnName { get; set; }
        public string TransportationTypeArName { get; set; }

        public virtual ICollection<EmployeeTbl> EmployeeTbl { get; set; }
    }
}
