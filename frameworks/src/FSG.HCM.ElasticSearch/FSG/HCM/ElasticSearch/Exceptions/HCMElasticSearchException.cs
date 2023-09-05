namespace FSG.HCM.ElasticSearch.Exceptions;

public class HCMElasticSearchException : BusinessException
{
    public HCMElasticSearchException(
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

    public HCMElasticSearchException(SerializationInfo serializationInfo, StreamingContext context) : base(serializationInfo, context)
    {
    }
}