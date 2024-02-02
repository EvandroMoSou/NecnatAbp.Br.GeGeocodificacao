using System;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace NecnatAbp.Br.GeGeocodificacao.Bases
{
    public abstract class EfCoreTipoLogradouroRepositoryBase<TEfCoreDbContext, TTipoLogradouro>
        : EfCoreRepository<TEfCoreDbContext, TTipoLogradouro, Guid>,
        ITipoLogradouroRepositoryBase<TTipoLogradouro>,
        IRepository<TTipoLogradouro, Guid>
        where TTipoLogradouro : TipoLogradouroBase, new()
        where TEfCoreDbContext : ITipoLogradouroDbContext<TTipoLogradouro>
    {
        public EfCoreTipoLogradouroRepositoryBase(IDbContextProvider<TEfCoreDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
