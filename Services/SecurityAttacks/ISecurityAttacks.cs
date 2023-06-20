using Microsoft.AspNetCore.Http;

namespace Services.SecurityAttacks
{
    public interface ISecurityAttacks
    {
        Task InjectionAttack(string id);
        Task PreventInjectionAttack(Guid id);
        Task FileAttack(IFormFile file);
        Task PreventFileAttack(IFormFile file);
    }
}