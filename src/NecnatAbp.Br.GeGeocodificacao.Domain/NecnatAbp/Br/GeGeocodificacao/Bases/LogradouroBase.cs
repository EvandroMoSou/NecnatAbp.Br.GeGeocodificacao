using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public abstract class LogradouroBase<TBairroDistrito, TCidadeMunicipio, TTipoLogradouro> : AuditedAggregateRoot<Guid>
        where TBairroDistrito : BairroDistritoBase<TCidadeMunicipio>
        where TCidadeMunicipio : CidadeMunicipioBase
        where TTipoLogradouro : TipoLogradouroBase
    {
        public int Cep { get; set; }
        public Guid? TipoLogradouroId { get; set; }
        public TTipoLogradouro? TipoLogradouro { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string? NomeAbreviado { get; set; }
        public string? Complemento { get; set; }
        public Guid BairroDistritoId { get; set; }
        public TBairroDistrito? BairroDistrito { get; set; }
        public Guid CidadeMunicipioId { get; set; }
        public TCidadeMunicipio? CidadeMunicipio { get; set; }
        public UnidadeFederativa UnidadeFederativa { get; set; }
        public Guid PaisId { get; set; }
        public Pais? Pais { get; set; }
        public bool InAtivo { get; set; }
        public int Origem { get; set; }
    }
}
