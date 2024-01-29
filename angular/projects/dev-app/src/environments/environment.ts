import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'GeGeocodificacao',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44326/',
    redirectUri: baseUrl,
    clientId: 'GeGeocodificacao_App',
    responseType: 'code',
    scope: 'offline_access GeGeocodificacao',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44326',
      rootNamespace: 'NecnatAbp.Br.GeGeocodificacao',
    },
    GeGeocodificacao: {
      url: 'https://localhost:44338',
      rootNamespace: 'NecnatAbp.Br.GeGeocodificacao',
    },
  },
} as Environment;
