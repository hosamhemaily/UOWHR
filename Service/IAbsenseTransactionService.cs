using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IAbsenseTransactionService
    {
        

        Task<List<AbsenceTransactionModel>> GetData(int PageIndex,int PageSize, int PageCount);

        Task<AbsenceTransactionModel> GetById(long id);

        Task<AbsenceTransactionModel> Insert(AbsenceTransactionModel absenceTransaction);

        Task<AbsenceTransactionModel> Update(AbsenceTransactionModel absenceTransaction);

        Task<bool> Delete(long id);

        
    }
}
