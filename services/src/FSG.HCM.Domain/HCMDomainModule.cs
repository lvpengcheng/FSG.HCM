namespace FSG.HCM
{
    [DependsOn(
        typeof(HCMDomainSharedModule),
        typeof(AbpEmailingModule),
        typeof(BasicManagementDomainModule),
        typeof(DataDictionaryManagementDomainModule),
        typeof(NotificationManagementDomainModule),
        typeof(LanguageManagementDomainModule)
    )]
    public class HCMDomainModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options => { options.AddMaps<HCMDomainModule>(); });
        }
    }
}