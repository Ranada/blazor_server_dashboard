using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace blazor_server_dashboard.Data.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Trip> Trips { get; set; } = new List<Trip>();  
    }
}
