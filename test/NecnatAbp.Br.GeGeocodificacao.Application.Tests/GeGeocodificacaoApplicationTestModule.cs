using Volo.Abp.Modularity;

namespace NecnatAbp.Br.GeGeocodificacao;

[DependsOn(
    typeof(GeGeocodificacaoApplicationModule),
    typeof(GeGeocodificacaoDomainTestModule)
    )]
public class GeGeocodificacaoApplicationTestModule : AbpModule
{

}
