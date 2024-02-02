using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public interface ISubdistritoRepositoryBase<TBairroDistrito, TCidadeMunicipio, TSubdistrito>
        : IRepository<TSubdistrito, Guid>
        where TBairroDistrito : BairroDistritoBase<TCidadeMunicipio>
        where TCidadeMunicipio : CidadeMunicipioBase
        where TSubdistrito : SubdistritoBase<TBairroDistrito, TCidadeMunicipio>
    {
        Task<TSubdistrito?> GetByCodigoIbgeAsync(string codigoIbge);
        Task<TSubdistrito?> GetByCodigoIbgeWithBairroDistritoAsync(string codigoIbge);
        Task<TSubdistrito?> GetByBairroDistritoIdAndNomeAsync(Guid bairroDistritoId, string nome);
        Task<List<TSubdistrito>> SearchByCidadeMunicipioIdAndNomeContainsWithBairroDistritoAsync(Guid cidadeMunicipioId, string nomeContains);
        Task<int> UpdateAllAtivoAsync(bool ativo);
    }
}
