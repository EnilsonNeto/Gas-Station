using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Gas_station.Configuration;
using Gas_station.Web;

namespace Gas_station.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class Gas_stationDbContextFactory : IDesignTimeDbContextFactory<Gas_stationDbContext>
    {
        public Gas_stationDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<Gas_stationDbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            Gas_stationDbContextConfigurer.Configure(builder, configuration.GetConnectionString(Gas_stationConsts.ConnectionStringName));

            return new Gas_stationDbContext(builder.Options);
        }
    }
}
