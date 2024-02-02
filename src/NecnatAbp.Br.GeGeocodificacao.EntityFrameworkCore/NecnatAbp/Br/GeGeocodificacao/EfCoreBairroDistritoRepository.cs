using NecnatAbp.Br.GeGeocodificacao.Bases;
using NecnatAbp.Br.GeGeocodificacao.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public class EfCoreBairroDistritoRepository : EfCoreBairroDistritoRepositoryBase<GeGeocodificacaoDbContext, BairroDistrito, CidadeMunicipio>, IBairroDistritoRepository
    {
        public EfCoreBairroDistritoRepository(IDbContextProvider<GeGeocodificacaoDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
