using FSG.HCM.BasicManagement;
using FSG.HCM.LanguageManagement;
using FSG.HCM.NotificationManagement;

namespace FSG.HCM
{
    [DependsOn(
        typeof(HCMApplicationContractsModule),
        typeof(BasicManagementHttpApiClientModule),
        typeof(DataDictionaryManagementHttpApiClientModule),
        typeof(NotificationManagementHttpApiClientModule),
        typeof(LanguageManagementHttpApiClientModule)
    )]
    public class HCMHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Default";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(HCMApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
