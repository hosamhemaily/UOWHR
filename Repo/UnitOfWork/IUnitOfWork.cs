using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Repo
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();
        IRepository<T> GetRepository<T>() where T : class;
        Task BeginTransaction();
        void CommitTransaction();
        void RollBackTransaction();

    }
}
