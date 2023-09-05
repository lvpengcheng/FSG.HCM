namespace FSG.HCM
{
    [DependsOn(
        typeof(HCMDomainSharedModule),
        typeof(AbpObjectExtendingModule),
        typeof(BasicManagementApplicationContractsModule),
        typeof(DataDictionaryManagementApplicationContractsModule),
        typeof(LanguageManagementApplicationContractsModule)
    )]
    public class HCMApplicationContractsModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            HCMDtoExtensions.Configure();
        }
    }
}
