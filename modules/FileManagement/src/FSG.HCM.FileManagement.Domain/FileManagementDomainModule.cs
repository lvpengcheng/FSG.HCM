namespace FSG.HCM.FileManagement;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(FileManagementDomainSharedModule)
)]
public class FileManagementDomainModule : AbpModule
{
}