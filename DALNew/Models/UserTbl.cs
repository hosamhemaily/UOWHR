using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class UserTbl
    {
        public UserTbl()
        {
            UserFavoriteReportTbl = new HashSet<UserFavoriteReportTbl>();
            UserGeneratedReportSecurityTbl = new HashSet<UserGeneratedReportSecurityTbl>();
            UserModuleTbl = new HashSet<UserModuleTbl>();
            UserReportSecurityTbl = new HashSet<UserReportSecurityTbl>();
        }

        public long UserId { get; set; }
        public string UserName { get; set; }
        public string UserArName { get; set; }
        public string UserLoginName { get; set; }
        public string UserPassword { get; set; }
        public bool? ActiveUserYn { get; set; }
        public long? RelatedEmployeeId { get; set; }
        public byte? UserSecurityLevel { get; set; }
        public bool? DeletedYn { get; set; }
        public DateTime? LastLogin { get; set; }
        public DateTime? LastPasswordChanged { get; set; }
        public bool? UserType { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<UserFavoriteReportTbl> UserFavoriteReportTbl { get; set; }
        public virtual ICollection<UserGeneratedReportSecurityTbl> UserGeneratedReportSecurityTbl { get; set; }
        public virtual ICollection<UserModuleTbl> UserModuleTbl { get; set; }
        public virtual ICollection<UserReportSecurityTbl> UserReportSecurityTbl { get; set; }
    }
}
