using NecnatAbp.Dtos;
using System;

namespace NecnatAbp.Br.GeGeocodificacao.Bases
{
    public class CidadeMunicipioDtoBase : ConcurrencyAuditedEntityDto<Guid>
    {
        public UnidadeFederativa? UnidadeFederativa { get; set; }
        public string? Nome { get; set; }
        public string? CodigoIbge { get; set; }
        public bool? InAtivo { get; set; }
    }
}
