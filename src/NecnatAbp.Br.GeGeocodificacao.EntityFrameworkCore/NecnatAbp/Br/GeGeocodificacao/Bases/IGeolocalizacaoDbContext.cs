using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace NecnatAbp.Br.GeGeocodificacao.Bases
{
    public interface IGeolocalizacaoDbContext<TBairroDistrito, TCidadeMunicipio, TGeolocalizacao, TLogradouro, TTipoLogradouro> : IEfCoreDbContext
        where TBairroDistrito : BairroDistritoBase<TCidadeMunicipio>
        where TCidadeMunicipio : CidadeMunicipioBase
        where TGeolocalizacao : GeolocalizacaoBase<TBairroDistrito, TCidadeMunicipio, TLogradouro, TTipoLogradouro>
        where TLogradouro : LogradouroBase<TBairroDistrito, TCidadeMunicipio, TTipoLogradouro>
        where TTipoLogradouro : TipoLogradouroBase       
    {
        DbSet<TGeolocalizacao> Geolocalizacoes { get; set; }
    }
}
