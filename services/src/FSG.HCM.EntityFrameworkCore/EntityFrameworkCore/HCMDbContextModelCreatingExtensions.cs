namespace FSG.HCM.EntityFrameworkCore
{
    public static class HCMDbContextModelCreatingExtensions
    {
        public static void ConfigureHCM(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(HCMConsts.DbTablePrefix + "YourEntities", HCMConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}