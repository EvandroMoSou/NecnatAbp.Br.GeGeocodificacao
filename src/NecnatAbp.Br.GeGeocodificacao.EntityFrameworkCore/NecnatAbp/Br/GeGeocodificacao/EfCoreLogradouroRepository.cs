using NecnatAbp.Br.GeGeocodificacao.Bases;
using NecnatAbp.Br.GeGeocodificacao.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public class EfCoreLogradouroRepository : EfCoreLogradouroRepositoryBase<GeGeocodificacaoDbContext, BairroDistrito, CidadeMunicipio, Logradouro, TipoLogradouro>, ILogradouroRepository
    {
        public EfCoreLogradouroRepository(IDbContextProvider<GeGeocodificacaoDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
