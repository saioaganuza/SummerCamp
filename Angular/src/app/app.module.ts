import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { WelcomeComponent } from './home/welcome.component';
import { MonedasComponent } from './monedas/monedas.component';
import { ProductListComponent } from './products/product-list.component';


@NgModule({
  declarations: [
    AppComponent,
    WelcomeComponent,
    MonedasComponent,
    ProductListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
