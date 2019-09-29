using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ContractTbl
    {
        public ContractTbl()
        {
            ContractRenewalTransactionTblNewContract = new HashSet<ContractRenewalTransactionTbl>();
            ContractRenewalTransactionTblOldContract = new HashSet<ContractRenewalTransactionTbl>();
            EmployeeTbl = new HashSet<EmployeeTbl>();
        }

        public long ContractId { get; set; }
        public long? PropertyId { get; set; }
        public string ContractCode { get; set; }
        public string ContractEnName { get; set; }
        public string ContractArName { get; set; }
        public string ContractArNameShadow { get; set; }
        public int? ContractMonths { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<ContractRenewalTransactionTbl> ContractRenewalTransactionTblNewContract { get; set; }
        public virtual ICollection<ContractRenewalTransactionTbl> ContractRenewalTransactionTblOldContract { get; set; }
        public virtual ICollection<EmployeeTbl> EmployeeTbl { get; set; }
    }
}
