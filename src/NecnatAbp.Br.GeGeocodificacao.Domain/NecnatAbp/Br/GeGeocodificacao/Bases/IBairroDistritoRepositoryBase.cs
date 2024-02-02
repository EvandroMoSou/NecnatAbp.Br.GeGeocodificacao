using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public interface IBairroDistritoRepositoryBase<TBairroDistrito, TCidadeMunicipio>
        : IRepository<TBairroDistrito, Guid>
        where TBairroDistrito : BairroDistritoBase<TCidadeMunicipio>
        where TCidadeMunicipio : CidadeMunicipioBase
    {
        Task<TBairroDistrito?> GetByCodigoIbgeAsync(string codigoIbge);
        Task<TBairroDistrito?> GetByCidadeMunicipioIdAndNomeAsync(Guid cidadeMunicipioId, string nome);
        Task<List<TBairroDistrito>> SearchByCidadeMunicipioIdAndNomeContainsAsync(Guid cidadeMunicipioId, string nomeContains);
        Task<int> UpdateAllAtivoAsync(bool ativo);
        Task<TBairroDistrito> MaintainAsync(TBairroDistrito e, bool autoSave = false);
    }
}