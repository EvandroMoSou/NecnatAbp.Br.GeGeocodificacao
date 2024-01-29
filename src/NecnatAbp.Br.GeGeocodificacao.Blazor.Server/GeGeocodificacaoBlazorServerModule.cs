using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace NecnatAbp.Br.GeGeocodificacao.Blazor.Server;

[DependsOn(
    typeof(AbpAspNetCoreComponentsServerThemingModule),
    typeof(GeGeocodificacaoBlazorModule)
    )]
public class GeGeocodificacaoBlazorServerModule : AbpModule
{

}
