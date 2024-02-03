using System;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public class BairroDistritoFallbackResultRequestDto
    {
        public string? GenericSearch { get; set; }
        public Guid? CidadeMunicipioId { get; set; }
        public int ActiveFallbackCount { get; set; } = 5;
    }
}
