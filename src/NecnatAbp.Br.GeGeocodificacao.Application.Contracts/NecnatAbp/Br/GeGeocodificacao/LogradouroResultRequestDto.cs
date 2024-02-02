using NecnatAbp.Dtos;
using System;
using Volo.Abp.Application.Dtos;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public class LogradouroResultRequestDto : OptionalPagedAndSortedResultRequestDto
    {
        public string? GenericSearch { get; set; }
        public string? Cep { get; set; }
        public string? NomeContains { get; set; }
        public Guid? BairroDistritoId { get; set; }
        public Guid? CidadeMunicipioId { get; set; }
        public UnidadeFederativa? UnidadeFederativa { get; set; }
        public bool? InAtivo { get; set; }
    }
}
