using NecnatAbp.Dtos;
using System;

namespace NecnatAbp.Br.GeGeocodificacao.Bases
{
    public class BairroDistritoDtoBase<TSubdistritoDto> : ConcurrencyAuditedEntityDto<Guid>
        where TSubdistritoDto : SubdistritoDtoBase
    {
        public Guid? CidadeMunicipioId { get; set; }
        public string? Nome { get; set; }
        public string? CodigoIbge { get; set; }
        public bool? InAtivo { get; set; }

        public TSubdistritoDto? Subdistrito { get; set; }
    }
}
