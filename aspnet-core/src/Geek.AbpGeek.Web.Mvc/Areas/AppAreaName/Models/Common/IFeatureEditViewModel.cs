using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Geek.AbpGeek.Editions.Dto;

namespace Geek.AbpGeek.Web.Areas.AppAreaName.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}