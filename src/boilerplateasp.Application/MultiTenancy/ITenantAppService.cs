using Abp.Application.Services;
using Abp.Application.Services.Dto;
using boilerplateasp.MultiTenancy.Dto;

namespace boilerplateasp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

