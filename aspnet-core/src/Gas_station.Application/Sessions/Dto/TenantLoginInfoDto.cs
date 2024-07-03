using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Gas_station.MultiTenancy;

namespace Gas_station.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
