using NecnatAbp.Br.GeGeocodificacao.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace NecnatAbp.Br.GeGeocodificacao.Pages;

public abstract class GeGeocodificacaoPageModel : AbpPageModel
{
    protected GeGeocodificacaoPageModel()
    {
        LocalizationResourceType = typeof(GeGeocodificacaoResource);
    }
}
