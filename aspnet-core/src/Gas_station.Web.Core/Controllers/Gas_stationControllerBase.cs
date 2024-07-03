using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Gas_station.Controllers
{
    public abstract class Gas_stationControllerBase: AbpController
    {
        protected Gas_stationControllerBase()
        {
            LocalizationSourceName = Gas_stationConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
