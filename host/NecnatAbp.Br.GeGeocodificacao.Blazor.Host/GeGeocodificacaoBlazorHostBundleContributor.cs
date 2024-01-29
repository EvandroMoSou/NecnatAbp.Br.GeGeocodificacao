using Volo.Abp.Bundling;

namespace NecnatAbp.Br.GeGeocodificacao.Blazor.Host;

public class GeGeocodificacaoBlazorHostBundleContributor : IBundleContributor
{
    public void AddScripts(BundleContext context)
    {

    }

    public void AddStyles(BundleContext context)
    {
        context.Add("main.css", true);
    }
}
