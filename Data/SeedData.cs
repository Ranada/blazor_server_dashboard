using blazor_server_dashboard.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.ObjectPool;

namespace blazor_server_dashboard.Data
{
    public static class SeedData
    {
        public static string[] descriptions = { "Sign security agreements", "Review code", "Complete cybersecurity training", "Audit security program", "Fix security vulnerability", "Review and approve security plan" };
        public static string[] names = { "Neil Ranada", "Katelyn Pham", "Keisha Weiland", "Billy Dietz", "Diane Basham", "Tammy Wescott" };
        public static string[] priorities = { "low", "medium", "high" };

        public static void AddTasks(ModelBuilder modelBuilder)
        {
            var random = new Random();

            for (int i = 0; i < 10; i++)
            {
                var newTask = new TaskModel();
                
                newTask.Id = Guid.NewGuid();
                newTask.Description = descriptions[random.Next(0, descriptions.Length) % descriptions.Length];
                newTask.AssignedBy = names[random.Next(0, names.Length) % names.Length];
                newTask.AssignedTo = names[random.Next(0, names.Length) % names.Length];
                newTask.Priority = priorities[random.Next(0, priorities.Length) % priorities.Length];

                var startDate = DateTime.Now;
                newTask.StartDate = startDate;

                int randomDays = random.Next(1, 31);     // Random days between 1 and 30
                int randomMonths = random.Next(1, 13);   // Random months between 1 and 12
                int randomYears = random.Next(0, 2);

                newTask.DueDate = startDate
                    .AddDays(randomDays)
                    .AddMonths(randomMonths)
                    .AddYears(randomYears);

                Console.WriteLine($"{newTask.Description}" +
                    $" {newTask.AssignedTo}" +
                    $" {newTask.AssignedTo}" +
                    $" {newTask.Priority}" +
                    $" {newTask.StartDate}" +
                    $" {newTask.CompletionDate}" +
                    $" {newTask.DueDate}");

                modelBuilder.Entity<TaskModel>().HasData(newTask);
            }
        }
    }
}
