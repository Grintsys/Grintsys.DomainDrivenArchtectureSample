using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Grintsys.SROverview.Configuration;

namespace Grintsys.SROverview.Web.Host.Startup
{
    [DependsOn(
       typeof(SROverviewWebCoreModule))]
    public class SROverviewWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SROverviewWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SROverviewWebHostModule).GetAssembly());
        }
    }
}
