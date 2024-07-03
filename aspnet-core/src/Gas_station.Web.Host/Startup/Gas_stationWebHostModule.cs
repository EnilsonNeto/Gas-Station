using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Gas_station.Configuration;

namespace Gas_station.Web.Host.Startup
{
    [DependsOn(
       typeof(Gas_stationWebCoreModule))]
    public class Gas_stationWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public Gas_stationWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Gas_stationWebHostModule).GetAssembly());
        }
    }
}
