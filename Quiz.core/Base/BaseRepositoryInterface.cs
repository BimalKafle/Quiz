using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.core.Base
{
    public interface BaseRepositoryInterface<T> where T : class
    {
        Task<T?> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        IQueryable<T> GetQueryable();
        Task AddAsync(T entity);
        
        Task Update(T entity);
        Task Remove(T entity);
      
    }
}
