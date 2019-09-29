using DAL.Models;

using Microsoft.EntityFrameworkCore;
using Repo.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace Repo
{
    public class Repository<T> : IRepository<T> where T : class
    {

        public HR_SystemContext Context { get; set; }

        //GoldhayAdminContext IRepository<T>.Context => throw new NotImplementedException();

        protected DbSet<T> DbSet;
        public Repository(HR_SystemContext context)
        {
            Context = context;
            DbSet = Context.Set<T>();
        }
        public async Task<T> Add(T entity)
        {
            var result = await Context.AddAsync(entity);
            return entity;
        }

        public async Task<bool> Delete(T entity)
        {            
            Context.Remove(entity);
            return true;
        }
        public IQueryable<T> Get(string includes="")
        {
            IQueryable<T> query = Context.Set<T>();
            if (includes == "")
            {
                return query.AsNoTracking();
            }
            else
            {
                string[] splitIcludes = includes.Split(",");

                foreach (var item in splitIcludes)
                    query = query.Include(item);
                string str = query.ToSql();
                return query.AsNoTracking();
            }                   
        }
        //public IQueryable<T> GetWithFilter(Expression<Func<T, bool>> predicate=null)
        //{            
        //    return  Context.Set<T>().Where(predicate).AsQueryable(); 
        //}

        public IQueryable<T> GetWithPaging(int PageIndex, int PageSize, int PageCount,IQueryable<T> query)
        {
            if (PageSize == 0)
            {
                return query.AsNoTracking();
            }
            else
            {
                //var result = Context.Set<T>().Where(predicate).AsQueryable();
                int countForSkip = (PageIndex) * PageSize;
                var r2 = query.Skip(countForSkip).Take(PageSize).AsNoTracking();
                return r2;
            }

        }

        public async Task<T> GetById(long id)
        {
            var result = await Context.Set<T>().FindAsync(id);
            return result;
        }

        public async Task<T> Update(T entity)
        {
            Context.Set<T>().Attach(entity);
            Context.Entry(entity).State = EntityState.Modified;
            
            return entity;
            
        }

       
        
    }
}
