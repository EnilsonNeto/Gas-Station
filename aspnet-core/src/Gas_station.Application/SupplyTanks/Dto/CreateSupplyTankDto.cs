using Abp.AutoMapper;

namespace Gas_station.SupplyTanks.Dto
{
    [AutoMap(typeof(SupplyTank))]
    public class CreateSupplyTankDto
    {
        public string LevelOfFuelEmpty { get; set; }

        public string LevelOfFuelFull { get; set; }

        public string TypeFuel { get; set; }
    }
}
