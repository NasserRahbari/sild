using org_view.Client.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Security.Principal;
//using BlazoWebrApp_test_withsubmit.Client.Models;

namespace org_view.Client.Context

{
    public class OrgContext : DbContext
    {
        public OrgContext(DbContextOptions<OrgContext> options) : base(options)
        {

        }
        public DbSet<OrgEntities> Orgs { get; set; }
    }
}