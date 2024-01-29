using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace NecnatAbp.Br.GeGeocodificacao;

[Dependency(ReplaceServices = true)]
public class GeGeocodificacaoBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "GeGeocodificacao";
}
