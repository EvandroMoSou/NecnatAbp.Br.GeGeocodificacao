import { TestBed } from '@angular/core/testing';
import { GeGeocodificacaoService } from './services/ge-geocodificacao.service';
import { RestService } from '@abp/ng.core';

describe('GeGeocodificacaoService', () => {
  let service: GeGeocodificacaoService;
  const mockRestService = jasmine.createSpyObj('RestService', ['request']);
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [
        {
          provide: RestService,
          useValue: mockRestService,
        },
      ],
    });
    service = TestBed.inject(GeGeocodificacaoService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
