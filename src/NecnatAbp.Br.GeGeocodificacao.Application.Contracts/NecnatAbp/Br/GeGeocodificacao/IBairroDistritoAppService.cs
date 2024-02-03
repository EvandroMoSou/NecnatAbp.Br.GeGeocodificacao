using NecnatAbp.AppServices;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public interface IBairroDistritoAppService :
        ICrudsAppService< //Defines CRUD methods
            BairroDistritoDto, //Used to show BairroDistritos
            Guid, //Primary key of the BairroDistrito entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateBairroDistritoDto, //Used to create/update a BairroDistrito
            BairroDistritoResultRequestDto> 
    {
        Task<List<BairroDistritoDto>> SearchFallbackSubdistritoAsync(BairroDistritoFallbackResultRequestDto input);
    }
}
