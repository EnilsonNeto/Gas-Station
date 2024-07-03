using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;

namespace Gas_station.FuelPumps.Dto
{
    using SupplyTanks.Dto;

    [AutoMap(typeof(FuelPump))]
    public class FuelPumpDto : FullAuditedEntityDto<Guid>
    {
        public string TypeFuelPump { get; set; }

        public int NumberFuelPump { get; set; }

        public string SupllyValue { get; set; }

        public DateTime SupplyDate { get; set; }

        public string FuelValue { get; set; }

        public Guid SupplyTankId { get; set; }

        public virtual SupplyTankDto SupplyTank { get; set; }
    }
}
