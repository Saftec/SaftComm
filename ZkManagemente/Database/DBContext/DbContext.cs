using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Database.DBContext
{
    class DatabaseContext : DbContext
    {
        private const string DB_CONTEXT = "DatabaseContext";

        public DatabaseContext() : base(DB_CONTEXT)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
