import {NgModule} from '@angular/core';
import {BrowserModule} from '@angular/platform-browser';

import {AppRoutingModule} from './app-routing.module';
import {AppComponent} from './app.component';
import {CounterComponent} from './components/counter/counter.component';
import {CounterResetComponent} from './components/counter-reset/counter-reset.component';
import {RandomCounterComponent} from './components/random-counter/random-counter.component';
import {DirectivePaireBleuDirective} from './directive/directive-paire-bleu.directive';
import {LivreTableComponent} from './components/livre-table/livre-table.component';
import {HomeComponent} from './components/home/home.component';
import {LivresComponent} from './components/livres/livres.component';
import {HttpClientModule} from "@angular/common/http";
import {FormulaireAddLivreComponent} from './components/formulaire-add-livre/formulaire-add-livre.component';
import {FormsModule} from "@angular/forms";


@NgModule({
  declarations: [
    AppComponent,
    CounterComponent,
    CounterResetComponent,
    RandomCounterComponent,
    DirectivePaireBleuDirective,
    LivreTableComponent,
    HomeComponent,
    LivresComponent,
    FormulaireAddLivreComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {
}
