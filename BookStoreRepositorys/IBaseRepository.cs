using BookStoreDb.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreRepositorys;

public interface IBaseRepository <T> where T :class, IEntity<int>
{
    Task AddAsync(T entity);
    Task DeleteAsync(int id);
    Task<T[]> GetAllAsync();
    Task<T?> GetByIdAsync(int id);
}
