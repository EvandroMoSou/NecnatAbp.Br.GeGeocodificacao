import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { GeGeocodificacaoComponent } from './components/ge-geocodificacao.component';
import { GeGeocodificacaoRoutingModule } from './ge-geocodificacao-routing.module';

@NgModule({
  declarations: [GeGeocodificacaoComponent],
  imports: [CoreModule, ThemeSharedModule, GeGeocodificacaoRoutingModule],
  exports: [GeGeocodificacaoComponent],
})
export class GeGeocodificacaoModule {
  static forChild(): ModuleWithProviders<GeGeocodificacaoModule> {
    return {
      ngModule: GeGeocodificacaoModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<GeGeocodificacaoModule> {
    return new LazyModuleFactory(GeGeocodificacaoModule.forChild());
  }
}
