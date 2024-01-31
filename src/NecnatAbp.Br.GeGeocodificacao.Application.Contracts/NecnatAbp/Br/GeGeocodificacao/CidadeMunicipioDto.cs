using NecnatAbp.Dtos;
using System;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public class CidadeMunicipioDto : ConcurrencyAuditedEntityDto<Guid>
    {
        public UnidadeFederativa? UnidadeFederativa { get; set; }
        public string? Nome { get; set; }
        public string? CodigoIbge { get; set; }
        public bool? Ativo { get; set; }
    }
}
