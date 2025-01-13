using org_view.Client.Entities;

namespace org_view.Client.Repositories
{
    public interface IOrgRepository
    {
        //Task AddAsync(Org org);
        Task AddAsync(OrgEntities org);
        //Task AddASync(OrgRepository org);
    }
}