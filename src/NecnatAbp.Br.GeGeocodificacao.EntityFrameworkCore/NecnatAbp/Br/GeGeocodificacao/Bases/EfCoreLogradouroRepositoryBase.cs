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
    public abstract class EfCoreLogradouroRepositoryBase<TEfCoreDbContext, TBairroDistrito, TCidadeMunicipio, TLogradouro, TTipoLogradouro>
        : EfCoreRepository<TEfCoreDbContext, TLogradouro, Guid>,
        ILogradouroRepositoryBase<TBairroDistrito, TCidadeMunicipio, TLogradouro, TTipoLogradouro>,
        IRepository<TLogradouro, Guid>
        where TEfCoreDbContext : ILogradouroDbContext<TBairroDistrito, TCidadeMunicipio, TLogradouro, TTipoLogradouro>
        where TBairroDistrito : BairroDistritoBase<TCidadeMunicipio>
        where TCidadeMunicipio : CidadeMunicipioBase
        where TLogradouro : LogradouroBase<TBairroDistrito, TCidadeMunicipio, TTipoLogradouro>, new()
        where TTipoLogradouro : TipoLogradouroBase
    {
        public EfCoreLogradouroRepositoryBase(IDbContextProvider<TEfCoreDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<TLogradouro?> GetByCepAsync(int cep)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.Where(x => x.Cep == cep).FirstOrDefaultAsync();
        }

        public async Task<List<TLogradouro>> SearchByCidadeMunicipioIdAndNomeContainsAsync(Guid cidadeMunicipioId, string nomeContains)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.Where(x => x.CidadeMunicipioId == cidadeMunicipioId && x.Nome.Contains(nomeContains)).ToListAsync();
        }
    }
}
