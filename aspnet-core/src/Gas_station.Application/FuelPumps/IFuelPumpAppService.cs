using Abp.Application.Services.Dto;
using Abp.Application.Services;
using System;
using System.Threading.Tasks;

namespace Gas_station.FuelPumps
{
    using Dto;

    public interface IFuelPumpAppService : IAsyncCrudAppService<FuelPumpDto, Guid, PagedResultRequestDto, CreateFuelPumpDto, FuelPumpDto>
    {
        Task<ListResultDto<FuelPumpDto>> GetListBySupplyTankId(Guid supplyTankId);

    }
}
