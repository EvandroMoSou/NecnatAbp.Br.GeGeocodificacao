using NecnatAbp.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public class CreateUpdateTipoLogradouroDto : ConcurrencyDto
    {
        public string? Sigla { get; set; }

        [Required]
        [StringLength(TipoLogradouroConsts.MaxNomeLength)]
        public string Nome { get; set; } = string.Empty;

        [Required]
        public bool InAtivo { get; set; }
    }
}
