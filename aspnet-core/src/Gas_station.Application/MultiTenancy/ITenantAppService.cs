using Abp.Application.Services;
using Gas_station.MultiTenancy.Dto;

namespace Gas_station.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

