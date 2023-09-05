namespace FSG.HCM.ElasticSearch;

[DependsOn(typeof(AbpAutofacModule))]
public class HCMElasticSearchModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.Configure<HCMElasticSearchOptions>(context.Services.GetConfiguration().GetSection("ElasticSearch"));
    }
}