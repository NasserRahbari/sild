using org_view.Client.Models;

namespace org_view.Client.Services
{
    public interface IOrgService
    {
        Task<string> GetOrg(string orgId);
        Task<Org> GetOrgAsDto(string orgId);
        Task AddOrg(Org org);
    }
}