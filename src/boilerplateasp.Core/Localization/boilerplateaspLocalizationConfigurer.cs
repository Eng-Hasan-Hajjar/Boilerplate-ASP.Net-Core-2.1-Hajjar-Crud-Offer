using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace boilerplateasp.Localization
{
    public static class boilerplateaspLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(boilerplateaspConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(boilerplateaspLocalizationConfigurer).GetAssembly(),
                        "boilerplateasp.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
