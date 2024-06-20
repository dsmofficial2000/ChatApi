using ChatApi.Model.Domain;
using Microsoft.EntityFrameworkCore;

namespace ChatApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions  dbContextOptions) : base(dbContextOptions)
        {
            
        }
        public DbSet<ChatMessage> chatMessages { get; set; }
    }
}
