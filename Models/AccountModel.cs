using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class AccountModel
    {
        public long AccountNumberId { get; set; }
        public long? PropertyId { get; set; }
        public string AccountNumberCode { get; set; }
        public string AccountNumberEnName { get; set; }
        public string AccountNumberArName { get; set; }
        public string AccountNumberArNameShadow { get; set; }
        public string AccountNumberJvDescription { get; set; }
        public bool? AnalyticalYn { get; set; }
        public string GeneralAccountNumber { get; set; }
        public string GuestContactAccountNumber { get; set; }
        public string NonGuestContactAccountNumber { get; set; }
        public string OtherGuestContactAccountNumber { get; set; }
        public string ManagersAccountNumber { get; set; }
        public string ForeignersAccountNumber { get; set; }
        public string HandicappedAccountNumber { get; set; }
        public string ClearanceAccountNumber { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
    }
}
