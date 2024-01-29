using NecnatAbp.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public class PaisDto : ConcurrencyAuditedEntityDto<Guid>
    {
        public string? Nome { get; set; }
        public string? NomeIngles { get; set; }
        public string? NomeFrances { get; set; }
        public string? CodigoIso3166Alpha2 { get; set; }
        public string? CodigoIso3166Alpha3 { get; set; }
        public string? CodigoIso3166Numeric { get; set; }
        public bool? Ativo { get; set; }
    }
}
