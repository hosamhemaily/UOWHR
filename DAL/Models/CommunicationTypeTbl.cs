using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CommunicationTypeTbl
    {
        public CommunicationTypeTbl()
        {
            EmployeeCommunicationTbl = new HashSet<EmployeeCommunicationTbl>();
        }

        public byte CommunicationTypeId { get; set; }
        public string CommunicationTypeEnName { get; set; }
        public string CommunicationTypeArName { get; set; }

        public virtual ICollection<EmployeeCommunicationTbl> EmployeeCommunicationTbl { get; set; }
    }
}
