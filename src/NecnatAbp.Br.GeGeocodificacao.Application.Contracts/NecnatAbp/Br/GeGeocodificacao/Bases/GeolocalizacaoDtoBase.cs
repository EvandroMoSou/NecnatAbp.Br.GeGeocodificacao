using NecnatAbp.Dtos;
using System;

namespace NecnatAbp.Br.GeGeocodificacao.Bases
{
    public class GeolocalizacaoDtoBase<TBairroDistritoDto, TCidadeMunicipioDto, TLogradouroDto, TPaisDto, TSubdistritoDto, TTipoLogradouroDto> : ConcurrencyAuditedEntityDto<Guid>
        where TBairroDistritoDto : BairroDistritoDtoBase<TSubdistritoDto>
        where TCidadeMunicipioDto : CidadeMunicipioDtoBase
        where TLogradouroDto : LogradouroDtoBase<TBairroDistritoDto, TCidadeMunicipioDto, TPaisDto, TSubdistritoDto, TTipoLogradouroDto>
        where TPaisDto : PaisDtoBase
        where TSubdistritoDto : SubdistritoDtoBase
        where TTipoLogradouroDto : TipoLogradouroDtoBase
    {
        public Guid? LogradouroId { get; set; }
        public TLogradouroDto? Logradouro { get; set; }
        public int? Numero { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public bool? InAtivo { get; set; }
    }
}
