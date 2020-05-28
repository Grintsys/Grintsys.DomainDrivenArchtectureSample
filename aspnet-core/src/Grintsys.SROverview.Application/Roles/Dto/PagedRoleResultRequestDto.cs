using Abp.Application.Services.Dto;

namespace Grintsys.SROverview.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

