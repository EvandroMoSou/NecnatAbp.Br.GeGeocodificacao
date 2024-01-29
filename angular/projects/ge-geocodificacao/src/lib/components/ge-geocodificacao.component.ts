import { Component, OnInit } from '@angular/core';
import { GeGeocodificacaoService } from '../services/ge-geocodificacao.service';

@Component({
  selector: 'lib-ge-geocodificacao',
  template: ` <p>ge-geocodificacao works!</p> `,
  styles: [],
})
export class GeGeocodificacaoComponent implements OnInit {
  constructor(private service: GeGeocodificacaoService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
