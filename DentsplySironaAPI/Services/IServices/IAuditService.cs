using DentsplySironaAPI.Models;

namespace DentsplySironaAPI.Services.IServices
{
    public interface IAuditService
    {
        AuditEntry AuditChanges(object before, object after, string entityName, string userId, AuditAction action);
    }
}
