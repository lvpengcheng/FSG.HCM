namespace FSG.HCM.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class HCMMigrationsDbContextFactory : IDesignTimeDbContextFactory<HCMDbContext>
    {
        public HCMDbContext CreateDbContext(string[] args)
        {
            HCMEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<HCMDbContext>()
                .UseMySql(configuration.GetConnectionString("Default"), MySqlServerVersion.LatestSupportedServerVersion);

            return new HCMDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath
                (
                    Path.Combine
                    (
                        Directory.GetCurrentDirectory(),
                        "../FSG.HCM.DbMigrator/"
                    )
                )
                .AddJsonFile
                (
                    "appsettings.json",
                    false
                );

            return builder.Build();
        }
    }
}