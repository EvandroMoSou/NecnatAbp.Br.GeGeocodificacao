using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace NecnatAbp.Br.GeGeocodificacao;

[DependsOn(
    typeof(GeGeocodificacaoApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class GeGeocodificacaoHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(GeGeocodificacaoApplicationContractsModule).Assembly,
            GeGeocodificacaoRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<GeGeocodificacaoHttpApiClientModule>();
        });

    }
}
