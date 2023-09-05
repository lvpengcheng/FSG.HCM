using Localization.Resources.AbpUi;
using FSG.HCM.DataDictionaryManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace FSG.HCM.DataDictionaryManagement
{
    [DependsOn(
        typeof(DataDictionaryManagementApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class DataDictionaryManagementHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(DataDictionaryManagementHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<DataDictionaryManagementResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
