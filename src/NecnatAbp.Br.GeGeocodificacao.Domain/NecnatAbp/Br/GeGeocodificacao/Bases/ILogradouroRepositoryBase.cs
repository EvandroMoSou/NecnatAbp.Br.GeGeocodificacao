using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public interface ILogradouroRepositoryBase<TBairroDistrito, TCidadeMunicipio, TLogradouro, TTipoLogradouro>
        : IRepository<TLogradouro, Guid>
        where TBairroDistrito : BairroDistritoBase<TCidadeMunicipio>
        where TCidadeMunicipio : CidadeMunicipioBase
        where TLogradouro : LogradouroBase<TBairroDistrito, TCidadeMunicipio, TTipoLogradouro>, new()
        where TTipoLogradouro : TipoLogradouroBase
    {
        Task<TLogradouro?> GetByCepAsync(int cep);
        Task<List<TLogradouro>> SearchByCidadeMunicipioIdAndNomeContainsAsync(Guid cidadeMunicipioId, string nomeContains);
    }
}
