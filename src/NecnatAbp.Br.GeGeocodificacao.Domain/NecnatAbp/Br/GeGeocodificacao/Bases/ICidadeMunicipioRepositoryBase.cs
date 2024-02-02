using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public interface ICidadeMunicipioRepositoryBase<TCidadeMunicipio>
        : IRepository<TCidadeMunicipio, Guid>
        where TCidadeMunicipio : CidadeMunicipio
    {
        Task<TCidadeMunicipio?> GetByCodigoIbgeAsync(string codigoIbge);
        Task<TCidadeMunicipio?> GetByUnidadeFederativaAndNomeAsync(UnidadeFederativa unidadeFederativa, string nome);
        Task<int> UpdateAllAtivoAsync(bool ativo);
        Task<TCidadeMunicipio> MaintainAsync(TCidadeMunicipio e, bool autoSave = false);
    }
}
