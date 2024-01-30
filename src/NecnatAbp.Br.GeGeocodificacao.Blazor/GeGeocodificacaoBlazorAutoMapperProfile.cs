using AutoMapper;

namespace NecnatAbp.Br.GeGeocodificacao.Blazor;

public class GeGeocodificacaoBlazorAutoMapperProfile : Profile
{
    public GeGeocodificacaoBlazorAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<PaisDto, CreateUpdatePaisDto>();
    }
}