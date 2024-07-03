using System.Threading.Tasks;
using Abp.Application.Services;
using Gas_station.Sessions.Dto;

namespace Gas_station.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
