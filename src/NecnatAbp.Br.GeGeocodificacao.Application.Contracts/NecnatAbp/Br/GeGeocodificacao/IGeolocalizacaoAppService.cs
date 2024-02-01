using NecnatAbp.AppServices;
using System;
using Volo.Abp.Application.Dtos;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public interface IGeolocalizacaoAppService :
        ICrudsAppService< //Defines CRUD methods
            GeolocalizacaoDto, //Used to show Geolocalizacaos
            Guid, //Primary key of the Geolocalizacao entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateGeolocalizacaoDto, //Used to create/update a Geolocalizacao
            GeolocalizacaoResultRequestDto>
    {

    }
}
