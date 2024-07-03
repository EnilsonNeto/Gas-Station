using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Gas_station.Authorization.Roles;
using Gas_station.Authorization.Users;
using Gas_station.MultiTenancy;

namespace Gas_station.EntityFrameworkCore
{
    using SupplyTanks;
    using FuelPumps;

    public class Gas_stationDbContext : AbpZeroDbContext<Tenant, Role, User, Gas_stationDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public DbSet<SupplyTank> SupplyTanks { get; set; }
        public DbSet<FuelPump> FuelPumps { get; set; }

        public Gas_stationDbContext(DbContextOptions<Gas_stationDbContext> options)
            : base(options)
        {
        }
    }
}
