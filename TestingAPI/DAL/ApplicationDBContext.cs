using TestingAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TestingAPI.DAL
{
    public class ApplicationDBContext: DbContext
    {
        public DbSet<Users> User { get; set; }
        public DbSet<Questions> Questions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=testing.db");
        }

        public ApplicationDBContext() : base()
        {

        }

        public ApplicationDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<TestingAPI.Model.Responses> Responses { get; set; }
    }
}
