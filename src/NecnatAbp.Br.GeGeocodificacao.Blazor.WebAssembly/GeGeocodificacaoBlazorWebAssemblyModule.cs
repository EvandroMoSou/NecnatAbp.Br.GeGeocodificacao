using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace NecnatAbp.Br.GeGeocodificacao.Blazor.WebAssembly;

[DependsOn(
    typeof(GeGeocodificacaoBlazorModule),
    typeof(GeGeocodificacaoHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class GeGeocodificacaoBlazorWebAssemblyModule : AbpModule
{

}
