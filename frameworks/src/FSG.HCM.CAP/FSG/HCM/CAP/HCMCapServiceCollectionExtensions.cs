namespace FSG.HCM.CAP;

public static class HCMCapServiceCollectionExtensions
{
    public static ServiceConfigurationContext AddAbpCap(this ServiceConfigurationContext context, Action<CapOptions> capAction)
    {
        context.Services.Replace(ServiceDescriptor.Transient<IUnitOfWork, HCMCapUnitOfWork>());
        context.Services.Replace(ServiceDescriptor.Transient<UnitOfWork, HCMCapUnitOfWork>());
        context.Services.AddTransient<HCMCapUnitOfWork>();
        context.Services.AddCap(capAction);
        return context;
    }
}