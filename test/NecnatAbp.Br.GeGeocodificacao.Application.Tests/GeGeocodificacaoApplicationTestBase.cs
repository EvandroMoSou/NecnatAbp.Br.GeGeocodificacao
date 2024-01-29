using Volo.Abp.Modularity;

namespace NecnatAbp.Br.GeGeocodificacao;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class GeGeocodificacaoApplicationTestBase<TStartupModule> : GeGeocodificacaoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
