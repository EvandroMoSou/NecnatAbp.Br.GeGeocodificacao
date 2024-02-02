using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace NecnatAbp.Br.GeGeocodificacao.Bases
{
    public interface ILogradouroDbContext<TBairroDistrito, TCidadeMunicipio, TLogradouro, TTipoLogradouro> : IEfCoreDbContext
        where TBairroDistrito : BairroDistritoBase<TCidadeMunicipio>
        where TCidadeMunicipio : CidadeMunicipioBase
        where TLogradouro : LogradouroBase<TBairroDistrito, TCidadeMunicipio, TTipoLogradouro>
        where TTipoLogradouro : TipoLogradouroBase
    {
        DbSet<TLogradouro> Logradouros { get; set; }
    }
}
