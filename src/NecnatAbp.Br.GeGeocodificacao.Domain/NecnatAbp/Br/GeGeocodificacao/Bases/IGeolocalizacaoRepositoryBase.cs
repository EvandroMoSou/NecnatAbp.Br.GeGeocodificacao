using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public interface IGeolocalizacaoRepositoryBase<TBairroDistrito, TCidadeMunicipio, TGeolocalizacao, TLogradouro, TTipoLogradouro>
        : IRepository<TGeolocalizacao, Guid>
        where TBairroDistrito : BairroDistritoBase<TCidadeMunicipio>
        where TCidadeMunicipio : CidadeMunicipioBase
        where TGeolocalizacao : GeolocalizacaoBase<TBairroDistrito, TCidadeMunicipio, TLogradouro, TTipoLogradouro>
        where TLogradouro : LogradouroBase<TBairroDistrito, TCidadeMunicipio, TTipoLogradouro>
        where TTipoLogradouro : TipoLogradouroBase
    {
        Task<TGeolocalizacao?> GetByCepAndNumeroWithLogradouroAsync(int cep, int? numero);
        Task<TGeolocalizacao> MaintainAsync(TGeolocalizacao e, bool autoSave = false);
    }
}
