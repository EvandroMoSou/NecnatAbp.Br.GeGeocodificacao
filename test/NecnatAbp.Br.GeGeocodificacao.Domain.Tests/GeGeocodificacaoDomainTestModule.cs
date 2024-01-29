using Volo.Abp.Modularity;

namespace NecnatAbp.Br.GeGeocodificacao;

[DependsOn(
    typeof(GeGeocodificacaoDomainModule),
    typeof(GeGeocodificacaoTestBaseModule)
)]
public class GeGeocodificacaoDomainTestModule : AbpModule
{

}
