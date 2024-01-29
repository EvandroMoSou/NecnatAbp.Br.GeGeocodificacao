using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace NecnatAbp.Br.GeGeocodificacao.MongoDB;

[ConnectionStringName(GeGeocodificacaoDbProperties.ConnectionStringName)]
public interface IGeGeocodificacaoMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
