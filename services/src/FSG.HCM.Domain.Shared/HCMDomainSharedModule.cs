using FSG.HCM.BasicManagement;
using FSG.HCM.BasicManagement.Localization;
using FSG.HCM.Core;
using FSG.HCM.LanguageManagement;

namespace FSG.HCM
{
    [DependsOn(
        typeof(HCMCoreModule),
        typeof(BasicManagementDomainSharedModule),
        typeof(DataDictionaryManagementDomainSharedModule),
        typeof(NotificationManagementDomainSharedModule),
        typeof(LanguageManagementDomainSharedModule)
    )]
    public class HCMDomainSharedModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            HCMGlobalFeatureConfigurator.Configure();
            HCMModuleExtensionConfigurator.Configure();
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options => { options.FileSets.AddEmbedded<HCMDomainSharedModule>(HCMDomainSharedConsts.NameSpace); });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<HCMResource>(HCMDomainSharedConsts.DefaultCultureName)
                    .AddVirtualJson("/Localization/HCM")
                    .AddBaseTypes(typeof(BasicManagementResource))
                    .AddBaseTypes(typeof(AbpTimingResource));

                options.DefaultResourceType = typeof(HCMResource);
            });

            Configure<AbpExceptionLocalizationOptions>(options => { options.MapCodeNamespace(HCMDomainSharedConsts.NameSpace, typeof(HCMResource)); });
        }
    }
}