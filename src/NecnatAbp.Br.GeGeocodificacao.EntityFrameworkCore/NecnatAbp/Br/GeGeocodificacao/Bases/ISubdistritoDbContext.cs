using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace NecnatAbp.Br.GeGeocodificacao.Bases
{
    public interface ISubdistritoDbContext<TBairroDistrito, TCidadeMunicipio, TSubdistrito> : IEfCoreDbContext
        where TBairroDistrito : BairroDistritoBase<TCidadeMunicipio>
        where TCidadeMunicipio : CidadeMunicipioBase
        where TSubdistrito : SubdistritoBase<TBairroDistrito, TCidadeMunicipio>
    {
        DbSet<TSubdistrito> Subdistritos { get; set; }
    }
}
