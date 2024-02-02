using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public abstract class TipoLogradouroBase : AuditedAggregateRoot<Guid>
    {
        public string? Sigla { get; set; }
        public string Nome { get; set; } = string.Empty;
        public bool InAtivo { get; set; }
        public int Origem { get; set; }
    }
}
