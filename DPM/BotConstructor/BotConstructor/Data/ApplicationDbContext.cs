using Microsoft.EntityFrameworkCore;

namespace BotConstructor.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<FaqItem> FaqItems { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
