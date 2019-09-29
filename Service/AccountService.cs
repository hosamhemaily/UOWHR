using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL.Models;
using Models;
using Repo;

namespace Service
{
    public class AccountService : BaseService<AccountModel, AccountNumberTbl>,
        IAccountService
    {

        public AccountService(IUnitOfWork _unitOfWork, IMapper _mapper) :
            base(_unitOfWork, _mapper)
        {

        }

        public override async Task<bool> Delete(long id)
        {
            return await base.Delete(id);
        }

        public override async Task<AccountModel> GetById(long id)
        {
            return await base.GetById(id);
        }

        public async Task<List<AccountModel>> GetData(int PageIndex, int PageSize, int PageCount)
        {
            IQueryable<AccountNumberTbl> query = _unitOfWork
                .GetRepository<AccountNumberTbl>().Get();

            query = query.Where(x => x.PropertyId == 2);
            
            var absenceListEntity = await base.GetWithPaging(PageIndex, PageSize, PageCount, query);
            var absenceListModel = _mapper.Map<List<AccountModel>>(absenceListEntity.ToList());
            return absenceListModel;
        }

        public override async Task<AccountModel> Insert(AccountModel accountModel)
        {
            return await base.Insert(accountModel);
        }

        public override async Task<AccountModel> Update(AccountModel accountModel)
        {
            return await base.Update(accountModel);
        }
    }
}
