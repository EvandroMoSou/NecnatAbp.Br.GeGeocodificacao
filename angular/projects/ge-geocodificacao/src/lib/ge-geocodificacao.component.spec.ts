import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';
import { GeGeocodificacaoComponent } from './components/ge-geocodificacao.component';
import { GeGeocodificacaoService } from '@necnat-abp.Br/ge-geocodificacao';
import { of } from 'rxjs';

describe('GeGeocodificacaoComponent', () => {
  let component: GeGeocodificacaoComponent;
  let fixture: ComponentFixture<GeGeocodificacaoComponent>;
  const mockGeGeocodificacaoService = jasmine.createSpyObj('GeGeocodificacaoService', {
    sample: of([]),
  });
  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [GeGeocodificacaoComponent],
      providers: [
        {
          provide: GeGeocodificacaoService,
          useValue: mockGeGeocodificacaoService,
        },
      ],
    }).compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GeGeocodificacaoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
