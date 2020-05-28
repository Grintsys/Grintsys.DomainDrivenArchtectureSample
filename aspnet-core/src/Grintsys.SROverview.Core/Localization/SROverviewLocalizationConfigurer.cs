using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Grintsys.SROverview.Localization
{
    public static class SROverviewLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(SROverviewConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(SROverviewLocalizationConfigurer).GetAssembly(),
                        "Grintsys.SROverview.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
