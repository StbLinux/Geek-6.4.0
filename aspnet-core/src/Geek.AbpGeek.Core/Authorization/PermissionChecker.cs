using Abp.Authorization;
using Geek.AbpGeek.Authorization.Roles;
using Geek.AbpGeek.Authorization.Users;

namespace Geek.AbpGeek.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
