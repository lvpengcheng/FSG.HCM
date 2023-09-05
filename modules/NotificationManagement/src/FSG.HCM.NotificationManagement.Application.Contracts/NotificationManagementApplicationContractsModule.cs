namespace FSG.HCM.NotificationManagement
{
    [DependsOn(
        typeof(NotificationManagementDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class NotificationManagementApplicationContractsModule : AbpModule
    {

    }
}
