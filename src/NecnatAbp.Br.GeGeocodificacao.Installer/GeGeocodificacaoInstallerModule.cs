using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace NecnatAbp.Br.GeGeocodificacao;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class GeGeocodificacaoInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<GeGeocodificacaoInstallerModule>();
        });
    }
}
