using System.Threading.Tasks;
using Abp.Application.Services;
using Grintsys.SROverview.Authorization.Accounts.Dto;

namespace Grintsys.SROverview.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
