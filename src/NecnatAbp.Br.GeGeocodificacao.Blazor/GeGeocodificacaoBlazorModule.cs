using Microsoft.Extensions.DependencyInjection;
using NecnatAbp.Br.GeGeocodificacao.Blazor.Menus;
using Volo.Abp.AspNetCore.Components.Web.Theming;
using Volo.Abp.AspNetCore.Components.Web.Theming.Routing;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;

namespace NecnatAbp.Br.GeGeocodificacao.Blazor;

[DependsOn(
    typeof(GeGeocodificacaoApplicationContractsModule),
    typeof(AbpAspNetCoreComponentsWebThemingModule),
    typeof(AbpAutoMapperModule)
    )]
public class GeGeocodificacaoBlazorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<GeGeocodificacaoBlazorModule>();

        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddProfile<GeGeocodificacaoBlazorAutoMapperProfile>(validate: true);
        });

        Configure<AbpNavigationOptions>(options =>
        {
            options.MenuContributors.Add(new GeGeocodificacaoMenuContributor());
        });

        Configure<AbpRouterOptions>(options =>
        {
            options.AdditionalAssemblies.Add(typeof(GeGeocodificacaoBlazorModule).Assembly);
        });
    }
}
