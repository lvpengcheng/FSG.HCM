namespace FSG.HCM.FileManagement.EntityFrameworkCore;

[ConnectionStringName(FileManagementDbProperties.ConnectionStringName)]
public class FileManagementDbContext : AbpDbContext<FileManagementDbContext>, IFileManagementDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public FileManagementDbContext(DbContextOptions<FileManagementDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureFileManagement();
    }

    public DbSet<FSG.HCM.FileManagement.Files.File> Files { get;  }
}