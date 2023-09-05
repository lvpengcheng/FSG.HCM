namespace FSG.HCM.FileManagement.Data;

public interface IFileManagementDbSchemaMigrator
{
    Task MigrateAsync();
}