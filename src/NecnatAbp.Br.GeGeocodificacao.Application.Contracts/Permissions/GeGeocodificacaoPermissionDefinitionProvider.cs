using NecnatAbp.Br.GeGeocodificacao.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace NecnatAbp.Br.GeGeocodificacao.Permissions;

public class GeGeocodificacaoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(GeGeocodificacaoPermissions.GroupName, L("Permission:GeGeocodificacao"));

        var pgPais = myGroup.AddPermission(GeGeocodificacaoPermissions.Pais.Default, L("Permission:Pais:Default"));
        pgPais.AddChild(GeGeocodificacaoPermissions.Pais.Create, L("Permission:Pais:Create"));
        pgPais.AddChild(GeGeocodificacaoPermissions.Pais.Update, L("Permission:Pais:Edit"));
        pgPais.AddChild(GeGeocodificacaoPermissions.Pais.Delete, L("Permission:Pais:Delete"));

        var pgUnidadeFederativa = myGroup.AddPermission(GeGeocodificacaoPermissions.UnidadeFederativa.Default, L("Permission:UnidadeFederativa:Default"));

        var pgCidadeMunicipio = myGroup.AddPermission(GeGeocodificacaoPermissions.CidadeMunicipio.Default, L("Permission:CidadeMunicipio:Default"));
        pgCidadeMunicipio.AddChild(GeGeocodificacaoPermissions.CidadeMunicipio.Create, L("Permission:CidadeMunicipio:Create"));
        pgCidadeMunicipio.AddChild(GeGeocodificacaoPermissions.CidadeMunicipio.Update, L("Permission:CidadeMunicipio:Edit"));
        pgCidadeMunicipio.AddChild(GeGeocodificacaoPermissions.CidadeMunicipio.Delete, L("Permission:CidadeMunicipio:Delete"));

        var pgBairroDistrito = myGroup.AddPermission(GeGeocodificacaoPermissions.BairroDistrito.Default, L("Permission:BairroDistrito:Default"));
        pgBairroDistrito.AddChild(GeGeocodificacaoPermissions.BairroDistrito.Create, L("Permission:BairroDistrito:Create"));
        pgBairroDistrito.AddChild(GeGeocodificacaoPermissions.BairroDistrito.Update, L("Permission:BairroDistrito:Edit"));
        pgBairroDistrito.AddChild(GeGeocodificacaoPermissions.BairroDistrito.Delete, L("Permission:BairroDistrito:Delete"));

        var pgSubdistrito = myGroup.AddPermission(GeGeocodificacaoPermissions.Subdistrito.Default, L("Permission:Subdistrito:Default"));
        pgSubdistrito.AddChild(GeGeocodificacaoPermissions.Subdistrito.Create, L("Permission:Subdistrito:Create"));
        pgSubdistrito.AddChild(GeGeocodificacaoPermissions.Subdistrito.Update, L("Permission:Subdistrito:Edit"));
        pgSubdistrito.AddChild(GeGeocodificacaoPermissions.Subdistrito.Delete, L("Permission:Subdistrito:Delete"));

        var pgLogradouro = myGroup.AddPermission(GeGeocodificacaoPermissions.Logradouro.Default, L("Permission:Logradouro:Default"));
        pgLogradouro.AddChild(GeGeocodificacaoPermissions.Logradouro.Create, L("Permission:Logradouro:Create"));
        pgLogradouro.AddChild(GeGeocodificacaoPermissions.Logradouro.Update, L("Permission:Logradouro:Edit"));
        pgLogradouro.AddChild(GeGeocodificacaoPermissions.Logradouro.Delete, L("Permission:Logradouro:Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<GeGeocodificacaoResource>(name);
    }
}
