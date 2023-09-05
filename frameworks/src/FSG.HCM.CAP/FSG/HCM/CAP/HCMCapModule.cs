namespace FSG.HCM.CAP;

[DependsOn(
    typeof(AbpEventBusModule), 
    typeof(HCMLocalizationModule),
    typeof(AbpUnitOfWorkModule))]
public class HCMCapModule : AbpModule
{
}