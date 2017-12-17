using Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Database.BaseRepository
{
    internal interface IBaseRepository<T> where T : BaseEntity
    {
        Task InsertOne(T entity);

        Task<IEnumerable<T>> GetAll();

        Task<T> GetOneById(int id);

        Task DeleteOneById(T entity);

        Task UpdateOne(T entity);
    }
}
