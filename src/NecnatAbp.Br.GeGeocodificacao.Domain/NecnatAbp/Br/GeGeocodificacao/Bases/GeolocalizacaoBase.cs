using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public abstract class GeolocalizacaoBase<TBairroDistrito, TCidadeMunicipio, TLogradouro, TTipoLogradouro> : AuditedAggregateRoot<Guid>
        where TBairroDistrito : BairroDistritoBase<TCidadeMunicipio>
        where TCidadeMunicipio : CidadeMunicipioBase
        where TLogradouro : LogradouroBase<TBairroDistrito, TCidadeMunicipio, TTipoLogradouro>
        where TTipoLogradouro : TipoLogradouroBase
    {
        public Guid LogradouroId { get; set; }
        public TLogradouro? Logradouro { get; set; }
        public int? Numero { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public bool InAtivo { get; set; }
        public int Origem { get; set; }
    }
}
