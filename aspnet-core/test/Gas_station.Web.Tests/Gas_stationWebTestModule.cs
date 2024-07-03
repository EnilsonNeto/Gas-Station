using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Gas_station.EntityFrameworkCore;
using Gas_station.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Gas_station.Web.Tests
{
    [DependsOn(
        typeof(Gas_stationWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class Gas_stationWebTestModule : AbpModule
    {
        public Gas_stationWebTestModule(Gas_stationEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Gas_stationWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(Gas_stationWebMvcModule).Assembly);
        }
    }
}