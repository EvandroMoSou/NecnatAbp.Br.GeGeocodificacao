using NecnatAbp.Dtos;
using Volo.Abp.Application.Dtos;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public class GeolocalizacaoResultRequestDto : OptionalPagedAndSortedResultRequestDto
    {
        public string? Cep { get; set; }
        public int? Numero { get; set; }
        public bool? Ativo { get; set; }
    }
}
