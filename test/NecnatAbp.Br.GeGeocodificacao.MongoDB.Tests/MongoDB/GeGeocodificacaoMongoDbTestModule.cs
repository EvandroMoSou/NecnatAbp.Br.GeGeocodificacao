using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;
using Volo.Abp.Uow;

namespace NecnatAbp.Br.GeGeocodificacao.MongoDB;

[DependsOn(
    typeof(GeGeocodificacaoApplicationTestModule),
    typeof(GeGeocodificacaoMongoDbModule)
)]
public class GeGeocodificacaoMongoDbTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDbConnectionOptions>(options =>
        {
            options.ConnectionStrings.Default = MongoDbFixture.GetRandomConnectionString();
        });
    }
}
