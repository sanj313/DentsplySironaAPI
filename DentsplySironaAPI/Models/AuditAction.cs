namespace DentsplySironaAPI.Models
{
    public enum AuditAction
    {
        //Created,
        Updated
        //Deleted
    }

    public class AuditEntry
    {
        public string EntityName { get; set; }
        public string UserId { get; set; }
        public AuditAction Action { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public Dictionary<string, (object? OldValue, object? NewValue)> ChangedFields { get; set; }
    }

    public class AuditRequestDto
    {
        public object Before { get; set; }
        public object After { get; set; }
        public string EntityName { get; set; }
        public string UserId { get; set; }
        public AuditAction Action { get; set; }
    }

    public class AuditResponseDto
    {
        public string EntityName { get; set; }
        public string UserId { get; set; }
        public AuditAction Action { get; set; }
        public DateTime Timestamp { get; set; }
        public Dictionary<string, (object? OldValue, object? NewValue)> ChangedFields { get; set; }
    }



}
