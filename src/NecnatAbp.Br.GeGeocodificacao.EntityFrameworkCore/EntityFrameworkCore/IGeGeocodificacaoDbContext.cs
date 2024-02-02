using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace NecnatAbp.Br.GeGeocodificacao.EntityFrameworkCore;

[ConnectionStringName(GeGeocodificacaoDbProperties.ConnectionStringName)]
public interface IGeGeocodificacaoDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */

    DbSet<Pais> Paises { get; }
    DbSet<CidadeMunicipio> CidadesMunicipios { get; }
    DbSet<BairroDistrito> BairrosDistritos { get; set; }
    DbSet<Subdistrito> Subdistritos { get; set; }
    DbSet<Logradouro> Logradouros { get; set; }
    DbSet<Geolocalizacao> Geolocalizacoes { get; set; }
    DbSet<TipoLogradouro> TiposLogradouro { get; set; }
}
