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

        builder.Entity<CidadeMunicipio>(b =>
        {
            b.ToTable(AbpGeGeocodificacaoDbProperties.DbTablePrefix + "CidadeMunicipio",
                AbpGeGeocodificacaoDbProperties.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.UnidadeFederativa).IsRequired();
            b.Property(x => x.Nome).IsRequired().HasMaxLength(CidadeMunicipioConsts.MaxNomeLength);
            b.Property(x => x.CodigoIbge).HasMaxLength(CidadeMunicipioConsts.MaxCodigoIbgeLength);
            b.Property(x => x.Ativo).IsRequired();
            b.Property(x => x.Origem).IsRequired();

            b.HasIndex(x => x.CodigoIbge).IsUnique();
            b.HasIndex(x => new { x.UnidadeFederativa, x.Nome }).IsUnique();
        });

        builder.Entity<BairroDistrito>(b =>
        {
            b.ToTable(AbpGeGeocodificacaoDbProperties.DbTablePrefix + "BairroDistrito",
                AbpGeGeocodificacaoDbProperties.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Nome).IsRequired().HasMaxLength(BairroDistritoConsts.MaxNomeLength);
            b.Property(x => x.CodigoIbge).HasMaxLength(BairroDistritoConsts.MaxCodigoIbgeLength);
            b.Property(x => x.Ativo).IsRequired();
            b.Property(x => x.Origem).IsRequired();

            b.HasOne(o => o.CidadeMunicipio).WithMany().HasForeignKey(x => x.CidadeMunicipioId).IsRequired().OnDelete(DeleteBehavior.Cascade);

            b.HasIndex(x => x.CodigoIbge).IsUnique();
            b.HasIndex(x => new { x.CidadeMunicipioId, x.Nome }).IsUnique();
        });

        builder.Entity<Subdistrito>(b =>
        {
            b.ToTable(AbpGeGeocodificacaoDbProperties.DbTablePrefix + "Subdistrito",
                AbpGeGeocodificacaoDbProperties.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Nome).IsRequired().HasMaxLength(SubdistritoConsts.MaxNomeLength);
            b.Property(x => x.CodigoIbge).HasMaxLength(SubdistritoConsts.MaxCodigoIbgeLength);
            b.Property(x => x.Ativo).IsRequired();
            b.Property(x => x.Origem).IsRequired();

            b.HasOne(o => o.BairroDistrito).WithMany().HasForeignKey(x => x.BairroDistritoId).IsRequired().OnDelete(DeleteBehavior.Cascade);

            b.HasIndex(x => x.CodigoIbge).IsUnique();
            b.HasIndex(x => new { x.BairroDistritoId, x.Nome }).IsUnique();
        });
    }
}
