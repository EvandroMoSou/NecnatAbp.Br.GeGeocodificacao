using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace NecnatAbp.Br.GeGeocodificacao.Blazor.Menus;

public class GeGeocodificacaoMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(GeGeocodificacaoMenus.Prefix, displayName: "GeGeocodificacao", "/GeGeocodificacao", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
