using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Grintsys.SROverview.Authorization;

namespace Grintsys.SROverview
{
    [DependsOn(
        typeof(SROverviewCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SROverviewApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SROverviewAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SROverviewApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
