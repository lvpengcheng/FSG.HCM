namespace FSG.HCM.BasicManagement.Data
{
    public interface IHCMDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
