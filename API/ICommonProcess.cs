using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API
{
    public interface ICommonProcess<T> 
    {
        Task SetCommonProperty(T model,string UserValue,string propertyName);
    }
}
