using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public interface IPaisRepositoryBase<TPais>
        : IRepository<TPais, Guid>
        where TPais : PaisBase
    {
        Task<TPais?> GetByCodigoIso3166NumericAsync(string codigoIso3166Numeric);
        Task<TPais?> GetByNomeAsync(string nome);
        Task<int> UpdateAllAtivoAsync(bool ativo);
    }
}
