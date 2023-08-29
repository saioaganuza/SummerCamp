import { Component } from '@angular/core';

@Component({
  selector: 'pm-root',
  template: `
  <div><h1>{{pageTitle}}</h1>
      <div>Listado de monedas</div>
      <pm-monedas></pm-monedas>
  </div>
  `
})
export class AppComponent {
  pageTitle = 'Conversor';
}