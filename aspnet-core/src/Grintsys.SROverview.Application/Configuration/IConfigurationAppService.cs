using System.Threading.Tasks;
using Grintsys.SROverview.Configuration.Dto;

namespace Grintsys.SROverview.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
