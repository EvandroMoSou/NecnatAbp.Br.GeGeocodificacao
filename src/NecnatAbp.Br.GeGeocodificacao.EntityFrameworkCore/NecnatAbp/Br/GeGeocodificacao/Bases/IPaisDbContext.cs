using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace NecnatAbp.Br.GeGeocodificacao.Bases
{
    public interface IPaisDbContext<TPais> : IEfCoreDbContext
        where TPais : PaisBase
    {
        DbSet<TPais> Paises { get; set; }
    }
}
