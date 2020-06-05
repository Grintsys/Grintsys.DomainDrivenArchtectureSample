using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Grintsys.SROverview.Clients.Dto;
using System.Threading.Tasks;

namespace Grintsys.SROverview.Clients
{
    public interface IClientAppService: IAsyncCrudAppService<ClientDto, int, GetAllClientInput>
    {
        Task<ClientDto> GetClient(GetClientInput input);
        Task<PagedResultDto<GetAllClientInput>> GetAllBySearchCriteria(ClientSearchInput input);
    }
}
