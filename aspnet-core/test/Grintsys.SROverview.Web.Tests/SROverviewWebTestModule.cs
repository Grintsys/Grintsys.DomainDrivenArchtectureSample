using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Grintsys.SROverview.EntityFrameworkCore;
using Grintsys.SROverview.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Grintsys.SROverview.Web.Tests
{
    [DependsOn(
        typeof(SROverviewWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class SROverviewWebTestModule : AbpModule
    {
        public SROverviewWebTestModule(SROverviewEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SROverviewWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(SROverviewWebMvcModule).Assembly);
        }
    }
}