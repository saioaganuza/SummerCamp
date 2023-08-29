import { Component } from '@angular/core';

@Component({
    selector: 'pm-monedas',
    templateUrl: './monedas-list.component.html'
})

export class MonedasComponent {
    pageTitle: string = "Lista de monedas";
    monedas: any[] = [
        {
          "codigo": "EUR",
          "nombre": "Euro",
          "simbolo": "fa fa-eur",
          "icono": 'assets/images/euro.png'
        },
        {
            "codigo": "USD",
            "nombre": "Dolar",
            "simbolo": 'fa fa-usd',
            "icono": 'assets/images/dolar.png'
        }
      ];

}