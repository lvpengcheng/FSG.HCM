namespace FSG.HCM.CAP;

public interface IHCMCapTransactionApiFactory
{
    Type TransactionApiType { get; }
    
    ITransactionApi Create(ITransactionApi originalApi);
}