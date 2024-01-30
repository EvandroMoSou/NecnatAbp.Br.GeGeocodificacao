using Volo.Abp.Reflection;

namespace NecnatAbp.Br.GeGeocodificacao.Permissions;

public class GeGeocodificacaoPermissions
{
    public const string GroupName = "GeGeocodificacao";

    public static class Pais
    {
        public const string Default = GroupName + ".Pais";
        public const string Create = Default + ".Create";
        public const string Update = Default + ".Update";
        public const string Delete = Default + ".Delete";
    }

    public static class UnidadeFederativa
    {
        public const string Default = GroupName + ".UnidadeFederativa";
    }

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(GeGeocodificacaoPermissions));
    }
}
