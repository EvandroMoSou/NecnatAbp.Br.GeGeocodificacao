using System;

namespace NecnatAbp.Br.GeGeocodificacao.Bases
{
    public class BairroDistritoFallbackResultRequestDtoBase
    {
        public string? GenericSearch { get; set; }
        public Guid? CidadeMunicipioId { get; set; }
        public int ActiveFallbackCount { get; set; } = 5;
    }
}
