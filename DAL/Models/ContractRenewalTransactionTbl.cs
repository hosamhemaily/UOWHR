using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ContractRenewalTransactionTbl
    {
        public long ContractRenewalTransactionId { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public DateTime? RenewalDate { get; set; }
        public long? OldContractId { get; set; }
        public DateTime? OldContractDate { get; set; }
        public DateTime? OldContractExpireDate { get; set; }
        public long? NewContractId { get; set; }
        public DateTime? NewContractDate { get; set; }
        public DateTime? NewContractExpireDate { get; set; }
        public int? ContractNumber { get; set; }
        public string Notes { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual EmployeeTbl Employee { get; set; }
        public virtual ContractTbl NewContract { get; set; }
        public virtual ContractTbl OldContract { get; set; }
    }
}
