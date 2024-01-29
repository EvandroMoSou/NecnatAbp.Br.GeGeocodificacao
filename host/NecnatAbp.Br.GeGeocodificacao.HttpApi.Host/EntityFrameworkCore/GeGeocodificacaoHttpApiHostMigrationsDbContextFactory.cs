using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace NecnatAbp.Br.GeGeocodificacao.EntityFrameworkCore;

public class GeGeocodificacaoHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<GeGeocodificacaoHttpApiHostMigrationsDbContext>
{
    public GeGeocodificacaoHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<GeGeocodificacaoHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("GeGeocodificacao"));

        return new GeGeocodificacaoHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
