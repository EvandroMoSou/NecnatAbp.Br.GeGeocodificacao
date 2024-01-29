using Volo.Abp;
using Volo.Abp.MongoDB;

namespace NecnatAbp.Br.GeGeocodificacao.MongoDB;

public static class GeGeocodificacaoMongoDbContextExtensions
{
    public static void ConfigureGeGeocodificacao(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
