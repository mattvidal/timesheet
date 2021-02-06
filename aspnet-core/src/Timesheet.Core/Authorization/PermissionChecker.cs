using Abp.Authorization;
using Timesheet.Authorization.Roles;
using Timesheet.Authorization.Users;

namespace Timesheet.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
