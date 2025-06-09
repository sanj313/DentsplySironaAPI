using DentsplySironaAPI.Models;
using DentsplySironaAPI.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DentsplySironaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditController : ControllerBase
    {
        private readonly IAuditService _auditService;

        public AuditController(IAuditService auditService)
        {
            _auditService = auditService;
        }

        [HttpPost]
        public IActionResult Audit([FromBody] AuditRequestDto request)
        {
            var result = _auditService.AuditChanges(request.Before, request.After, request.EntityName, request.UserId, request.Action);
            return Ok(result);
        }
    }
}
