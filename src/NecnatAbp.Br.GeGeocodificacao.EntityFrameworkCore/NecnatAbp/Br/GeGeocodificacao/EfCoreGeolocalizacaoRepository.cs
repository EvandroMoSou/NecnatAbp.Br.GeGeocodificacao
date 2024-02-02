using NecnatAbp.Br.GeGeocodificacao.Bases;
using NecnatAbp.Br.GeGeocodificacao.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public class EfCoreGeolocalizacaoRepository : EfCoreGeolocalizacaoRepositoryBase<GeGeocodificacaoDbContext, BairroDistrito, CidadeMunicipio, Geolocalizacao, Logradouro, TipoLogradouro>, IGeolocalizacaoRepository
    {
        public EfCoreGeolocalizacaoRepository(IDbContextProvider<GeGeocodificacaoDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
