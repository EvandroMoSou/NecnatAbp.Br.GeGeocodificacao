using NecnatAbp.Br.GeGeocodificacao.Bases;

namespace NecnatAbp.Br.GeGeocodificacao
{
    public class PaisAppService : PaisAppServiceBase<Pais, PaisDto, CreateUpdatePaisDto, PaisResultRequestDto>,
        IPaisAppServiceBase<PaisDto, CreateUpdatePaisDto, PaisResultRequestDto>
    {
        public PaisAppService(IPaisRepositoryBase<Pais> repository) : base(repository)
        {
        }
    }
}
