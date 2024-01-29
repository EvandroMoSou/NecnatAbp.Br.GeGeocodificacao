using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;
using NecnatAbp.Br.GeGeocodificacao.Localization;
using NecnatAbp.Br.GeGeocodificacao.Web.Menus;
using Volo.Abp.AspNetCore.Mvc.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;
using Volo.Abp.VirtualFileSystem;
using NecnatAbp.Br.GeGeocodificacao.Permissions;

namespace NecnatAbp.Br.GeGeocodificacao.Web;

[DependsOn(
    typeof(GeGeocodificacaoApplicationContractsModule),
    typeof(AbpAspNetCoreMvcUiThemeSharedModule),
    typeof(AbpAutoMapperModule)
    )]
public class GeGeocodificacaoWebModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.PreConfigure<AbpMvcDataAnnotationsLocalizationOptions>(options =>
        {
            options.AddAssemblyResource(typeof(GeGeocodificacaoResource), typeof(GeGeocodificacaoWebModule).Assembly);
        });

        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(GeGeocodificacaoWebModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpNavigationOptions>(options =>
        {
            options.MenuContributors.Add(new GeGeocodificacaoMenuContributor());
        });

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<GeGeocodificacaoWebModule>();
        });

        context.Services.AddAutoMapperObjectMapper<GeGeocodificacaoWebModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<GeGeocodificacaoWebModule>(validate: true);
        });

        Configure<RazorPagesOptions>(options =>
        {
                //Configure authorization.
            });
    }
}
