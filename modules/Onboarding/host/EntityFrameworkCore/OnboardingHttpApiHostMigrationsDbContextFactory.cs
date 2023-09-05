namespace FSG.HCM.Onboarding.EntityFrameworkCore
{
    public class OnboardingHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<OnboardingHttpApiHostMigrationsDbContext>
    {
        public OnboardingHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<OnboardingHttpApiHostMigrationsDbContext>()
                .UseMySql(configuration.GetConnectionString("Onboarding"), MySqlServerVersion.LatestSupportedServerVersion);
            return new OnboardingHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
