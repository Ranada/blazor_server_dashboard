namespace blazor_server_dashboard.Data.Models
{
    public record TaskModel(
        int Id, 
        string? Description, 
        string? AssignedBy, 
        string? AssignedTo, 
        string? Priority, 
        DateTime? StartDate, 
        DateOnly? CompletionDate, 
        DateOnly? DueDate
        );
}
