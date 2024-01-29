using NecnatAbp.Br.GeGeocodificacao.MongoDB;
using NecnatAbp.Br.GeGeocodificacao.Samples;
using Xunit;

namespace NecnatAbp.Br.GeGeocodificacao.MongoDb.Applications;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleAppService_Tests : SampleAppService_Tests<GeGeocodificacaoMongoDbTestModule>
{

}
