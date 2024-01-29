using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace NecnatAbp.Br.GeGeocodificacao.EntityFrameworkCore;

public static class GeGeocodificacaoDbContextModelCreatingExtensions
{
    public static void ConfigureGeGeocodificacao(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        /* Configure all entities here. Example:

        builder.Entity<Question>(b =>
        {
            //Configure table & schema name
            b.ToTable(GeGeocodificacaoDbProperties.DbTablePrefix + "Questions", GeGeocodificacaoDbProperties.DbSchema);

            b.ConfigureByConvention();

            //Properties
            b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);

            //Relations
            b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

            //Indexes
            b.HasIndex(q => q.CreationTime);
        });
        */

        builder.Entity<Pais>(b =>
        {
            b.ToTable(AbpGeGeocodificacaoDbProperties.DbTablePrefix + "Pais",
                AbpGeGeocodificacaoDbProperties.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.CodigoIso3166Alpha2).HasMaxLength(PaisConsts.MaxCodigoIso3166Alpha2Length);
            b.Property(x => x.CodigoIso3166Alpha3).HasMaxLength(PaisConsts.MaxCodigoIso3166Alpha3Length);
            b.Property(x => x.CodigoIso3166Numeric).HasMaxLength(PaisConsts.MaxCodigoIso3166NumericLength);
            b.Property(x => x.Nome).IsRequired().HasMaxLength(PaisConsts.MaxNomeLength);
            b.Property(x => x.NomeIngles).HasMaxLength(PaisConsts.MaxNomeInglesLength);
            b.Property(x => x.NomeFrances).HasMaxLength(PaisConsts.MaxNomeFrancesLength);
            b.Property(x => x.Ativo).IsRequired();
            b.Property(x => x.Origem).IsRequired();

            b.HasIndex(x => x.CodigoIso3166Alpha2).IsUnique();
            b.HasIndex(x => x.CodigoIso3166Alpha3).IsUnique();
            b.HasIndex(x => x.CodigoIso3166Numeric).IsUnique();
            b.HasIndex(x => x.Nome).IsUnique();
        });
    }
}
