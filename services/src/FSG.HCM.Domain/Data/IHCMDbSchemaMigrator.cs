namespace FSG.HCM.Data
{
    public interface IHCMDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
