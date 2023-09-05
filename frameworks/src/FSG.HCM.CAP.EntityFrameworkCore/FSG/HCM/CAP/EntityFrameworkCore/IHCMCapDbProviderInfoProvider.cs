namespace FSG.HCM.CAP.EntityFrameworkCore;

public interface IHCMCapDbProviderInfoProvider
{
    HCMCapDbProviderInfo GetOrNull(string dbProviderName);
}