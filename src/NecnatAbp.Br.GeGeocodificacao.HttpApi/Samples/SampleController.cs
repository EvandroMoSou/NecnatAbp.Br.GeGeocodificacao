using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;

namespace NecnatAbp.Br.GeGeocodificacao.Samples;

[Area(GeGeocodificacaoRemoteServiceConsts.ModuleName)]
[RemoteService(Name = GeGeocodificacaoRemoteServiceConsts.RemoteServiceName)]
[Route("api/GeGeocodificacao/sample")]
public class SampleController : GeGeocodificacaoController, ISampleAppService
{
    private readonly ISampleAppService _sampleAppService;

    public SampleController(ISampleAppService sampleAppService)
    {
        _sampleAppService = sampleAppService;
    }

    [HttpGet]
    public async Task<SampleDto> GetAsync()
    {
        return await _sampleAppService.GetAsync();
    }

    [HttpGet]
    [Route("authorized")]
    [Authorize]
    public async Task<SampleDto> GetAuthorizedAsync()
    {
        return await _sampleAppService.GetAsync();
    }
}
