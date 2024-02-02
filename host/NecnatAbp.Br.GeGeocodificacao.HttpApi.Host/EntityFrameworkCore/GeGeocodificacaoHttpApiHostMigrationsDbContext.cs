using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace NecnatAbp.Br.GeGeocodificacao.EntityFrameworkCore;

public class GeGeocodificacaoHttpApiHostMigrationsDbContext : AbpDbContext<GeGeocodificacaoHttpApiHostMigrationsDbContext>
{
    public GeGeocodificacaoHttpApiHostMigrationsDbContext(DbContextOptions<GeGeocodificacaoHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        GeGeocodificacaoDbContextModelCreatingExtensions.ConfigureGeGeocodificacao(modelBuilder);
    }
}
