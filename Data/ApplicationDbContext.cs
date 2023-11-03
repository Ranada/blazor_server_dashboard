using blazor_server_dashboard.Data;
using blazor_server_dashboard.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace blazor_server_dashboard.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<TaskModel> Tasks { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            SeedData.AddTasks(modelBuilder);
        }
    }
}
