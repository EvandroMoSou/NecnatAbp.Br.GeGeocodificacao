using NecnatAbp.AppServices;
using NecnatAbp.Extensions;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public class SubdistritoAppService :
       CrudsAppService<
           Subdistrito, //The Subdistrito entity
           SubdistritoDto, //Used to show Subdistritos
           Guid, //Primary key of the Subdistrito entity
           PagedAndSortedResultRequestDto, //Used for paging/sorting
           CreateUpdateSubdistritoDto, //Used to create/update a Subdistrito
           SubdistritoResultRequestDto>,
       ISubdistritoAppService //implement the ISubdistritoAppService
    {
        public SubdistritoAppService(ISubdistritoRepository repository) : base(repository)
        {
        }

        protected override async Task<IQueryable<Subdistrito>> CreateFilteredQuerySearchAsync(SubdistritoResultRequestDto input)
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
                if (input.CodigoIbge.Length != SubdistritoConsts.MaxCodigoIbgeLength)
                    throw new UserFriendlyException($"O filtro CodigoIbge deve conter {SubdistritoConsts.MaxCodigoIbgeLength} caracteres numéricos.");

                q = q.Where(x => x.CodigoIbge != null && x.CodigoIbge == input.CodigoIbge);
            }

            if (input.CidadeMunicipioId != null && input.CidadeMunicipioId != Guid.Empty)
                q = q.Where(x => x.BairroDistrito!.CidadeMunicipioId == input.CidadeMunicipioId);

            if (input.BairroDistritoId != null && input.BairroDistritoId != Guid.Empty)
                q = q.Where(x => x.BairroDistritoId == input.BairroDistritoId);

            if (!string.IsNullOrWhiteSpace(input.NomeContains))
            {
                if ((input.CidadeMunicipioId == null || input.CidadeMunicipioId == Guid.Empty)
                    && (input.BairroDistritoId == null || input.BairroDistritoId == Guid.Empty))
                    throw new UserFriendlyException("O filtro CidadeMunicipioId ou BairroDistritoId é obrigatório para essa pesquisa.");

                if (input.NomeContains.Length < 4)
                    throw new UserFriendlyException("O filtro NomeContains deve conter no mínimo 4 caracteres.");

                q = q.Where(x => x.Nome.Contains(input.NomeContains));
            }

            if (input.Ativo != null)
                q = q.Where(x => x.Ativo == input.Ativo);

            return q;
        }
    }
}
