using NecnatAbp.Dtos;
using System;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public class BairroDistritoDto : ConcurrencyAuditedEntityDto<Guid>
    {
        public Guid? CidadeMunicipioId { get; set; }
        public string? Nome { get; set; }
        public string? CodigoIbge { get; set; }
        public bool? Ativo { get; set; }

        public SubdistritoDto? Subdistrito { get; set; }
    }
}
