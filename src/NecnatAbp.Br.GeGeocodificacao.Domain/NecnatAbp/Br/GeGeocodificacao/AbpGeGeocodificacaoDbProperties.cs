using NecnatAbp.Data;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public static class AbpGeGeocodificacaoDbProperties
    {
        public static string DbTablePrefix { get; set; } = NecnatAbpCommonDbProperties.DbTablePrefix;

        public static string? DbSchema { get; set; } = NecnatAbpCommonDbProperties.DbSchema;

        public const string ConnectionStringName = "AbpHierarchyManagement";
    }
}
