using NecnatAbp.Br.GeGeocodificacao.Localization;
using Volo.Abp.AspNetCore.Components;

namespace NecnatAbp.Br.GeGeocodificacao.Blazor.Server.Host;

public abstract class GeGeocodificacaoComponentBase : AbpComponentBase
{
    protected GeGeocodificacaoComponentBase()
    {
        LocalizationResource = typeof(GeGeocodificacaoResource);
    }
}
