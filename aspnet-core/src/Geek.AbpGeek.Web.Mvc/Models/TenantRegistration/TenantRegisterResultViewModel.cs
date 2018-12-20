using Abp.AutoMapper;
using Geek.AbpGeek.MultiTenancy.Dto;

namespace Geek.AbpGeek.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(RegisterTenantOutput))]
    public class TenantRegisterResultViewModel : RegisterTenantOutput
    {
        public string TenantLoginAddress { get; set; }
    }
}