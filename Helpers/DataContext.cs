namespace SearchAndRescue.Helpers
{
    using Microsoft.EntityFrameworkCore;
    using SearchAndRescue.User.Dtos.Base;

    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        //private readonly IDbContext _dbContext;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // in memory database used for simplicity, change to a real db for production applications
            options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
        }
    }
}
