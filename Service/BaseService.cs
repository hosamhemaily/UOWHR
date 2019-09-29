using AutoMapper;
using Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public abstract class BaseService<TMODEL,TENTITY> where TENTITY:class
    {
        public readonly IUnitOfWork _unitOfWork;
        public readonly IMapper _mapper;

        public BaseService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public virtual async Task<TMODEL> Insert(TMODEL tMODEL)
        {
            TENTITY tble = _mapper.Map<TENTITY>(tMODEL);
            var resultEntity = await _unitOfWork.GetRepository<TENTITY>().
                Add(tble);
            var resultofsave = await _unitOfWork.SaveChangesAsync();
            tMODEL= _mapper.Map<TMODEL>(resultEntity);
            return tMODEL;  
        }
        
        public virtual async Task<TMODEL> GetById(long id)
        {
             var resultEntity = await _unitOfWork.GetRepository<TENTITY>().GetById(id);
             var tMODEL = _mapper.Map<TMODEL>(resultEntity);
             return tMODEL;
        }

        public virtual async Task<TMODEL> Update(TMODEL tMODEL)
        {
            var TransactionEntity = _mapper.Map<TENTITY>(tMODEL);
            var resultofupdate = await _unitOfWork.GetRepository<TENTITY>().
                Update(TransactionEntity);
            await _unitOfWork.SaveChangesAsync();
            var TransactionModel = _mapper.Map<TMODEL>(resultofupdate);
            return TransactionModel;
        }

        protected virtual async Task<IQueryable<TENTITY>> GetWithPaging(int PageIndex,
            int PageSize, int PageCount, IQueryable<TENTITY> query=null
            ,string includes="")
        {
            if (query == null)
            {
                var theQuery = _unitOfWork.GetRepository<TENTITY>().Get(includes);                
                return theQuery;
            }
            if (PageSize == 0)
            {
                return query;
            }
            else
            {
                //var result = Context.Set<T>().Where(predicate).AsQueryable();
                int countForSkip = (PageIndex) * PageSize;
                var r2 = query.Skip(countForSkip).Take(PageSize);
                return r2;
            }

        }

        public virtual async Task<bool> Delete(long id)
        {
            var entityRepo =  _unitOfWork.GetRepository<TENTITY>();
            var entity = entityRepo.GetById(id);
            await entityRepo.Delete(entity.Result);
            var resultSave = await _unitOfWork.SaveChangesAsync() ;
            return (resultSave > 0 ? true : false);
            
        }
    }
}
