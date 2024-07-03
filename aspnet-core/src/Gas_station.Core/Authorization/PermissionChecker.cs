using Abp.Authorization;
using Gas_station.Authorization.Roles;
using Gas_station.Authorization.Users;

namespace Gas_station.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
