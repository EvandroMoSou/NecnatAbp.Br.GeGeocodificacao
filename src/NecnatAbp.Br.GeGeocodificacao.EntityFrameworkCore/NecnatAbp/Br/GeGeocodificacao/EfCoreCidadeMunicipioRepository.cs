using NecnatAbp.Br.GeGeocodificacao.Bases;
using NecnatAbp.Br.GeGeocodificacao.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public class EfCoreCidadeMunicipioRepository : EfCoreCidadeMunicipioRepositoryBase<GeGeocodificacaoDbContext, CidadeMunicipio>, ICidadeMunicipioRepository
    {
        public EfCoreCidadeMunicipioRepository(IDbContextProvider<GeGeocodificacaoDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
