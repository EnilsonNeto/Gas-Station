using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Gas_station.EntityFrameworkCore
{
    public static class Gas_stationDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<Gas_stationDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<Gas_stationDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
