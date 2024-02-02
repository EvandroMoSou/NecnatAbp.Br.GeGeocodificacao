using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public abstract class SubdistritoBase<TBairroDistrito, TCidadeMunicipio> : AuditedAggregateRoot<Guid>
        where TBairroDistrito : BairroDistritoBase<TCidadeMunicipio>
        where TCidadeMunicipio : CidadeMunicipioBase
    {
        public Guid BairroDistritoId { get; set; }
        public TBairroDistrito? BairroDistrito { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string? CodigoIbge { get; set; }
        public bool InAtivo { get; set; }
        public int Origem { get; set; }
    }
}
