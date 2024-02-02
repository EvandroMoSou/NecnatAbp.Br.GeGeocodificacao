using NecnatAbp.AppServices;
using System;
using Volo.Abp.Application.Dtos;

namespace NecnatAbp.Br.GeGeocodificacao
{

    public interface ITipoLogradouroAppService :
        ICrudsAppService< //Defines CRUD methods
            TipoLogradouroDto, //Used to show TipoLogradouros
            Guid, //Primary key of the TipoLogradouro entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateTipoLogradouroDto, //Used to create/update a TipoLogradouro
            TipoLogradouroResultRequestDto>
    {

    }
}
