using Entidades;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SaftComm.Database.DBContext
{
    class DatabaseContext : DbContext
    {
        private const string DB_CONTEXT = "DatabaseContext";

        public DatabaseContext() : base(DB_CONTEXT)
        {
        }

        public DbSet<Usuario> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
