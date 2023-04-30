using Microsoft.EntityFrameworkCore;

namespace DatingAPI.Data
{
    public class DatingAppDataContext : DbContext
    {     
        public DatingAppDataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> AppUsers {get; set;}
    }
}