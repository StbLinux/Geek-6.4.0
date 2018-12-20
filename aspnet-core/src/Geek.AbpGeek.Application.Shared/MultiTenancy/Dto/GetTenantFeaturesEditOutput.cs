using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Geek.AbpGeek.Editions.Dto;

namespace Geek.AbpGeek.MultiTenancy.Dto
{
    public class GetTenantFeaturesEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}