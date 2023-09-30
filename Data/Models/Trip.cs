namespace blazor_server_dashboard.Data.Models
{
    public class Trip
    {
        public int Id { get; set; }
        public string TripName { get; set; }
        
        public int NumberOfDays { get; set; }
        public List<User> Travelers { get; set; } = new List<User>();
    }
}
