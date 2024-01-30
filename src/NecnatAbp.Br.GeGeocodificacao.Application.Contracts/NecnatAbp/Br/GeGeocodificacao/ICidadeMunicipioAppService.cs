using NecnatAbp.AppServices;
using System;
using Volo.Abp.Application.Dtos;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public interface ICidadeMunicipioAppService :
        ICrudsAppService< //Defines CRUD methods
            CidadeMunicipioDto, //Used to show CidadeMunicipios
            Guid, //Primary key of the CidadeMunicipio entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateCidadeMunicipioDto, //Used to create/update a CidadeMunicipio
            CidadeMunicipioResultRequestDto> 
    {

    }
}
