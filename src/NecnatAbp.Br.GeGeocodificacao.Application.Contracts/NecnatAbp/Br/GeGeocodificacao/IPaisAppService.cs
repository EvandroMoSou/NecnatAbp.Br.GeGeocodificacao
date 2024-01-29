using NecnatAbp.AppServices;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public interface IPaisAppService :
        ICrudsAppService< //Defines CRUD methods
            PaisDto, //Used to show Paiss
            Guid, //Primary key of the Pais entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdatePaisDto, //Used to create/update a Pais
            PaisResultRequestDto>
    {

    }
}
