using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Geek.AbpGeek.Configuration.Tenants.Dto;

namespace Geek.AbpGeek.Web.Areas.AppAreaName.Models.Settings
{
    public class SettingsViewModel
    {
        public TenantSettingsEditDto Settings { get; set; }
        
        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}