using Abp.Authorization;
using boilerplateasp.Authorization.Roles;
using boilerplateasp.Authorization.Users;

namespace boilerplateasp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
