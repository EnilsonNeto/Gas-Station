using System.Threading.Tasks;
using Gas_station.Configuration.Dto;

namespace Gas_station.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
