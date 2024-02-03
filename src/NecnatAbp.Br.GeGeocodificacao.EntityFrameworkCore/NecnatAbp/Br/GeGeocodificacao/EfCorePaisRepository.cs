using NecnatAbp.Br.GeGeocodificacao.Bases;
using NecnatAbp.Br.GeGeocodificacao.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public class EfCorePaisRepository : EfCorePaisRepositoryBase<GeGeocodificacaoDbContext, Pais>, IPaisRepository
    {
        public EfCorePaisRepository(IDbContextProvider<GeGeocodificacaoDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
