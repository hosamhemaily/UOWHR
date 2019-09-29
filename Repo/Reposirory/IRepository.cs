//using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace Repo
{
    public interface IRepository<T> where T : class
    {
        //HR_SystemContext Context { get; }

        IQueryable<T> Get(string includes="");
        //IQueryable<T> GetWithFilter(Expression<Func<T, bool>> predicate=null);
        IQueryable<T> GetWithPaging(int PageIndex, int PageSize, int PageCount, IQueryable<T> query);
        Task<T> GetById(long id);
        Task<T> Add(T entity);
        Task<bool> Delete(T entity);
        Task<T> Update(T entity);
    }
}
