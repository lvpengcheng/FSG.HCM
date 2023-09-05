using FSG.HCM.BasicManagement;
using FSG.HCM.LanguageManagement;

namespace FSG.HCM
{
    [DependsOn(
        typeof(HCMApplicationContractsModule),
        typeof(BasicManagementHttpApiModule),
        typeof(DataDictionaryManagementHttpApiModule),
        typeof(NotificationManagementHttpApiModule),
        typeof(LanguageManagementHttpApiModule)
        )]
    public class HCMHttpApiModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            ConfigureLocalization();
        }

        private void ConfigureLocalization()
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<HCMResource>()
                    .AddBaseTypes(
                        typeof(AbpUiResource)
                    );
            });
        }
    }
}
