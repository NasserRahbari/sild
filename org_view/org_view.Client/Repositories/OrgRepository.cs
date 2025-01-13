using org_view.Client.Context;
using Microsoft.EntityFrameworkCore;
using org_view.Client.Models;
using org_view.Client.Entities;

namespace org_view.Client.Repositories
{
    public class OrgRepository : IOrgRepository
    {
        private readonly OrgContext orgContext;
        //private readonly OrgRepository entities;
        public OrgRepository(IDbContextFactory<OrgContext> factory)
        {
            orgContext = factory.CreateDbContext();   
        }


        public async Task AddAsync(OrgEntities org)
        {
            orgContext.Orgs.Add(org);
            await orgContext.SaveChangesAsync();
        }
    }
}