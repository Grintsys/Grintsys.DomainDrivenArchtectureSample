using Abp.MultiTenancy;
using Grintsys.SROverview.Authorization.Users;

namespace Grintsys.SROverview.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
