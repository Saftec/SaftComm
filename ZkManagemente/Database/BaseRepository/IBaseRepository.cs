using Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Database.BaseRepository
{
    interface IBaseRepository<T> where T : BaseEntity
    {
        Task InsertOne(T entity);

        Task<IEnumerable<T>> GetAll();

        Task<T> GetOneById(int id);

        Task DeleteOneById(int id);

        Task UpdateOne(T entity);
    }
}
