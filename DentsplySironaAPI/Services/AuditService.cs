using DentsplySironaAPI.Models;
using DentsplySironaAPI.Services.IServices;


namespace DentsplySironaAPI.Services
{
    public class AuditService : IAuditService
    {
        public AuditEntry AuditChanges(object before, object after, string entityName, string userId, AuditAction action)
        {
            var changedFields = ObjectComparer.GetChangedFields(before, after);

            return new AuditEntry
            {
                EntityName = entityName,
                UserId = userId,
                Action = action,
                ChangedFields = changedFields
            };
        }
    }
}
