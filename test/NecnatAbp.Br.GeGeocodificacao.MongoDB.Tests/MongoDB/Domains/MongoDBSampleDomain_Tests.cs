using NecnatAbp.Br.GeGeocodificacao.Samples;
using Xunit;

namespace NecnatAbp.Br.GeGeocodificacao.MongoDB.Domains;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleDomain_Tests : SampleManager_Tests<GeGeocodificacaoMongoDbTestModule>
{

}
