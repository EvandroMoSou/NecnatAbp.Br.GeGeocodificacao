using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public class CidadeMunicipio : AuditedAggregateRoot<Guid>
    {
        public UnidadeFederativa UnidadeFederativa { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string? CodigoIbge { get; set; }
        public bool InAtivo { get; set; }
        public int Origem { get; set; }
    }
}
