namespace FSG.HCM.EntityFrameworkCore
{
    public class EntityFrameworkCoreHCMDbSchemaMigrator
        : IHCMDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreHCMDbSchemaMigrator(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the HCMMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<HCMDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}