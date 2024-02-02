using NecnatAbp.AppServices;
using System;
using Volo.Abp.Application.Dtos;

namespace NecnatAbp.Br.GeGeocodificacao.Bases
{
    public interface IPaisAppServiceBase<
        TPaisDto, TCreateUpdatePaisDto, TPaisResultRequestDto> :
        ICrudsAppService<TPaisDto, Guid, PagedAndSortedResultRequestDto, TCreateUpdatePaisDto, TPaisResultRequestDto>
        where TPaisDto : PaisDtoBase
        where TCreateUpdatePaisDto : CreateUpdatePaisDtoBase
        where TPaisResultRequestDto : PaisResultRequestDtoBase
    {
    }
}
