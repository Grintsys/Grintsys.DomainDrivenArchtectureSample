using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Grintsys.SROverview.Authorization.Roles;
using Grintsys.SROverview.Authorization.Users;
using Grintsys.SROverview.MultiTenancy;

namespace Grintsys.SROverview.EntityFrameworkCore
{
    public class SROverviewDbContext : AbpZeroDbContext<Tenant, Role, User, SROverviewDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public SROverviewDbContext(DbContextOptions<SROverviewDbContext> options)
            : base(options)
        {
        }
    }
}
