using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DAL.Interfaces
{
    public interface IBaseRepository<T>
    {
        bool CreateEntity(T entity);
        
        T GetEntity(T entity);

        Task<List<T>> GetAllEntities();

        bool DeletedEntity(T entity);
    }
}
