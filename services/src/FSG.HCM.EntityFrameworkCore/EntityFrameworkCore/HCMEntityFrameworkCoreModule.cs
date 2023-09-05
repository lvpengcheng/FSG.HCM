using FSG.HCM.LanguageManagement.EntityFrameworkCore;
using Volo.Abp.Guids;

namespace FSG.HCM.EntityFrameworkCore
{
    [DependsOn(
        typeof(HCMDomainModule),
        typeof(BasicManagementEntityFrameworkCoreModule),
        typeof(AbpEntityFrameworkCoreMySQLModule),
        typeof(DataDictionaryManagementEntityFrameworkCoreModule),
        typeof(NotificationManagementEntityFrameworkCoreModule),
        typeof(LanguageManagementEntityFrameworkCoreModule)
        )]
    public class HCMEntityFrameworkCoreModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            HCMEfCoreEntityExtensionMappings.Configure();
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<HCMDbContext>(options =>
            {
                /* Remove "includeAllEntities: true" to create
                 * default repositories only for aggregate roots */
                options.AddDefaultRepositories(includeAllEntities: true);
            });
            
            Configure<AbpDbContextOptions>(options =>
            {
                /* The main point to change your DBMS.
                 * See also HCMMigrationsDbContextFactory for EF Core tooling. */
                options.UseMySQL();
            });
        }
    }
}
