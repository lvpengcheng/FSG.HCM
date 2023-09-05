namespace FSG.HCM;

public interface IHCMExceptionConverter
{
    string TryToLocalizeExceptionMessage(Exception exception);
}