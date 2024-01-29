using Volo.Abp.Reflection;

namespace NecnatAbp.Br.GeGeocodificacao.Permissions;

public class GeGeocodificacaoPermissions
{
    public const string GroupName = "GeGeocodificacao";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(GeGeocodificacaoPermissions));
    }
}
