using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace NecnatAbp.Br.GeGeocodificacao;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(GeGeocodificacaoHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class GeGeocodificacaoConsoleApiClientModule : AbpModule
{

}
