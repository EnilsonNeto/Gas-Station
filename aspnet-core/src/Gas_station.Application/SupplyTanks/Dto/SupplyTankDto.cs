using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;

namespace Gas_station.SupplyTanks.Dto
{
    [AutoMap(typeof(SupplyTank))]
    public class SupplyTankDto: FullAuditedEntityDto<Guid>
    {
        public string LevelOfFuelEmpty { get; set; }

        public string LevelOfFuelFull { get; set; }

        public string TypeFuel { get; set; }
    }
}
