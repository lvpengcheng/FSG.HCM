namespace FSG.HCM.ElasticSearch;

public interface IElasticsearchProvider
{
    IElasticClient GetClient();
}