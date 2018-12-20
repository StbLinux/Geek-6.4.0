using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Geek.AbpGeek.Configuration.Host.Dto;
using Geek.AbpGeek.Editions.Dto;

namespace Geek.AbpGeek.Web.Areas.AppAreaName.Models.HostSettings
{
    public class HostSettingsViewModel
    {
        public HostSettingsEditDto Settings { get; set; }

        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }

        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}