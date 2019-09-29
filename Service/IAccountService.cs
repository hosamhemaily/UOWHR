using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IAccountService
    {
        Task<AccountModel> Insert(AccountModel accountModel);

        Task<List<AccountModel>> GetData(int PageIndex,int PageSize, int PageCount);

        Task<AccountModel> GetById(long id);

        Task<bool> Delete(long id);

        Task<AccountModel> Update(AccountModel accountModel);
    }
}
