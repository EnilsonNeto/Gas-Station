using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gas_station.SupplyTanks
{
    [Table("AppSupplyTank")]
    public class SupplyTank : FullAuditedEntity<Guid>
    {
        public string LevelOfFuelEmpty { get; set; }

        public string LevelOfFuelFull { get; set; }

        public string TypeFuel { get; set; }
    }
}
