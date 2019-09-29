using AutoMapper;
using DAL.Models;
using Models;
using Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Service
{
    public class AbsenceTransactionService : BaseService<AbsenceTransactionModel,AbsenceTransactionTbl>,
        IAbsenseTransactionService
    {
        public AbsenceTransactionService(IUnitOfWork _unitOfWork,IMapper _mapper) : 
            base(_unitOfWork,_mapper)
        {

        }
       
        public override Task<AbsenceTransactionModel> Insert(AbsenceTransactionModel tMODEL)
        {
            return base.Insert(tMODEL);
        }

        /// <summary>
        /// here we can use function from base service and select data as i need because i am using querable
        /// </summary>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <param name="PageCount"></param>
        /// <param name="query"></param>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public async Task<List<AbsenceTransactionModel>> GetData(int PageIndex, 
            int PageSize, int PageCount )
        {
            IQueryable<AbsenceTransactionTbl> query = _unitOfWork
                .GetRepository<AbsenceTransactionTbl>().Get("Employee,SysRequestStatus");

            query = query.Where(x => x.AttendanceTypeId == "A");
            query = query.Where(x => x.EmployeeId == 8);
            var absenceListEntity = await base.GetWithPaging(PageIndex, PageSize, PageCount, query);           
            var absenceListModel= _mapper.Map<List<AbsenceTransactionModel>>(absenceListEntity.ToList());
            return absenceListModel;
        }

        public override async Task<bool> Delete(long id)
        {
            var entity = _unitOfWork.GetRepository<AbsenceTransactionTbl>().Get().Where(x => x.AbsenceTransactionId 
            .Equals(id)
            ).SingleOrDefault();

            var resultOfDelete= await _unitOfWork.GetRepository<AbsenceTransactionTbl>().Delete(entity);
            return  (await _unitOfWork.SaveChangesAsync() > 0 ? true : false);
        }

        public override async Task<AbsenceTransactionModel> Update(AbsenceTransactionModel absenceTransaction)
        {
            return await base.Update(absenceTransaction);
        }

        public override async Task<AbsenceTransactionModel> GetById(long id)
        {

            var entity = _unitOfWork.GetRepository<AbsenceTransactionTbl>().Get("Employee,SysRequestStatus").
                Where(x => x.AbsenceTransactionId.Equals(id)).FirstOrDefault();
            var absenceModel = _mapper.Map<AbsenceTransactionModel>(entity);
            return absenceModel;
        }
    }
}
