using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class BankFileConfigurationSerialTbl
    {
        public int BankFileSerialId { get; set; }
        public int? BankFileConfigurationId { get; set; }
        public int? TheYear { get; set; }
        public int? TheMonth { get; set; }
        public long? SerialEndThisMonth { get; set; }
        public long? SerialStartThisMonth { get; set; }
        public int? PayrollType { get; set; }
        public long? CurrencyId { get; set; }
    }
}
