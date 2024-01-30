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

    DbSet<Pais> Pais { get; }
    DbSet<CidadeMunicipio> CidadeMunicipio { get; }
    DbSet<BairroDistrito> BairroDistrito { get; set; }
    DbSet<Subdistrito> Subdistrito { get; set; }
    DbSet<Logradouro> Logradouro { get; set; }
    DbSet<Geolocalizacao> Geolocalizacao { get; set; }
}
