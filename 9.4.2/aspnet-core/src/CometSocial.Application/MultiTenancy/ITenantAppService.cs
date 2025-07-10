using Abp.Application.Services;
using CometSocial.MultiTenancy.Dto;

namespace CometSocial.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

