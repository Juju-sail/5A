import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CounterComponent } from './counter/counter.component';
import { CounterResetComponent } from './counter-reset/counter-reset.component';
import { RandomCounterComponent } from './random-counter/random-counter.component';
import { DirectivePaireBleuDirective } from './directive/directive-paire-bleu.directive';
import { LivreTableComponent } from './livre-table/livre-table.component';
import { HomeComponent } from './home/home.component';
import { LivresComponent } from './livres/livres.component';

@NgModule({
  declarations: [
    AppComponent,
    CounterComponent,
    CounterResetComponent,
    RandomCounterComponent,
    DirectivePaireBleuDirective,
    LivreTableComponent,
    HomeComponent,
    LivresComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
