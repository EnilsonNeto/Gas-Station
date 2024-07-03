using Abp.Domain.Entities.Auditing;
using Gas_station.SupplyTanks;
using System;
using System.ComponentModel.DataAnnotations.Schema;
 
namespace Gas_station.FuelPumps
{
    [Table("AppFuelPump")]
    public class FuelPump : FullAuditedEntity<Guid>
    {
        public string TypeFuelPump { get; set; }

        public int NumberFuelPump { get; set; }

        public string SupllyValue { get; set; }

        public DateTime SupplyDate { get; set; }

        public string FuelValue { get; set; }

        public Guid SupplyTankId { get; set; }

        public virtual SupplyTank SupplyTank { get; set; }
    }
}
