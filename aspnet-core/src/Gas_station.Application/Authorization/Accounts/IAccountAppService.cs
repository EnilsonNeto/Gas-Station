using System.Threading.Tasks;
using Abp.Application.Services;
using Gas_station.Authorization.Accounts.Dto;

namespace Gas_station.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
