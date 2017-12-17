using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entidades;
using System.Data.Entity;
using SaftComm.Database.Interfaces;
using SaftComm.Database.DBContext;

namespace SaftComm.Database.Repositories
{
    public class UserRepository : IUserRepository
    {
        private DatabaseContext dbContext;

        public async Task DeleteOneById(Usuario entity)
        {
            using(dbContext = new DatabaseContext())
            {
                dbContext.Entry(entity).State = EntityState.Deleted;
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Usuario>> GetAll()
        {
            using(dbContext = new DatabaseContext())
            {
                return await dbContext.Users.ToListAsync();
            }
        }

        public async Task<Usuario> GetOneById(int id)
        {
            using(dbContext = new DatabaseContext())
            {
                return await dbContext.Users.Where(x => x.Id == id).FirstOrDefaultAsync();
            }
        }

        public async Task InsertOne(Usuario entity)
        {
            using(dbContext = new DatabaseContext())
            {
                dbContext.Entry(entity).State = EntityState.Added;
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task UpdateOne(Usuario entity)
        {
            using(dbContext = new DatabaseContext())
            {
                dbContext.Entry(entity).State = EntityState.Modified;
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
