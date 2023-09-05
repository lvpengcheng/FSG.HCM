using Volo.Abp.AutoMapper;

namespace FSG.HCM.DataDictionaryManagement
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(DataDictionaryManagementDomainSharedModule),
        typeof(AbpCachingModule),
        typeof(AbpAutoMapperModule)
    )]
    public class DataDictionaryManagementDomainModule : AbpModule
    {

    }
}
