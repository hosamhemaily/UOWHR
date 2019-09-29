using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class BusWayTbl
    {
        public BusWayTbl()
        {
            EmployeeTbl = new HashSet<EmployeeTbl>();
        }

        public long BusWayId { get; set; }
        public long? PropertyId { get; set; }
        public string BusWayCode { get; set; }
        public string BusWayEnName { get; set; }
        public string BusWayArName { get; set; }
        public string BusWayArNameShadow { get; set; }
        public int? Capacity { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<EmployeeTbl> EmployeeTbl { get; set; }
    }
}
