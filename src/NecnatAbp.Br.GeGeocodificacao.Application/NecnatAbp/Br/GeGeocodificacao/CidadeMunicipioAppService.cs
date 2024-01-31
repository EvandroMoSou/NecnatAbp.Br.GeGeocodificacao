using NecnatAbp.AppServices;
using NecnatAbp.Br.GeGeocodificacao.Permissions;
using NecnatAbp.Extensions;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public class CidadeMunicipioAppService :
        CrudsAppService<
            CidadeMunicipio, //The CidadeMunicipio entity
            CidadeMunicipioDto, //Used to show CidadeMunicipios
            Guid, //Primary key of the CidadeMunicipio entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateCidadeMunicipioDto, //Used to create/update a CidadeMunicipio
            CidadeMunicipioResultRequestDto>,
        ICidadeMunicipioAppService //implement the ICidadeMunicipioAppService
    {
        public CidadeMunicipioAppService(ICidadeMunicipioRepository repository) : base(repository)
        {
            GetPolicyName = GeGeocodificacaoPermissions.CidadeMunicipio.Default;
            GetListPolicyName = GeGeocodificacaoPermissions.CidadeMunicipio.Default;
            CreatePolicyName = GeGeocodificacaoPermissions.CidadeMunicipio.Create;
            UpdatePolicyName = GeGeocodificacaoPermissions.CidadeMunicipio.Update;
            DeletePolicyName = GeGeocodificacaoPermissions.CidadeMunicipio.Delete;
        }

        /// <summary>
        /// O filtro GenericSearch apresenta a seguinte linha de acao:
        ///     - 4+ caracteres alfanumericos: Realiza a busca conjuta pelo NomeContains.
        ///     - 7 caracteres numericos: Realiza a busca pelo CodigoIbge.
        /// </summary>
        protected override async Task<IQueryable<CidadeMunicipio>> CreateFilteredQuerySearchAsync(CidadeMunicipioResultRequestDto input)
        {
            var q = await ReadOnlyRepository.GetQueryableAsync();

            if (!string.IsNullOrWhiteSpace(input.GenericSearch))
            {
                if (input.GenericSearch.All(char.IsDigit))
                    input.CodigoIbge = input.GenericSearch;
                else
                    input.NomeContains = input.GenericSearch;
            }

            if (!string.IsNullOrWhiteSpace(input.CodigoIbge))
            {
                input.CodigoIbge = input.CodigoIbge.OnlyDigits();
                if (input.CodigoIbge.Length != CidadeMunicipioConsts.MaxCodigoIbgeLength)
                    throw new UserFriendlyException($"O filtro CodigoIbge deve conter {CidadeMunicipioConsts.MaxCodigoIbgeLength} caracteres numéricos.");

                q = q.Where(x => x.CodigoIbge != null && x.CodigoIbge == input.CodigoIbge);
            }

            if (!string.IsNullOrWhiteSpace(input.NomeContains))
            {
                if (input.UnidadeFederativa == null || (int)input.UnidadeFederativa == 0)
                    throw new UserFriendlyException("O filtro UnidadeFederativa é obrigatório para essa pesquisa.");

                if (input.NomeContains.Length < 4)
                    throw new UserFriendlyException("O filtro NomeContains deve conter no mínimo 4 caracteres.");

                q = q.Where(x => x.UnidadeFederativa == input.UnidadeFederativa && x.Nome.Contains(input.NomeContains));
            }

            if (input.Ativo != null)
                q = q.Where(x => x.Ativo == input.Ativo);

            return q;
        }
    }
}
