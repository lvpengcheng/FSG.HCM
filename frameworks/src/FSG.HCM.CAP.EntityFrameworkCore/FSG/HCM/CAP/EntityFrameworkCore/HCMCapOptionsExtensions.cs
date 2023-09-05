// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
{
    public static class HCMCapOptionsExtensions
    {
        public static CapOptions SetCapDbConnectionString(this CapOptions options, string dbConnectionString)
        {
            options.RegisterExtension(new HCMEfCoreDbContextCapOptionsExtension
            {
                CapUsingDbConnectionString = dbConnectionString
            });
            
            return options;
        }
    }
}
