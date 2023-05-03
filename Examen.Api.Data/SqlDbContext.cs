using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Examen.Api.Data
{
    public class SqlDbContext : DbContext
    {
        private string? StgCnx { get; set; }
        public SqlDbContext()
        {
            StgCnx = "Server=PCENVY;Database=DBEntityCore;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=False";
        }
        public SqlDbContext(IConfiguration configuration)
        {
            StgCnx = configuration.GetConnectionString("StgCnx");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(StgCnx);

        }
    }
}