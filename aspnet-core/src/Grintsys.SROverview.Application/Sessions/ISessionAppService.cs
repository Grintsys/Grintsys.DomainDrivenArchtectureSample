using System.Threading.Tasks;
using Abp.Application.Services;
using Grintsys.SROverview.Sessions.Dto;

namespace Grintsys.SROverview.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
