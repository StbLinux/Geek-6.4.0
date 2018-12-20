using System.Collections.Generic;
using Abp.Localization;
using Geek.AbpGeek.Install.Dto;

namespace Geek.AbpGeek.Web.Models.Install
{
    public class InstallViewModel
    {
        public List<ApplicationLanguage> Languages { get; set; }

        public AppSettingsJsonDto AppSettingsJson { get; set; }
    }
}
