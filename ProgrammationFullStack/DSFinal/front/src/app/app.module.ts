import {NgModule} from '@angular/core';
import {BrowserModule} from '@angular/platform-browser';

import {AppRoutingModule} from './app-routing.module';
import {AppComponent} from './app.component';
import {RestaurantComponent} from './components/restaurant/restaurant.component';
import {HttpClientModule} from "@angular/common/http";
import {RestaurantTableComponent} from './components/restaurant-table/restaurant-table.component';
import {RestaurantFormComponent} from './components/restaurant-form/restaurant-form.component';
import {FormsModule} from "@angular/forms";
import {EvaluationComponent} from './components/evaluation/evaluation.component';

@NgModule({
  declarations: [
    AppComponent,
    RestaurantComponent,
    RestaurantTableComponent,
    RestaurantFormComponent,
    EvaluationComponent
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
