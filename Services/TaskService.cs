using blazor_server_dashboard.Data;
using blazor_server_dashboard.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace blazor_server_dashboard.Services
{
    public class TaskService
    {
        private readonly ApplicationDbContext _appDbContext;
        private readonly ILogger<TaskService> _logger;

        public TaskService(ApplicationDbContext applicationDbContext, ILogger<TaskService> logger)
        {
            _appDbContext = applicationDbContext ?? throw new ArgumentNullException(nameof(applicationDbContext));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<List<TaskModel>> GetAllTasksAsync()
        {
            try
            {
                var taskList = await _appDbContext.Tasks.ToListAsync();
                _logger.LogInformation("Retrieved tasks from the database.");
                return taskList;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while retrieving tasks from the database.");
                throw; // Rethrow the exception for proper error handling at the higher level.
            }
        }
    }
}
