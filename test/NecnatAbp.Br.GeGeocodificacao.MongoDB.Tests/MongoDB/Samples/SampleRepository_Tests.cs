using NecnatAbp.Br.GeGeocodificacao.Samples;
using Xunit;

namespace NecnatAbp.Br.GeGeocodificacao.MongoDB.Samples;

[Collection(MongoTestCollection.Name)]
public class SampleRepository_Tests : SampleRepository_Tests<GeGeocodificacaoMongoDbTestModule>
{
    /* Don't write custom repository tests here, instead write to
     * the base class.
     * One exception can be some specific tests related to MongoDB.
     */
}
