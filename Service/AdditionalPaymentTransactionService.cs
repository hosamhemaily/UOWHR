using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL.Models;
using Models;
using Repo;
using System.Linq;

using Repo.Extensions;

namespace Service
{
    public class AdditionalPaymentTransactionService : BaseService<AddionalPaymentHDModel, 
        AdditionalPaymentTransactionTbl>, IAdditionalPaymentTransactionService
    {

        public AdditionalPaymentTransactionService(IUnitOfWork _unitOfWork, IMapper _mapper) :
            base(_unitOfWork, _mapper)
        {

        }
        public async Task<bool> Delete(long id)
        {
            return await base.Delete(id);
        }

        public async Task<AddionalPaymentHDModel> GetById(long id)
        {
            var query = _unitOfWork.GetRepository<AdditionalPaymentTransactionTbl>()
                .Get("AdditionalPaymentTransactionDetailsTbl,AdditionalPaymentTransactionDetailsTbl.Employee");
            //string str = query.ToSql();
            //var additionalPayment = query.Where(x => x.AdditionalPaymentTransactionId.Equals(id)).
            //    FirstOrDefault().AdditionalPaymentTransactionDetailsTbl;
            var result= query.Where(x => x.AdditionalPaymentTransactionId.Equals(id)).Select(q=>new
            AddionalPaymentHDModel
            {
                addionalPaymentHeModel = _mapper.Map<AddionalPaymentHeModel >(q),
                addionalPaymentDeModels = _mapper.Map<List<AddionalPaymentDeModel>>(q.AdditionalPaymentTransactionDetailsTbl
                ) 
            }
            );            

            return result.SingleOrDefault();
        }

        public Task<List<AddionalPaymentHeModel>> GetData(int PageIndex, int PageSize, int PageCount)
        {
            throw new NotImplementedException();
        }

        public override async Task<AddionalPaymentHDModel> Insert(AddionalPaymentHDModel additionalTransaction)
        {
            var headerTable = _mapper.Map<AdditionalPaymentTransactionTbl>(additionalTransaction.addionalPaymentHeModel);
            var listDetails = _mapper.Map <List< AdditionalPaymentTransactionDetailsTbl >>
                (additionalTransaction.addionalPaymentDeModels);

            //var r = _unitOfWork.GetRepository<AdditionalPaymentTransactionTbl>().Get().FirstOrDefault();
            headerTable.AdditionalPaymentTransactionDetailsTbl = listDetails;
            headerTable.InsertUserId = additionalTransaction.InsertUserId;
            headerTable.InsertDate = DateTime.Now;
            var resultUpdate = await _unitOfWork.GetRepository<AdditionalPaymentTransactionTbl>().Add(headerTable);
            var addionalPaymentHeModel = _mapper.Map<AddionalPaymentHeModel>(resultUpdate);
            await _unitOfWork.SaveChangesAsync();
            return new AddionalPaymentHDModel { addionalPaymentHeModel = addionalPaymentHeModel };
            //return await base.Insert(additionalTransaction);
        }

        public async Task<AddionalPaymentHDModel> Update(AddionalPaymentHDModel absenceTransaction)
        {
            //var headerTable = _unitOfWork.GetRepository<AdditionalPaymentTransactionTbl>();
            var headerTable = _mapper.Map<AdditionalPaymentTransactionTbl>(absenceTransaction.addionalPaymentHeModel);
            headerTable.UpdateUserId = absenceTransaction.UpdateUserId;
            headerTable.UpdateDate = DateTime.Now;
            var resultUpdate = await _unitOfWork.GetRepository<AdditionalPaymentTransactionTbl>().Update(headerTable);
            
            var listDetails = _mapper.Map<List<AdditionalPaymentTransactionDetailsTbl>>
                (absenceTransaction.addionalPaymentDeModels);
            
            foreach (var item in listDetails)
            {
                item.AdditionalPaymentTransactionId = headerTable.AdditionalPaymentTransactionId;
                IQueryable<AdditionalPaymentTransactionDetailsTbl> query1 = _unitOfWork
                .GetRepository<AdditionalPaymentTransactionDetailsTbl>().Get().Where(x=>x.
                AdditionalPaymentTransactionDetailsId .Equals(item.AdditionalPaymentTransactionDetailsId));

                //var entity = _unitOfWork.GetRepository<AdditionalPaymentTransactionDetailsTbl>()
                //    .GetWithPaging(0,0,0, query1 ).Count();

                //insert 
                if (query1.Count() == 0 )
                {
                    await _unitOfWork.GetRepository<AdditionalPaymentTransactionDetailsTbl>()
                        .Add(item);
                }
                else
                {
                    await _unitOfWork.GetRepository<AdditionalPaymentTransactionDetailsTbl>()
                        .Update(item);
                }
            }

            //IQueryable<AdditionalPaymentTransactionDetailsTbl> query = _unitOfWork
            //    .GetRepository<AdditionalPaymentTransactionDetailsTbl>().Get().Where(x => x.AdditionalPaymentTransactionId.
            //    Equals(absenceTransaction.addionalPaymentHeModel.AdditionalPaymentTransactionId));


            var allAdditonalPaymentsInDB = _unitOfWork.GetRepository<AdditionalPaymentTransactionDetailsTbl>()
                .Get().Where(x=>x.AdditionalPaymentTransactionId.
                Equals(absenceTransaction.addionalPaymentHeModel.AdditionalPaymentTransactionId));

            var listIds = absenceTransaction.addionalPaymentDeModels.Select(x => x.AdditionalPaymentTransactionDetailsId).
                ToList();

            var deleted = allAdditonalPaymentsInDB.ToList().
                Where(x => !listIds.Contains(x.AdditionalPaymentTransactionDetailsId));
            foreach (var itemDelet in deleted)
            {
                await _unitOfWork.GetRepository<AdditionalPaymentTransactionDetailsTbl>().Delete(itemDelet);

            }
            await _unitOfWork.SaveChangesAsync();
            return new AddionalPaymentHDModel { };
        }
    }
}
