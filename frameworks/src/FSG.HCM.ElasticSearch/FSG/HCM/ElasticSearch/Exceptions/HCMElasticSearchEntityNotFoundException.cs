namespace FSG.HCM.ElasticSearch.Exceptions;

public class HCMElasticSearchEntityNotFoundException : BusinessException
{
    public HCMElasticSearchEntityNotFoundException(
        string code = null,
        string message = null,
        string details = null,
        Exception innerException = null,
        LogLevel logLevel = LogLevel.Error)
        : base(
            code,
            message,
            details,
            innerException,
            logLevel
        )
    {
    }

    public HCMElasticSearchEntityNotFoundException(SerializationInfo serializationInfo, StreamingContext context) : base(serializationInfo, context)
    {
    }
}