using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Gas_station.Authorization;

namespace Gas_station
{
    [DependsOn(
        typeof(Gas_stationCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class Gas_stationApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<Gas_stationAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(Gas_stationApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
