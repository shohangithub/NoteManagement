namespace Domain.Entities;

public class Note : AuditableEntity<int>
{
    public required string Text { get; set; }
    public ENoteType Type { get; set; } // Regular, Reminder, Todo, Bookmark
    public DateTime? ReminderDate { get; set; }
    public DateTime? DueDate { get; set; }
    public bool? IsComplete { get; set; }
    public string? BookmarkUrl { get; set; }
}
