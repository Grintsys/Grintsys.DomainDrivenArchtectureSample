using Abp.Authorization;
using Grintsys.SROverview.Authorization.Roles;
using Grintsys.SROverview.Authorization.Users;

namespace Grintsys.SROverview.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
