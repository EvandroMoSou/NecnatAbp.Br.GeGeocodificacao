using Microsoft.EntityFrameworkCore;
using NecnatAbp.Br.GeGeocodificacao.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public class EfCoreBairroDistritoRepository : EfCoreRepository<GeGeocodificacaoDbContext, BairroDistrito, Guid>, IBairroDistritoRepository
    {
        public EfCoreBairroDistritoRepository(IDbContextProvider<GeGeocodificacaoDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<BairroDistrito?> GetByCodigoIbgeAsync(string codigoIbge)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.Where(x => x.CodigoIbge == codigoIbge).FirstOrDefaultAsync();
        }

        public async Task<BairroDistrito?> GetByCidadeMunicipioIdAndNomeAsync(Guid cidadeMunicipioId, string nome)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.Where(x => x.CidadeMunicipioId == cidadeMunicipioId && x.Nome == nome).FirstOrDefaultAsync();
        }

        public async Task<List<BairroDistrito>> SearchByCidadeMunicipioIdAndNomeContainsAsync(Guid cidadeMunicipioId, string nomeContains)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.Where(x => x.CidadeMunicipioId == cidadeMunicipioId && x.Nome.Contains(nomeContains)).ToListAsync();
        }

        public async Task<int> UpdateAllAtivoAsync(bool ativo)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.ExecuteUpdateAsync(s => s.SetProperty(e => e.Ativo, ativo));
        }

        public async Task<BairroDistrito> MaintainAsync(BairroDistrito e, bool autoSave = false)
        {
            var eDb = await GetByCidadeMunicipioIdAndNomeAsync(e.CidadeMunicipioId, e.Nome);
            var isInsert = eDb == null;

            if (isInsert)
                eDb = new BairroDistrito();
            else if (eDb!.CidadeMunicipioId == e.CidadeMunicipioId
                && eDb.Nome == e.Nome
                && (e.CodigoIbge != null && eDb.CodigoIbge == e.CodigoIbge)
                && eDb.Ativo == e.Ativo)
                return eDb;

            eDb!.CidadeMunicipioId = e.CidadeMunicipioId;
            eDb.Nome = e.Nome;
            eDb.CodigoIbge = e.CodigoIbge;
            eDb.Ativo = e.Ativo;
            eDb.Origem = e.Origem;

            if (isInsert)
                return await InsertAsync(eDb, autoSave);
            else
                return await UpdateAsync(eDb, autoSave);
        }
    }
}
