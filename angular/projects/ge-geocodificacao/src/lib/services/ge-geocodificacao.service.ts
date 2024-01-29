import { Injectable } from '@angular/core';
import { RestService } from '@abp/ng.core';

@Injectable({
  providedIn: 'root',
})
export class GeGeocodificacaoService {
  apiName = 'GeGeocodificacao';

  constructor(private restService: RestService) {}

  sample() {
    return this.restService.request<void, any>(
      { method: 'GET', url: '/api/GeGeocodificacao/sample' },
      { apiName: this.apiName }
    );
  }
}
