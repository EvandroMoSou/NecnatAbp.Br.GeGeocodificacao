using NecnatAbp.Br.GeGeocodificacao.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace NecnatAbp.Br.GeGeocodificacao.Permissions;

public class GeGeocodificacaoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(GeGeocodificacaoPermissions.GroupName, L("Permission:GeGeocodificacao"));

        var pgPais = myGroup.AddPermission(GeGeocodificacaoPermissions.Paises.Default, L("Permission:Pais:Default"));
        pgPais.AddChild(GeGeocodificacaoPermissions.Paises.Create, L("Permission:Pais:Create"));
        pgPais.AddChild(GeGeocodificacaoPermissions.Paises.Update, L("Permission:Pais:Edit"));
        pgPais.AddChild(GeGeocodificacaoPermissions.Paises.Delete, L("Permission:Pais:Delete"));

        var pgUnidadeFederativa = myGroup.AddPermission(GeGeocodificacaoPermissions.UnidadesFederativas.Default, L("Permission:UnidadeFederativa:Default"));

        var pgCidadeMunicipio = myGroup.AddPermission(GeGeocodificacaoPermissions.CidadesMunicipios.Default, L("Permission:CidadeMunicipio:Default"));
        pgCidadeMunicipio.AddChild(GeGeocodificacaoPermissions.CidadesMunicipios.Create, L("Permission:CidadeMunicipio:Create"));
        pgCidadeMunicipio.AddChild(GeGeocodificacaoPermissions.CidadesMunicipios.Update, L("Permission:CidadeMunicipio:Edit"));
        pgCidadeMunicipio.AddChild(GeGeocodificacaoPermissions.CidadesMunicipios.Delete, L("Permission:CidadeMunicipio:Delete"));

        var pgBairroDistrito = myGroup.AddPermission(GeGeocodificacaoPermissions.BairrosDistritos.Default, L("Permission:BairroDistrito:Default"));
        pgBairroDistrito.AddChild(GeGeocodificacaoPermissions.BairrosDistritos.Create, L("Permission:BairroDistrito:Create"));
        pgBairroDistrito.AddChild(GeGeocodificacaoPermissions.BairrosDistritos.Update, L("Permission:BairroDistrito:Edit"));
        pgBairroDistrito.AddChild(GeGeocodificacaoPermissions.BairrosDistritos.Delete, L("Permission:BairroDistrito:Delete"));

        var pgSubdistrito = myGroup.AddPermission(GeGeocodificacaoPermissions.Subdistritos.Default, L("Permission:Subdistrito:Default"));
        pgSubdistrito.AddChild(GeGeocodificacaoPermissions.Subdistritos.Create, L("Permission:Subdistrito:Create"));
        pgSubdistrito.AddChild(GeGeocodificacaoPermissions.Subdistritos.Update, L("Permission:Subdistrito:Edit"));
        pgSubdistrito.AddChild(GeGeocodificacaoPermissions.Subdistritos.Delete, L("Permission:Subdistrito:Delete"));

        var pgLogradouro = myGroup.AddPermission(GeGeocodificacaoPermissions.Logradouros.Default, L("Permission:Logradouro:Default"));
        pgLogradouro.AddChild(GeGeocodificacaoPermissions.Logradouros.Create, L("Permission:Logradouro:Create"));
        pgLogradouro.AddChild(GeGeocodificacaoPermissions.Logradouros.Update, L("Permission:Logradouro:Edit"));
        pgLogradouro.AddChild(GeGeocodificacaoPermissions.Logradouros.Delete, L("Permission:Logradouro:Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<GeGeocodificacaoResource>(name);
    }
}
