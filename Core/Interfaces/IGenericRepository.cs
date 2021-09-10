using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T: BaseEntity
    
    {   Task<T> GetByIdAsync(int id);  //task that return type ofT that matches what we are passing yp
         Task<IReadOnlyList<T>> ListAllAsync(); // name is ListallASync
        
    }
}