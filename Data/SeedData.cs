using blazor_server_dashboard.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace blazor_server_dashboard.Data
{
    public static class SeedData
    {
        public static void AddTasks(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<TaskModel>().HasData(
               new TaskModel(1, "Sign security agreements", "Neil Ranada", "Katelyn Pham", "Low", DateTime.Now, null, new DateOnly(2023, 11, 16))
            );
            modelBuilder.Entity<TaskModel>().HasData(
               new TaskModel(2, "Review code", "Neil Ranada", "Neil Ranada", "Low", DateTime.Now, null, new DateOnly(2023, 11, 16))
            );
            modelBuilder.Entity<TaskModel>().HasData(
               new TaskModel(3, "Complete cybersecurity training", "Keisha Weiland", "Katelyn Pham", "Medium", DateTime.Now, new DateOnly(2023, 10, 01), new DateOnly(2023, 11, 16))
            );
            modelBuilder.Entity<TaskModel>().HasData(
               new TaskModel(4, "Audit security program", "Neil Ranada", "Billy Dietz", "Medium", DateTime.Now, new DateOnly(2023, 10, 02), new DateOnly(2023, 11, 20))
            );
            modelBuilder.Entity<TaskModel>().HasData(
               new TaskModel(5, "Fix security vulnerability", "Keisha Weiland", "Diane Basham", "High", DateTime.Now, new DateOnly(2023, 10, 03), new DateOnly(2023, 11, 20))
            );
            modelBuilder.Entity<TaskModel>().HasData(
               new TaskModel(6, "Review and approve security plan", "Neil Ranada", "Tammy Wescott", "Medium", DateTime.Now, null, new DateOnly(2023, 12, 05))
            );
            modelBuilder.Entity<TaskModel>().HasData(
               new TaskModel(7, "Find bugs", "Grace Hopper", "Neil Ranada", "Low", DateTime.Now, new DateOnly(2023, 10, 02), new DateOnly(2023, 12, 15))
            );

        }
    }
}
