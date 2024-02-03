using NecnatAbp.AppServices;
using NecnatAbp.Br.GeGeocodificacao.Bases;
using NecnatAbp.Br.GeGeocodificacao.Permissions;
using System;
using Volo.Abp.Application.Dtos;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public class PaisAppServiceBase<TPais, TPaisDto, TCreateUpdatePaisDto, TPaisResultRequestDto> :
        CrudsAppService<
            TPais,
            TPaisDto,
            Guid,
            PagedAndSortedResultRequestDto,
            TCreateUpdatePaisDto,
            TPaisResultRequestDto>,
        IPaisAppServiceBase<TPaisDto, TCreateUpdatePaisDto, TPaisResultRequestDto>
        where TPais : PaisBase
        where TPaisDto : PaisDtoBase
        where TCreateUpdatePaisDto : CreateUpdatePaisDtoBase
        where TPaisResultRequestDto : PaisResultRequestDtoBase
    {
        public PaisAppServiceBase(IPaisRepositoryBase<TPais> repository) : base(repository)
        {
            GetPolicyName = GeGeocodificacaoPermissions.Paises.Default;
            GetListPolicyName = GeGeocodificacaoPermissions.Paises.Default;
            CreatePolicyName = GeGeocodificacaoPermissions.Paises.Create;
            UpdatePolicyName = GeGeocodificacaoPermissions.Paises.Update;
            DeletePolicyName = GeGeocodificacaoPermissions.Paises.Delete;
        }
    }
}
