using NecnatAbp.Dtos;
using System.ComponentModel.DataAnnotations;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public class CreateUpdateCidadeMunicipioDto : ConcurrencyDto
    {
        [Required]
        public UnidadeFederativa UnidadeFederativa { get; set; }

        [Required]
        [StringLength(CidadeMunicipioConsts.MaxNomeLength)]
        public string Nome { get; set; } = string.Empty;

        [StringLength(CidadeMunicipioConsts.MaxCodigoIbgeLength)]
        public string? CodigoIbge { get; set; }

        [Required]
        public bool InAtivo { get; set; }
    }
}
