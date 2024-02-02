using NecnatAbp.Dtos;
using System;

namespace NecnatAbp.Br.GeGeocodificacao.Bases
{
    public class BairroDistritoResultRequestDtoBase : OptionalPagedAndSortedResultRequestDto
    {
        public string? GenericSearch { get; set; }
        public Guid? CidadeMunicipioId { get; set; }
        public string? NomeContains { get; set; }
        public string? CodigoIbge { get; set; }
        public bool? InAtivo { get; set; }
    }
}
