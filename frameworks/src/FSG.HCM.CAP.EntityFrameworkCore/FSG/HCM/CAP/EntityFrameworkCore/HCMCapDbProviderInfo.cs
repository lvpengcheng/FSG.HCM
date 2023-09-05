namespace FSG.HCM.CAP.EntityFrameworkCore;

public class HCMCapDbProviderInfo
{
    public Type CapTransactionType { get; }
    
    public Type CapEfDbTransactionType { get; }
    
    public HCMCapDbProviderInfo(string capTransactionTypeName, string capEfDbTransactionTypeName)
    {
        CapTransactionType = Type.GetType(capTransactionTypeName, false);
        CapEfDbTransactionType = Type.GetType(capEfDbTransactionTypeName, false);
    }
}