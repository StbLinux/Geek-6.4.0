using Abp.AutoMapper;
using Geek.AbpGeek.Sessions.Dto;

namespace Geek.AbpGeek.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}