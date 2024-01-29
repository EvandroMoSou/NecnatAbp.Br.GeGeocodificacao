using NecnatAbp.Br.GeGeocodificacao.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace NecnatAbp.Br.GeGeocodificacao.Permissions;

public class GeGeocodificacaoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(GeGeocodificacaoPermissions.GroupName, L("Permission:GeGeocodificacao"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<GeGeocodificacaoResource>(name);
    }
}
