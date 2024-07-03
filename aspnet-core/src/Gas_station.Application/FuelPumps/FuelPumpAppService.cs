using Abp.Application.Services.Dto;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using AutoMapper;
using System;
using Abp.Authorization;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gas_station.FuelPumps
{
    using Dto;

    public class FuelPumpAppService : AsyncCrudAppService<FuelPump, FuelPumpDto, Guid, PagedResultRequestDto, CreateFuelPumpDto, FuelPumpDto>, IFuelPumpAppService
    {
        private readonly IMapper _mapper;
        private IRepository<FuelPump, Guid> _fuelPumpRepository;

        public FuelPumpAppService(IRepository<FuelPump, Guid> fuelPumpRepository,
                                    IMapper mapper) : base(fuelPumpRepository)
        {
            _fuelPumpRepository = fuelPumpRepository;
            _mapper = mapper;
        }

        [AbpAuthorize]
        public async Task<ListResultDto<FuelPumpDto>> GetListBySupplyTankId(Guid supplyTankId)
        {
            var result = await _fuelPumpRepository.GetAllListAsync(prop => prop.SupplyTankId.Equals(supplyTankId));

            return new ListResultDto<FuelPumpDto>(_mapper.Map<List<FuelPumpDto>>(result));
        }
    }
}
