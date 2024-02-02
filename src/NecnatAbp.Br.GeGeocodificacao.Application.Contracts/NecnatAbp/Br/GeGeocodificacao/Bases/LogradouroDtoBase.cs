using NecnatAbp.Dtos;
using System;

namespace NecnatAbp.Br.GeGeocodificacao.Bases
{
    public class LogradouroDtoBase<TBairroDistritoDto, TCidadeMunicipioDto, TPaisDto, TSubdistritoDto, TTipoLogradouroDto> : ConcurrencyAuditedEntityDto<Guid>
        where TBairroDistritoDto : BairroDistritoDtoBase<TSubdistritoDto>
        where TCidadeMunicipioDto : CidadeMunicipioDtoBase
        where TPaisDto : PaisDtoBase
        where TSubdistritoDto : SubdistritoDtoBase
        where TTipoLogradouroDto : TipoLogradouroDtoBase
    {
        public string? Cep { get; set; }
        public string? Nome { get; set; }
        public string? NomeAbreviado { get; set; }
        public string? Complemento { get; set; }
        public Guid? TipoLogradouroId { get; set; }
        public TTipoLogradouroDto? TipoLogradouro { get; set; }
        public Guid? BairroDistritoId { get; set; }
        public TBairroDistritoDto? BairroDistrito { get; set; }
        public Guid? CidadeMunicipioId { get; set; }
        public TCidadeMunicipioDto? CidadeMunicipio { get; set; }
        public UnidadeFederativa? UnidadeFederativa { get; set; }
        public Guid? PaisId { get; set; }
        public TPaisDto? Pais { get; set; }
        public bool? InAtivo { get; set; }
    }
}