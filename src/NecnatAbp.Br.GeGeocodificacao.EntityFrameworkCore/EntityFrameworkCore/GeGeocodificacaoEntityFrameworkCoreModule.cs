using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace NecnatAbp.Br.GeGeocodificacao.EntityFrameworkCore;

[DependsOn(
    typeof(GeGeocodificacaoDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class GeGeocodificacaoEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<GeGeocodificacaoDbContext>(options =>
        {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
        });
    }
}
