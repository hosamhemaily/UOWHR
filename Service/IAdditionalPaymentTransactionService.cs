using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IAdditionalPaymentTransactionService
    {
        Task<List<AddionalPaymentHeModel>> GetData(int PageIndex, int PageSize, int PageCount);

        Task<AddionalPaymentHDModel> GetById(long id);

        Task<AddionalPaymentHDModel> Insert(AddionalPaymentHDModel absenceTransaction);

        Task<AddionalPaymentHDModel> Update(AddionalPaymentHDModel absenceTransaction);

        Task<bool> Delete(long id);
    }
}
