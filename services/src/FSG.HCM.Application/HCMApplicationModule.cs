

namespace FSG.HCM
{
    [DependsOn(
        typeof(HCMDomainModule),
        typeof(HCMApplicationContractsModule),
        typeof(BasicManagementApplicationModule),
        typeof(DataDictionaryManagementApplicationModule),
        typeof(NotificationManagementApplicationModule),
        typeof(LanguageManagementApplicationModule),
        typeof(HCMFreeSqlModule)
    )]
    public class HCMApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options => { options.AddMaps<HCMApplicationModule>(); });
        }
    }
}