using Microsoft.EntityFrameworkCore;
using NecnatAbp.Br.GeGeocodificacao.Bases;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace NecnatAbp.Br.GeGeocodificacao.Bases
{
    public abstract class EfCorePaisRepositoryBase<TEfCoreDbContext, TPais>
        : EfCoreRepository<TEfCoreDbContext, TPais, Guid>,
        IPaisRepositoryBase<TPais>,
        IRepository<TPais, Guid>
        where TPais : Pais, new()
        where TEfCoreDbContext : IPaisDbContext<TPais>
    {
        public EfCorePaisRepositoryBase(IDbContextProvider<TEfCoreDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<TPais?> GetByCodigoIso3166NumericAsync(string codigoIso3166Numeric)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.Where(x => x.CodigoIso3166Numeric == codigoIso3166Numeric).FirstOrDefaultAsync();
        }

        public async Task<TPais?> GetByNomeAsync(string nome)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.Where(x => x.Nome == nome).FirstOrDefaultAsync();
        }

        public async Task<int> UpdateAllAtivoAsync(bool ativo)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.ExecuteUpdateAsync(s => s.SetProperty(e => e.InAtivo, ativo));
        }
    }
}
