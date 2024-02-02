using NecnatAbp.Br.GeGeocodificacao.Bases;

namespace NecnatAbp.Br.GeGeocodificacao.EntityFrameworkCore;

public class GeGeocodificacaoDbContextModelCreatingExtensions : GeGeocodificacaoDbContextModelCreatingExtensionsBase<
    Pais, CidadeMunicipio, BairroDistrito, Subdistrito, TipoLogradouro,
    Logradouro, Geolocalizacao>
{
}