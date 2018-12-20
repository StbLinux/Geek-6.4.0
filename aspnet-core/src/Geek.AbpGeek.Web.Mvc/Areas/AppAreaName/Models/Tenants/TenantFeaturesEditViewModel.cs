using Abp.AutoMapper;
using Geek.AbpGeek.MultiTenancy;
using Geek.AbpGeek.MultiTenancy.Dto;
using Geek.AbpGeek.Web.Areas.AppAreaName.Models.Common;

namespace Geek.AbpGeek.Web.Areas.AppAreaName.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }

        public TenantFeaturesEditViewModel(Tenant tenant, GetTenantFeaturesEditOutput output)
        {
            Tenant = tenant;
            output.MapTo(this);
        }
    }
}