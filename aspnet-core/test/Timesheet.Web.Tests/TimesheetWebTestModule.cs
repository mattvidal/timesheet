using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Timesheet.EntityFrameworkCore;
using Timesheet.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Timesheet.Web.Tests
{
    [DependsOn(
        typeof(TimesheetWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class TimesheetWebTestModule : AbpModule
    {
        public TimesheetWebTestModule(TimesheetEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TimesheetWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(TimesheetWebMvcModule).Assembly);
        }
    }
}