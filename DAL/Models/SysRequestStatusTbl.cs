using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SysRequestStatusTbl
    {
        public SysRequestStatusTbl()
        {
            AbsenceTransactionTbl = new HashSet<AbsenceTransactionTbl>();
            BenefitTransactionTbl = new HashSet<BenefitTransactionTbl>();
            CustodyTransactionTbl = new HashSet<CustodyTransactionTbl>();
            MissionTransactionTbl = new HashSet<MissionTransactionTbl>();
            PenaltyTransactionTbl = new HashSet<PenaltyTransactionTbl>();
            PermissionTransactionTbl = new HashSet<PermissionTransactionTbl>();
            SelfServiceApprovalTbl = new HashSet<SelfServiceApprovalTbl>();
            SelfServiceRequestTbl = new HashSet<SelfServiceRequestTbl>();
            TerminationTransactionTbl = new HashSet<TerminationTransactionTbl>();
            VacationTransactionTbl = new HashSet<VacationTransactionTbl>();
        }

        public int SysRequestStatusId { get; set; }
        public string SysRequestStatusEnName { get; set; }
        public string SysRequestStatusArName { get; set; }

        public virtual ICollection<AbsenceTransactionTbl> AbsenceTransactionTbl { get; set; }
        public virtual ICollection<BenefitTransactionTbl> BenefitTransactionTbl { get; set; }
        public virtual ICollection<CustodyTransactionTbl> CustodyTransactionTbl { get; set; }
        public virtual ICollection<MissionTransactionTbl> MissionTransactionTbl { get; set; }
        public virtual ICollection<PenaltyTransactionTbl> PenaltyTransactionTbl { get; set; }
        public virtual ICollection<PermissionTransactionTbl> PermissionTransactionTbl { get; set; }
        public virtual ICollection<SelfServiceApprovalTbl> SelfServiceApprovalTbl { get; set; }
        public virtual ICollection<SelfServiceRequestTbl> SelfServiceRequestTbl { get; set; }
        public virtual ICollection<TerminationTransactionTbl> TerminationTransactionTbl { get; set; }
        public virtual ICollection<VacationTransactionTbl> VacationTransactionTbl { get; set; }
    }
}
