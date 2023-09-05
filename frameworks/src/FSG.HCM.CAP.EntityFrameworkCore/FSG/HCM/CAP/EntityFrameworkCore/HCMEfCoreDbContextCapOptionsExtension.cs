namespace FSG.HCM.CAP.EntityFrameworkCore;

public class HCMEfCoreDbContextCapOptionsExtension : ICapOptionsExtension
{
    public string CapUsingDbConnectionString { get; init; }
    
    public void AddServices(IServiceCollection services)
    {
        services.Configure<HCMEfCoreDbContextCapOptions>(options =>
        {
            options.CapUsingDbConnectionString = CapUsingDbConnectionString;
        });
    }
}