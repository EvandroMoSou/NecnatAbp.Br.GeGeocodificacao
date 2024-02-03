using NecnatAbp.Br.GeGeocodificacao.EntityFrameworkCore;
using System;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public class EfCoreTipoLogradouroRepository : EfCoreRepository<GeGeocodificacaoDbContext, TipoLogradouro, Guid>, ITipoLogradouroRepository
    {
        public EfCoreTipoLogradouroRepository(IDbContextProvider<GeGeocodificacaoDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
