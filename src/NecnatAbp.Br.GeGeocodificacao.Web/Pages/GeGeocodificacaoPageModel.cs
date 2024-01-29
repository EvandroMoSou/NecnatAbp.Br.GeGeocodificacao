using NecnatAbp.Br.GeGeocodificacao.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace NecnatAbp.Br.GeGeocodificacao.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class GeGeocodificacaoPageModel : AbpPageModel
{
    protected GeGeocodificacaoPageModel()
    {
        LocalizationResourceType = typeof(GeGeocodificacaoResource);
        ObjectMapperContext = typeof(GeGeocodificacaoWebModule);
    }
}
