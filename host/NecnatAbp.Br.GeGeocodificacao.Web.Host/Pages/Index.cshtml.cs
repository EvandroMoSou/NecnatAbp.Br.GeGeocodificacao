using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace NecnatAbp.Br.GeGeocodificacao.Pages;

public class IndexModel : GeGeocodificacaoPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
