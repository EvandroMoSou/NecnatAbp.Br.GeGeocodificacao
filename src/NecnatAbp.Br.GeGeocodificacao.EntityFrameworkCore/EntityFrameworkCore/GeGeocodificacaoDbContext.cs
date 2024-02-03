using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace NecnatAbp.Br.GeGeocodificacao.EntityFrameworkCore;

[ConnectionStringName(GeGeocodificacaoDbProperties.ConnectionStringName)]
public class GeGeocodificacaoDbContext : AbpDbContext<GeGeocodificacaoDbContext>, IGeGeocodificacaoDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public DbSet<Pais> Paises { get; set; }
    public DbSet<CidadeMunicipio> CidadesMunicipios { get; set; }
    public DbSet<BairroDistrito> BairrosDistritos { get; set; }
    public DbSet<Subdistrito> Subdistritos { get; set; }
    public DbSet<TipoLogradouro> TiposLogradouro { get; set; }
    public DbSet<Logradouro> Logradouros { get; set; }
    public DbSet<Geolocalizacao> Geolocalizacoes { get; set; }

    public GeGeocodificacaoDbContext(DbContextOptions<GeGeocodificacaoDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureGeGeocodificacao();
    }
}
