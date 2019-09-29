using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class TransactionTypeTbl
    {
        public int TransactionTypeId { get; set; }
        public string TransactionTypeEnName { get; set; }
        public string TransactionTypeArName { get; set; }
        public long? AppSettingId { get; set; }
    }
}
