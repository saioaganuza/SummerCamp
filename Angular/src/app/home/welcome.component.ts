import { Component } from "@angular/core";

@Component({
    selector: 'pm-welcome',
    template: `<div>{{saludo}}</div>
    <h2>{{codigomoneda}}</h2>`
})

export class WelcomeComponent {
    saludo: string = 'Holi holi';
    codigomoneda: string = "EUR";

}