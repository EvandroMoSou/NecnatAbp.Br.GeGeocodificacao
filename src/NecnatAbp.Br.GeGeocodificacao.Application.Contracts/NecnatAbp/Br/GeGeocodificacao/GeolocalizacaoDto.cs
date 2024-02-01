using NecnatAbp.Dtos;
using System;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public class GeolocalizacaoDto : ConcurrencyAuditedEntityDto<Guid>
    {
        public Guid? LogradouroId { get; set; }
        public LogradouroDto? Logradouro { get; set; }
        public int? Numero { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public bool? Ativo { get; set; }
    }
}
