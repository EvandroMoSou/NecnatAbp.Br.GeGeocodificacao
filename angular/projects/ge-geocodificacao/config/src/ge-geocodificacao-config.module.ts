import { ModuleWithProviders, NgModule } from '@angular/core';
import { GE_GEOCODIFICACAO_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class GeGeocodificacaoConfigModule {
  static forRoot(): ModuleWithProviders<GeGeocodificacaoConfigModule> {
    return {
      ngModule: GeGeocodificacaoConfigModule,
      providers: [GE_GEOCODIFICACAO_ROUTE_PROVIDERS],
    };
  }
}
