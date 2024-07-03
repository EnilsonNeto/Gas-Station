using Abp.Authorization;
using System;
using Abp.Application.Services.Dto;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using AutoMapper;

namespace Gas_station.SupplyTanks
{
    using Dto;

    [AbpAuthorize]
    public class SupplyTankAppService : AsyncCrudAppService<SupplyTank, SupplyTankDto, Guid, PagedResultRequestDto, CreateSupplyTankDto, SupplyTankDto>, ISupplyTankAppService
    {
        private readonly IMapper _mapper;
        private IRepository<SupplyTank, Guid> _supplyTankRepository;

        public SupplyTankAppService(IRepository<SupplyTank, Guid> supplyTankRepository,
                                    IMapper mapper) : base(supplyTankRepository)
        {
            _supplyTankRepository = supplyTankRepository;
            _mapper = mapper;
        }
    }
}
