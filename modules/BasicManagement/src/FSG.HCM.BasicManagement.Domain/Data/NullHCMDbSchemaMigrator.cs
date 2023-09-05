using Volo.Abp.DependencyInjection;

namespace FSG.HCM.BasicManagement.Data
{
    /* This is used if database provider does't define
     * IHCMDbSchemaMigrator implementation.
     */
    public class NullHCMDbSchemaMigrator : IHCMDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}