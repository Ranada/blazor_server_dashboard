using blazor_server_dashboard.Data;
using Microsoft.EntityFrameworkCore;

namespace blazor_server_dashboard.Services
{
    public class CustomerService
    {
        private IDbContextFactory<ApplicationDbContext> _dbContextFactory;

        public CustomerService(IDbContextFactory<ApplicationDbContext> dbContextFactory)
        { 
            _dbContextFactory = dbContextFactory;
        }
    }
}
