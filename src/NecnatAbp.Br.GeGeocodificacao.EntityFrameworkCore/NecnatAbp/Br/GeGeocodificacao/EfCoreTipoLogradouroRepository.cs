using NecnatAbp.Br.GeGeocodificacao.Bases;
using NecnatAbp.Br.GeGeocodificacao.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public class EfCoreTipoLogradouroRepository : EfCoreTipoLogradouroRepositoryBase<GeGeocodificacaoDbContext, TipoLogradouro>, ITipoLogradouroRepository
    {
        public EfCoreTipoLogradouroRepository(IDbContextProvider<GeGeocodificacaoDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
