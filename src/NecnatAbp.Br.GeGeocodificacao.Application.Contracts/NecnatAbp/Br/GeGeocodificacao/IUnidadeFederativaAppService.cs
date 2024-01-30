using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public interface IUnidadeFederativaAppService : IApplicationService
    {
        Task<List<UnidadeFederativaDto>> GetAsync();
    }
}
