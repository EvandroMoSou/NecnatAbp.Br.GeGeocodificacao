using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;


namespace NecnatAbp.Br.GeGeocodificacao.Bases
{
    public interface ICidadeMunicipioDbContext<TCidadeMunicipio> : IEfCoreDbContext
        where TCidadeMunicipio : CidadeMunicipioBase
    {
        DbSet<TCidadeMunicipio> CidadesMunicipios { get; set; }
    }
}
