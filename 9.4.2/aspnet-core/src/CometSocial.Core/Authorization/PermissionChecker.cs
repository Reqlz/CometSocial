using Abp.Authorization;
using CometSocial.Authorization.Roles;
using CometSocial.Authorization.Users;

namespace CometSocial.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
