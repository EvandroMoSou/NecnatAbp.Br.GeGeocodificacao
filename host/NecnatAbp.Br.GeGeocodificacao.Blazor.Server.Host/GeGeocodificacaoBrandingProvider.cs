using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace NecnatAbp.Br.GeGeocodificacao.Blazor.Server.Host;

[Dependency(ReplaceServices = true)]
public class GeGeocodificacaoBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "GeGeocodificacao";
}
