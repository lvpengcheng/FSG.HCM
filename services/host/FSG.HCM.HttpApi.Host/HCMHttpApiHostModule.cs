using FSG.HCM.Onboarding;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace FSG.HCM
{
    [DependsOn(
        typeof(HCMHttpApiModule),
        typeof(HCMSharedHostingMicroserviceModule),
        typeof(AbpAspNetCoreMvcUiMultiTenancyModule),
        typeof(HCMEntityFrameworkCoreModule),
        typeof(AbpAspNetCoreAuthenticationJwtBearerModule),
        typeof(AbpAspNetCoreSerilogModule),
        typeof(AbpAccountWebModule),
        typeof(HCMApplicationModule),
        typeof(HCMCapModule),
        typeof(HCMCapEntityFrameworkCoreModule),
        typeof(AbpAspNetCoreMvcUiBasicThemeModule),
        typeof(AbpCachingStackExchangeRedisModule),
        typeof(AbpBackgroundJobsHangfireModule),
                 typeof(OnboardingModule)
    )]
    public partial class HCMHttpApiHostModule : AbpModule
    {
        public override void OnPostApplicationInitialization(ApplicationInitializationContext context)
        {
            // 应用程序初始化的时候注册hangfire
            //context.CreateRecurringJob();
            base.OnPostApplicationInitialization(context);
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var configuration = context.Services.GetConfiguration();
            ConfigureCache(context);
            ConfigureSwaggerServices(context);
            ConfigureJwtAuthentication(context, configuration);
            ConfigureHangfire(context);
            ConfigureMiniProfiler(context);
            ConfigureIdentity(context);
            ConfigureCap(context);
            ConfigureAuditLog(context);
            ConfigurationSignalR(context);
            ConfigurationMultiTenancy();
        }

      

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            var app = context.GetApplicationBuilder();
            var configuration = context.GetConfiguration();
            app.UseHCMRequestLocalization();
            app.UseCorrelationId();
            app.UseStaticFiles();
            if (configuration.GetValue("MiniProfiler:Enabled", false))
            {
                app.UseMiniProfiler();
            }

            app.UseRouting();
            app.UseCors(HCMHttpApiHostConst.DefaultCorsPolicyName);
            app.UseAuthentication();

            if (MultiTenancyConsts.IsEnabled)
            {
                app.UseMultiTenancy();
            }

            app.UseAuthorization();
            app.UseSwagger();
            app.UseAbpSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/HCM/swagger.json", "HCM API");
                options.DocExpansion(DocExpansion.None);
                options.DefaultModelsExpandDepth(-1);
            });

            app.UseAuditing();
            app.UseAbpSerilogEnrichers();
            app.UseUnitOfWork();
            app.UseConfiguredEndpoints(endpoints => { endpoints.MapHealthChecks("/health"); });
            app.UseHangfireDashboard("/hangfire", new DashboardOptions()
            {
                Authorization = new[] { new CustomHangfireAuthorizeFilter() },
                IgnoreAntiforgeryToken = true
            });

            if (configuration.GetValue("Consul:Enabled", false))
            {
                app.UseConsul();
            }
        }
    }
}