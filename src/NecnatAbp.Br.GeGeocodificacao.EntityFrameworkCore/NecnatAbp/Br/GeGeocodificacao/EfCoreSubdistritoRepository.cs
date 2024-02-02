using NecnatAbp.Br.GeGeocodificacao.Bases;
using NecnatAbp.Br.GeGeocodificacao.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public class EfCoreSubdistritoRepository : EfCoreSubdistritoRepositoryBase<GeGeocodificacaoDbContext, BairroDistrito, CidadeMunicipio, Subdistrito>, ISubdistritoRepository
    {
        public EfCoreSubdistritoRepository(IDbContextProvider<GeGeocodificacaoDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
