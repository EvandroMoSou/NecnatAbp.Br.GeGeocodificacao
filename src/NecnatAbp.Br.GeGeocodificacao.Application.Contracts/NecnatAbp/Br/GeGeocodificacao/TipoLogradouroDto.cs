using NecnatAbp.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public class TipoLogradouroDto : ConcurrencyAuditedEntityDto<Guid>
    {
        public string? Sigla { get; set; }
        public string? Nome { get; set; }
        public bool InAtivo { get; set; }
    }
}