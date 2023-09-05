namespace FSG.HCM;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpLocalizationModule)
)]
public class HCMLocalizationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options => { options.FileSets.AddEmbedded<HCMLocalizationModule>(HCMLocalizationConsts.NameSpace); });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Add<HCMLocalizationResource>(HCMLocalizationConsts.DefaultCultureName)
                .AddVirtualJson(HCMLocalizationConsts.DefaultLocalizationResourceVirtualPath);

            options.DefaultResourceType = typeof(HCMLocalizationResource);
        });

        Configure<AbpExceptionLocalizationOptions>(options => { options.MapCodeNamespace(HCMLocalizationConsts.NameSpace, typeof(HCMLocalizationResource)); });
    }
}