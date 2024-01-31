using NecnatAbp.Dtos;
using System;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public class LogradouroDto : ConcurrencyAuditedEntityDto<Guid>
    {
        public string? Cep { get; set; }
        public string? Nome { get; set; }
        public string? NomeAbreviado { get; set; }
        public string? Complemento { get; set; }
        public Guid? BairroDistritoId { get; set; }
        public Guid? CidadeMunicipioId { get; set; }
        public UnidadeFederativa? UnidadeFederativa { get; set; }
        public bool? Ativo { get; set; }
    }
}