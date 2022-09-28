import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {HomeComponent} from "./components/home/home.component";
import {LivresComponent} from "./components/livres/livres.component";

const routes: Routes = [
  {path: '', component: HomeComponent},
  {path: 'livres', component: LivresComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
