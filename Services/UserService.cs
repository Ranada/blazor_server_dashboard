using blazor_server_dashboard.Data;
using blazor_server_dashboard.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace blazor_server_dashboard.Services
{
    public class UserService
    {
        private IDbContextFactory<ApplicationDbContext> _dbContextFactory;

        public UserService(IDbContextFactory<ApplicationDbContext> dbContextFactory)
        { 
            _dbContextFactory = dbContextFactory;
        }

        public void AddUser(User user)
        { 
            using(var context = _dbContextFactory.CreateDbContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }
    }
}
