namespace FSG.HCM.Onboarding.EntityFrameworkCore
{
    public class OnboardingHttpApiHostMigrationsDbContext : AbpDbContext<OnboardingHttpApiHostMigrationsDbContext>
    {
        public OnboardingHttpApiHostMigrationsDbContext(DbContextOptions<OnboardingHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.ConfigureOnboarding();
        }
    }
}
