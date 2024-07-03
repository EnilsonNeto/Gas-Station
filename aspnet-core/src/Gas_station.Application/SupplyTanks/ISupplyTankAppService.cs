using Abp.Application.Services.Dto;
using Abp.Application.Services;
using System;
using Gas_station.SupplyTanks.Dto;

namespace Gas_station.SupplyTanks
{
    public interface ISupplyTankAppService : IAsyncCrudAppService<SupplyTankDto, Guid, PagedResultRequestDto, CreateSupplyTankDto, SupplyTankDto>
    {
    }
}
