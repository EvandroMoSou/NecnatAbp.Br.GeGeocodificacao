using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace NecnatAbp.Br.GeGeocodificacao.Bases
{
    public abstract class EfCoreBairroDistritoRepositoryBase<TEfCoreDbContext, TBairroDistrito, TCidadeMunicipio>
        : EfCoreRepository<TEfCoreDbContext, TBairroDistrito, Guid>,
        IBairroDistritoRepositoryBase<TBairroDistrito, TCidadeMunicipio>,
        IRepository<TBairroDistrito, Guid>
        where TEfCoreDbContext : IBairroDistritoDbContext<TBairroDistrito, TCidadeMunicipio>
        where TBairroDistrito : BairroDistritoBase<TCidadeMunicipio>, new()
        where TCidadeMunicipio : CidadeMunicipioBase        
    {
        public EfCoreBairroDistritoRepositoryBase(IDbContextProvider<TEfCoreDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<TBairroDistrito?> GetByCodigoIbgeAsync(string codigoIbge)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.Where(x => x.CodigoIbge == codigoIbge).FirstOrDefaultAsync();
        }

        public async Task<TBairroDistrito?> GetByCidadeMunicipioIdAndNomeAsync(Guid cidadeMunicipioId, string nome)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.Where(x => x.CidadeMunicipioId == cidadeMunicipioId && x.Nome == nome).FirstOrDefaultAsync();
        }

        public async Task<List<TBairroDistrito>> SearchByCidadeMunicipioIdAndNomeContainsAsync(Guid cidadeMunicipioId, string nomeContains)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.Where(x => x.CidadeMunicipioId == cidadeMunicipioId && x.Nome.Contains(nomeContains)).ToListAsync();
        }

        public async Task<int> UpdateAllAtivoAsync(bool ativo)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.ExecuteUpdateAsync(s => s.SetProperty(e => e.InAtivo, ativo));
        }

        public async Task<TBairroDistrito> MaintainAsync(TBairroDistrito e, bool autoSave = false)
        {
            var eDb = await GetByCidadeMunicipioIdAndNomeAsync(e.CidadeMunicipioId, e.Nome);
            var isInsert = eDb == null;

            if (isInsert)
                eDb = new TBairroDistrito();
            else if (EntityEquals(eDb!, e))
                return eDb!;

            eDb = EntityMap(e, eDb!);

            if (isInsert)
                return await InsertAsync(eDb, autoSave);
            else
                return await UpdateAsync(eDb, autoSave);
        }

        public virtual bool EntityEquals(TBairroDistrito e, TBairroDistrito eCompare)
        {
            return e.CidadeMunicipioId == eCompare.CidadeMunicipioId
                && e.Nome == eCompare.Nome
                && e.CodigoIbge == eCompare.CodigoIbge;
        }

        public virtual TBairroDistrito EntityMap(TBairroDistrito source, TBairroDistrito destination)
        {
            destination.CidadeMunicipioId = source.CidadeMunicipioId;
            destination.Nome = source.Nome;
            destination.CodigoIbge = source.CodigoIbge;
            destination.InAtivo = source.InAtivo;
            destination.Origem = source.Origem;

            return destination;
        }
    }
}
