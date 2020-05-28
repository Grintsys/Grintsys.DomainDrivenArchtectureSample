using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Grintsys.SROverview.Roles.Dto;
using Grintsys.SROverview.Users.Dto;

namespace Grintsys.SROverview.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<bool> ChangePassword(ChangePasswordDto input);
    }
}
