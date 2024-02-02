using System;
using Volo.Abp.Domain.Repositories;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public interface ITipoLogradouroRepositoryBase<TTipoLogradouro>
        : IRepository<TTipoLogradouro, Guid>
        where TTipoLogradouro : TipoLogradouro
    {
    }
}
