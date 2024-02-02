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
    public abstract class EfCoreSubdistritoRepositoryBase<TEfCoreDbContext, TBairroDistrito, TCidadeMunicipio, TSubdistrito>
        : EfCoreRepository<TEfCoreDbContext, TSubdistrito, Guid>,
        ISubdistritoRepositoryBase<TBairroDistrito, TCidadeMunicipio, TSubdistrito>,
        IRepository<TSubdistrito, Guid>
        where TEfCoreDbContext : ISubdistritoDbContext<TBairroDistrito, TCidadeMunicipio, TSubdistrito>
        where TBairroDistrito : BairroDistritoBase<TCidadeMunicipio>
        where TCidadeMunicipio : CidadeMunicipioBase
        where TSubdistrito : SubdistritoBase<TBairroDistrito, TCidadeMunicipio>, new()
    {
        public EfCoreSubdistritoRepositoryBase(IDbContextProvider<TEfCoreDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<TSubdistrito?> GetByCodigoIbgeAsync(string codigoIbge)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.Where(x => x.CodigoIbge == codigoIbge).FirstOrDefaultAsync();
        }

        public async Task<TSubdistrito?> GetByCodigoIbgeWithBairroDistritoAsync(string codigoIbge)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.Include(x => x.BairroDistrito).Where(x => x.CodigoIbge == codigoIbge).FirstOrDefaultAsync();
        }

        public async Task<TSubdistrito?> GetByBairroDistritoIdAndNomeAsync(Guid bairroDistritoId, string nome)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.Where(x => x.BairroDistritoId == bairroDistritoId && x.Nome == nome).FirstOrDefaultAsync();
        }

        public async Task<List<TSubdistrito>> SearchByCidadeMunicipioIdAndNomeContainsWithBairroDistritoAsync(Guid cidadeMunicipioId, string nomeContains)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.Include(x => x.BairroDistrito).Where(x => x.BairroDistrito!.CidadeMunicipioId == cidadeMunicipioId && x.Nome.Contains(nomeContains)).ToListAsync();
        }

        public async Task<int> UpdateAllAtivoAsync(bool ativo)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.ExecuteUpdateAsync(s => s.SetProperty(e => e.InAtivo, ativo));
        }
    }
}
