using System.Collections.Generic;
using Geek.AbpGeek.Caching.Dto;

namespace Geek.AbpGeek.Web.Areas.AppAreaName.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}