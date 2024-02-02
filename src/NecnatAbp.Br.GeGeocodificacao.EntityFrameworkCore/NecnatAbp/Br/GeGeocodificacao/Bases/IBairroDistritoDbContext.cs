using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace NecnatAbp.Br.GeGeocodificacao.Bases
{
    public interface IBairroDistritoDbContext<TBairroDistrito, TCidadeMunicipio> : IEfCoreDbContext
        where TBairroDistrito : BairroDistritoBase<TCidadeMunicipio>
        where TCidadeMunicipio : CidadeMunicipioBase
    {
        DbSet<TBairroDistrito> BairrosDistritos { get; set; }
    }
}
