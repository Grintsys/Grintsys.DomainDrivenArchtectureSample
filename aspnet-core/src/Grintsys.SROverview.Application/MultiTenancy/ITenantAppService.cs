using Abp.Application.Services;
using Grintsys.SROverview.MultiTenancy.Dto;

namespace Grintsys.SROverview.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

