namespace FSG.HCM.FileManagement.Data;

public class NullFileManagementDbSchemaMigrator : IFileManagementDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}