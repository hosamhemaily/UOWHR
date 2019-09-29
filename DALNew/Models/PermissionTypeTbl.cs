using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class PermissionTypeTbl
    {
        public PermissionTypeTbl()
        {
            PermissionTransactionTbl = new HashSet<PermissionTransactionTbl>();
        }

        public byte PermissionTypeId { get; set; }
        public string PermissionTypeEnName { get; set; }
        public string PermissionTypeArName { get; set; }

        public virtual ICollection<PermissionTransactionTbl> PermissionTransactionTbl { get; set; }
    }
}
