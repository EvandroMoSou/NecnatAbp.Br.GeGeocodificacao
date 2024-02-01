using System;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public class LogradouroFallbackResultRequestDto
    {
        public Guid? CidadeMunicipioId { get; set; }
        public string? GenericSearch { get; set; }
        public int? Numero { get; set; }
        public int ActiveFallbackCount { get; set; } = 5;
    }
}
