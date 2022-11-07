using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using boilerplateasp.Roles.Dto;
using boilerplateasp.Users.Dto;

namespace boilerplateasp.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
