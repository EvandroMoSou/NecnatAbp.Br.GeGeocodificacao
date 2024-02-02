using NecnatAbp.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public class TipoLogradouroResultRequestDto : OptionalPagedAndSortedResultRequestDto
    {
        public string? Sigla { get; set; }
        public string? NomeContains { get; set; }
        public bool? InAtivo { get; set; }
    }
}
