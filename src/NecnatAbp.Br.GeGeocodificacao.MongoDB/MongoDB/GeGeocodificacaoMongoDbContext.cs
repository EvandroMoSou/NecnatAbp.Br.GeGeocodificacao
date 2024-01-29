using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace NecnatAbp.Br.GeGeocodificacao.MongoDB;

[ConnectionStringName(GeGeocodificacaoDbProperties.ConnectionStringName)]
public class GeGeocodificacaoMongoDbContext : AbpMongoDbContext, IGeGeocodificacaoMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureGeGeocodificacao();
    }
}
