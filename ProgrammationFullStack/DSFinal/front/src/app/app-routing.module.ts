import {NgModule} from '@angular/core';
import {RouterModule, Routes} from '@angular/router';
import {RestaurantComponent} from "./components/restaurant/restaurant.component";
import {DetailRestaurantComponent} from "./components/detail-restaurant/detail-restaurant.component";

const routes: Routes = [
  {path: '', redirectTo: 'restaurants', pathMatch: "full"},
  {path: 'restaurants', component: RestaurantComponent},
  {path: 'restaurants/:id', component: DetailRestaurantComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {
}
