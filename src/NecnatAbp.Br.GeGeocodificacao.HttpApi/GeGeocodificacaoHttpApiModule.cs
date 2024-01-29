using Localization.Resources.AbpUi;
using NecnatAbp.Br.GeGeocodificacao.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace NecnatAbp.Br.GeGeocodificacao;

[DependsOn(
    typeof(GeGeocodificacaoApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class GeGeocodificacaoHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(GeGeocodificacaoHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<GeGeocodificacaoResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
