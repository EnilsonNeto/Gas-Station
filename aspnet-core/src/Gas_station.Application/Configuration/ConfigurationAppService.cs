using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Gas_station.Configuration.Dto;

namespace Gas_station.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : Gas_stationAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
