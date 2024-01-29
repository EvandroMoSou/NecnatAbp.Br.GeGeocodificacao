using NecnatAbp.Br.GeGeocodificacao.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace NecnatAbp.Br.GeGeocodificacao;

public abstract class GeGeocodificacaoController : AbpControllerBase
{
    protected GeGeocodificacaoController()
    {
        LocalizationResource = typeof(GeGeocodificacaoResource);
    }
}
