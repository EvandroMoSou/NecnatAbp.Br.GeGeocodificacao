using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public abstract class BairroDistritoBase<TCidadeMunicipio> : AuditedAggregateRoot<Guid>
        where TCidadeMunicipio : CidadeMunicipioBase
    {
        public Guid CidadeMunicipioId { get; set; }
        public TCidadeMunicipio? CidadeMunicipio { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string? CodigoIbge { get; set; }
        public bool InAtivo { get; set; }
        public int Origem { get; set; }
    }
}
