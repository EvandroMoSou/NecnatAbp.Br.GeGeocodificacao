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
