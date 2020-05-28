using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Grintsys.SROverview.Configuration.Dto;

namespace Grintsys.SROverview.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SROverviewAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
