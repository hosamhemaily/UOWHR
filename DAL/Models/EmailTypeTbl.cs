using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class EmailTypeTbl
    {
        public EmailTypeTbl()
        {
            EmployeeEmailTbl = new HashSet<EmployeeEmailTbl>();
        }

        public byte EmailTypeId { get; set; }
        public string EmailTypeEnName { get; set; }
        public string EmailTypeArName { get; set; }

        public virtual ICollection<EmployeeEmailTbl> EmployeeEmailTbl { get; set; }
    }
}
