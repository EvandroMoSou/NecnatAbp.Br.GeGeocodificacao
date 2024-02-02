using NecnatAbp.AppServices;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace NecnatAbp.Br.GeGeocodificacao.Bases
{
    public interface IBairroDistritoAppServiceBase<
        TBairroDistritoDto, TCreateUpdateBairroDistritoDto, TBairroDistritoResultRequestDto, TBairroDistritoFallbackResultRequestDto, TSubdistritoDto> :
        ICrudsAppService<TBairroDistritoDto, Guid, PagedAndSortedResultRequestDto, TCreateUpdateBairroDistritoDto, TBairroDistritoResultRequestDto>
        where TBairroDistritoDto : BairroDistritoDtoBase<TSubdistritoDto>
        where TCreateUpdateBairroDistritoDto : CreateUpdateBairroDistritoDtoBase
        where TBairroDistritoResultRequestDto : BairroDistritoResultRequestDtoBase
        where TBairroDistritoFallbackResultRequestDto : BairroDistritoFallbackResultRequestDtoBase
        where TSubdistritoDto : SubdistritoDtoBase
    {
        Task<List<TBairroDistritoDto>> SearchFallbackSubdistritoAsync(TBairroDistritoFallbackResultRequestDto input);
    }
}
