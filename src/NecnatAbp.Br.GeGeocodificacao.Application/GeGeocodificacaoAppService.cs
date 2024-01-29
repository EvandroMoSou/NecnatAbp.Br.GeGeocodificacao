using NecnatAbp.Br.GeGeocodificacao.Localization;
using Volo.Abp.Application.Services;

namespace NecnatAbp.Br.GeGeocodificacao;

public abstract class GeGeocodificacaoAppService : ApplicationService
{
    protected GeGeocodificacaoAppService()
    {
        LocalizationResource = typeof(GeGeocodificacaoResource);
        ObjectMapperContext = typeof(GeGeocodificacaoApplicationModule);
    }
}
