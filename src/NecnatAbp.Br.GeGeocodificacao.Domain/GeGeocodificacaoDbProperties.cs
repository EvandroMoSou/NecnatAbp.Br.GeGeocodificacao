namespace NecnatAbp.Br.GeGeocodificacao;

public static class GeGeocodificacaoDbProperties
{
    public static string DbTablePrefix { get; set; } = "GeGeocodificacao";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "GeGeocodificacao";
}
