using NecnatAbp.Dtos;
using System;
using System.ComponentModel.DataAnnotations;

namespace NecnatAbp.Br.GeGeocodificacao.Bases
{
    public class CreateUpdateBairroDistritoDtoBase : ConcurrencyDto
    {
        [Required]
        public Guid CidadeMunicipioId { get; set; }

        [Required]
        [StringLength(BairroDistritoConsts.MaxNomeLength)]
        public string Nome { get; set; } = string.Empty;

        [StringLength(BairroDistritoConsts.MaxCodigoIbgeLength)]
        public string? CodigoIbge { get; set; }

        [Required]
        public bool InAtivo { get; set; }
    }
}
