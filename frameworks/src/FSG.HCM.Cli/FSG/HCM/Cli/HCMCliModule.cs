namespace FSG.HCM.Cli;

[DependsOn(
    typeof(FSG.HCM.Cli.HCMCliCoreModule),
    typeof(AbpAutofacModule)
)]
public class HCMCliModule : AbpModule
{
}
