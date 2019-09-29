using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class EmployeeAddressTbl
    {
        public long EmployeeAddressId { get; set; }
        public long? EmployeeId { get; set; }
        public string AddressEn { get; set; }
        public string AreaEn { get; set; }
        public string AddressAr { get; set; }
        public string AreaAr { get; set; }
        public long? GovernorateId { get; set; }
        public long? CountryId { get; set; }
        public string PostalCode { get; set; }
        public bool? PrimaryYn { get; set; }
        public string AddressNotes { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual CountryTbl Country { get; set; }
        public virtual EmployeeTbl Employee { get; set; }
        public virtual GovernorateTbl Governorate { get; set; }
    }
}
