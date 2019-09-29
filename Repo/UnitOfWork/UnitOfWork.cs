using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;


namespace Repo
{
    public class UnitOfWork : IUnitOfWork
    {
        public HR_SystemContext Context;
        private Dictionary<Type, object> _repositories = new Dictionary<Type, object>();
        IDbContextTransaction _dbTransaction;

        public UnitOfWork(HR_SystemContext _context)
        {
            Context = _context;
        }

        public async Task<int> SaveChangesAsync()
        {
            try
            {
                var result = await Context.SaveChangesAsync();
                return result;
            }
            catch (Exception ex)
            {
                return 0;
            }
            
                
        }        

        public IRepository<T> GetRepository<T>()
        where T : class
        {
            if (this._repositories == null)
            {
                this._repositories = new Dictionary<Type, object>();
            }

            var type = typeof(T);
            if (!this._repositories.ContainsKey(type))
            {
                this._repositories[type] = new Repository<T>(Context);
            }

            return (IRepository<T>)this._repositories[type];
        }

        public async Task BeginTransaction()
        {
            _dbTransaction = await Context.Database.BeginTransactionAsync();
        }

        public void CommitTransaction()
        {
            _dbTransaction.Commit();
        }

        public void RollBackTransaction()
        {
            _dbTransaction.Rollback();
        }
        
    }
}
