using Microsoft.EntityFrameworkCore;
using NecnatAbp.Br.GeGeocodificacao.Bases;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace NecnatAbp.Br.GeGeocodificacao.EntityFrameworkCore;

[ConnectionStringName(GeGeocodificacaoDbProperties.ConnectionStringName)]
public class GeGeocodificacaoDbContext : AbpDbContext<GeGeocodificacaoDbContext>,
    IBairroDistritoDbContext<BairroDistrito, CidadeMunicipio>,
    ICidadeMunicipioDbContext<CidadeMunicipio>,
    IGeolocalizacaoDbContext<BairroDistrito, CidadeMunicipio, Geolocalizacao, Logradouro, TipoLogradouro>,
    ILogradouroDbContext<BairroDistrito, CidadeMunicipio, Logradouro, TipoLogradouro>,
    IPaisDbContext<Pais>,
    ISubdistritoDbContext<BairroDistrito, CidadeMunicipio, Subdistrito>,
    ITipoLogradouroDbContext<TipoLogradouro>,
    IGeGeocodificacaoDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public DbSet<BairroDistrito> BairrosDistritos { get; set; }
    public DbSet<CidadeMunicipio> CidadesMunicipios { get; set; }
    public DbSet<Geolocalizacao> Geolocalizacoes { get; set; }
    public DbSet<Logradouro> Logradouros { get; set; }
    public DbSet<Pais> Paises { get; set; }
    public DbSet<Subdistrito> Subdistritos { get; set; }
    public DbSet<TipoLogradouro> TiposLogradouro { get; set; }

    public GeGeocodificacaoDbContext(DbContextOptions<GeGeocodificacaoDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        GeGeocodificacaoDbContextModelCreatingExtensions.ConfigureGeGeocodificacao(builder);
    }
}
