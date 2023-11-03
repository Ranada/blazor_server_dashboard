namespace blazor_server_dashboard.Data.Models
{
    public class TaskModel
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public string? AssignedBy { get; set; }
        public string? AssignedTo { get; set; }
        public string? Priority { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public DateTime? DueDate { get; set; }
    }
}
