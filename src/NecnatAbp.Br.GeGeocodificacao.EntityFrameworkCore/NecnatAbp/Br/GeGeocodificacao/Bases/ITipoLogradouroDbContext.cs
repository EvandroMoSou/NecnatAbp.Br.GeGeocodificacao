using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace NecnatAbp.Br.GeGeocodificacao.Bases
{
    public interface ITipoLogradouroDbContext<TTipoLogradouro> : IEfCoreDbContext
        where TTipoLogradouro : TipoLogradouroBase
    {
        DbSet<TTipoLogradouro> TiposLogradouro { get; set; }
    }
}
