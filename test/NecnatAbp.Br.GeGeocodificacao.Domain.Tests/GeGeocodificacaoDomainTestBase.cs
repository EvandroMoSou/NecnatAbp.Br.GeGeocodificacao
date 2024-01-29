using Volo.Abp.Modularity;

namespace NecnatAbp.Br.GeGeocodificacao;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class GeGeocodificacaoDomainTestBase<TStartupModule> : GeGeocodificacaoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
