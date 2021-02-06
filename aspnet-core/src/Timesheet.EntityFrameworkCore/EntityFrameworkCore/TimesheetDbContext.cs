using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Timesheet.Authorization.Roles;
using Timesheet.Authorization.Users;
using Timesheet.MultiTenancy;

namespace Timesheet.EntityFrameworkCore
{
    public class TimesheetDbContext : AbpZeroDbContext<Tenant, Role, User, TimesheetDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public TimesheetDbContext(DbContextOptions<TimesheetDbContext> options)
            : base(options)
        {
        }
    }
}
