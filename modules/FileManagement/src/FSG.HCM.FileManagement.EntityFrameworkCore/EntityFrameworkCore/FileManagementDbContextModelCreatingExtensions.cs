namespace FSG.HCM.FileManagement.EntityFrameworkCore;

public static class FileManagementDbContextModelCreatingExtensions
{
    public static void ConfigureFileManagement(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));


        builder.Entity<FSG.HCM.FileManagement.Files.File>(b =>
        {
            b.ToTable(FileManagementDbProperties.DbTablePrefix + nameof(FSG.HCM.FileManagement.Files.File), FileManagementDbProperties.DbSchema);
            b.HasIndex(q => q.FileName);
            b.HasIndex(q => q.CreationTime);
            b.ConfigureByConvention();
        });
    }
}