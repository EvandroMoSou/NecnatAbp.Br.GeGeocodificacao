using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace NecnatAbp.Br.GeGeocodificacao.Bases
{
    [ConnectionStringName(GeGeocodificacaoDbProperties.ConnectionStringName)]
    public interface IGeGeocodificacaoDbContextBase<TBairroDistrito, TCidadeMunicipio, TGeolocalizacao, TLogradouro, TPais, TSubdistrito, TTipoLogradouro> : IEfCoreDbContext
    where TBairroDistrito : BairroDistritoBase<TCidadeMunicipio>
    where TCidadeMunicipio : CidadeMunicipioBase
    where TGeolocalizacao : GeolocalizacaoBase<TBairroDistrito, TCidadeMunicipio, TLogradouro, TTipoLogradouro>
    where TLogradouro : LogradouroBase<TBairroDistrito, TCidadeMunicipio, TTipoLogradouro>
    where TPais : PaisBase
    where TSubdistrito : SubdistritoBase<TBairroDistrito, TCidadeMunicipio>
    where TTipoLogradouro : TipoLogradouroBase
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */

        DbSet<TPais> Paises { get; }
        DbSet<TCidadeMunicipio> CidadesMunicipios { get; }
        DbSet<TBairroDistrito> BairrosDistritos { get; set; }
        DbSet<TSubdistrito> Subdistritos { get; set; }
        DbSet<TLogradouro> Logradouros { get; set; }
        DbSet<TGeolocalizacao> Geolocalizacoes { get; set; }
        DbSet<TTipoLogradouro> TiposLogradouro { get; set; }
    }
}