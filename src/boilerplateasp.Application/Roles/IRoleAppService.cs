using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using boilerplateasp.Roles.Dto;

namespace boilerplateasp.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedRoleResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();

        Task<GetRoleForEditOutput> GetRoleForEdit(EntityDto input);

        Task<ListResultDto<OffersListDto>> GetRolesAsync(GetRolesInput input);
    }
}
