using System.Reflection;
using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Geek.AbpGeek.Localization
{
    public static class AbpGeekLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(
                    AbpGeekConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AbpGeekLocalizationConfigurer).GetAssembly(),
                        "Geek.AbpGeek.Localization.AbpGeek"
                    )
                )
            );
        }
    }
}