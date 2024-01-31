using NecnatAbp.AppServices;
using System;
using Volo.Abp.Application.Dtos;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public interface ISubdistritoAppService :
        ICrudsAppService< //Defines CRUD methods
            SubdistritoDto, //Used to show Subdistritos
            Guid, //Primary key of the Subdistrito entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateSubdistritoDto, //Used to create/update a Subdistrito
            SubdistritoResultRequestDto> 
    {

    }
}
