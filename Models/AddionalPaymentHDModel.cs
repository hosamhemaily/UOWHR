using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class AddionalPaymentHDModel:CommonPropModel
    {
        public AddionalPaymentHeModel addionalPaymentHeModel { get; set; }

        public List<AddionalPaymentDeModel> addionalPaymentDeModels { get; set; }
    }
}
