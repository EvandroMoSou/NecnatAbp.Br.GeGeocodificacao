using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public class Subdistrito : AuditedAggregateRoot<Guid>
    {
        public Guid BairroDistritoId { get; set; }
        public BairroDistrito? BairroDistrito { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string? CodigoIbge { get; set; }
        public bool Ativo { get; set; }
        public int Origem { get; set; }
    }
}
