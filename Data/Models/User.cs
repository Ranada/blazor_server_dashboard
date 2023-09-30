using System.ComponentModel.DataAnnotations;

namespace blazor_server_dashboard.Data.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
