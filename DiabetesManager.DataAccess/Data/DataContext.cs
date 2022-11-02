using DiabetesManager.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DiabetesManager.DataAccess
{
    public class DataContext : IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<logEntry> logEntries { get; set; }

        public DbSet<userSetting> userSettings { get; set; }
    }
}
