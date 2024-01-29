using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace NecnatAbp.Br.GeGeocodificacao;

[DependsOn(
    typeof(GeGeocodificacaoDomainModule),
    typeof(GeGeocodificacaoApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule)
    )]
public class GeGeocodificacaoApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<GeGeocodificacaoApplicationModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<GeGeocodificacaoApplicationModule>(validate: true);
        });
    }
}
