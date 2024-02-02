using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace NecnatAbp.Br.GeGeocodificacao.Bases
{
    public abstract class EfCoreCidadeMunicipioRepositoryBase<TEfCoreDbContext, TCidadeMunicipio>
        : EfCoreRepository<TEfCoreDbContext, TCidadeMunicipio, Guid>,
        ICidadeMunicipioRepositoryBase<TCidadeMunicipio>,
        IRepository<TCidadeMunicipio, Guid>
        where TCidadeMunicipio : CidadeMunicipioBase, new()
        where TEfCoreDbContext : ICidadeMunicipioDbContext<TCidadeMunicipio>
    {
        public EfCoreCidadeMunicipioRepositoryBase(IDbContextProvider<TEfCoreDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<TCidadeMunicipio?> GetByCodigoIbgeAsync(string codigoIbge)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.Where(x => x.CodigoIbge == codigoIbge).FirstOrDefaultAsync();
        }

        public async Task<TCidadeMunicipio?> GetByUnidadeFederativaAndNomeAsync(UnidadeFederativa unidadeFederativa, string nome)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.Where(x => x.UnidadeFederativa == unidadeFederativa && x.Nome == nome).FirstOrDefaultAsync();
        }

        public async Task<int> UpdateAllAtivoAsync(bool ativo)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.ExecuteUpdateAsync(s => s.SetProperty(e => e.InAtivo, ativo));
        }

        public async Task<TCidadeMunicipio> MaintainAsync(TCidadeMunicipio e, bool autoSave = false)
        {
            var eDb = await GetByUnidadeFederativaAndNomeAsync(e.UnidadeFederativa, e.Nome);
            var isInsert = eDb == null;

            if (isInsert)
                eDb = new TCidadeMunicipio();
            else if (EntityEquals(eDb!, e))
                return eDb!;

            eDb = EntityMap(e, eDb!);

            if (isInsert)
                return await InsertAsync(eDb, autoSave);
            else
                return await UpdateAsync(eDb, autoSave);
        }

        public virtual bool EntityEquals(TCidadeMunicipio e, TCidadeMunicipio eCompare)
        {
            return e.UnidadeFederativa == eCompare.UnidadeFederativa
                && e.Nome == eCompare.Nome
                && e.CodigoIbge == eCompare.CodigoIbge;
        }

        public virtual TCidadeMunicipio EntityMap(TCidadeMunicipio source, TCidadeMunicipio destination)
        {
            destination.UnidadeFederativa = source.UnidadeFederativa;
            destination.Nome = source.Nome;
            destination.CodigoIbge = source.CodigoIbge;
            destination.InAtivo = source.InAtivo;
            destination.Origem = source.Origem;

            return destination;
        }
    }
}
