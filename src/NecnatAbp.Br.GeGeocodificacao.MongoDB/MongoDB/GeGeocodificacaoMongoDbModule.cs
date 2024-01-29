using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace NecnatAbp.Br.GeGeocodificacao.MongoDB;

[DependsOn(
    typeof(GeGeocodificacaoDomainModule),
    typeof(AbpMongoDbModule)
    )]
public class GeGeocodificacaoMongoDbModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddMongoDbContext<GeGeocodificacaoMongoDbContext>(options =>
        {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
        });
    }
}
