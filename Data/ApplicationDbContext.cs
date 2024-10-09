using KanbanServer.Models;
using KanbanServer.Models.KanbanModels;
using Microsoft.EntityFrameworkCore;

namespace KanbanServer.Data
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<KanbanBoard> KanbanBoards { get; set; }
        public DbSet<KanbanColumn> KanbanColumns { get; set; }
        public DbSet<KanbanTask> KanbanTasks { get; set; }
        public DbSet<Comment> Comments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<KanbanColumn>()
                .HasIndex(c => new { c.KanbanBoardId, c.FinalColumn })
                .IsUnique()
                .HasFilter("\"FinalColumn\" = true");

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { 
            

            
        }



    }
}
