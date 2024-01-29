using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace NecnatAbp.Br.GeGeocodificacao;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(GeGeocodificacaoDomainSharedModule)
)]
public class GeGeocodificacaoDomainModule : AbpModule
{

}
