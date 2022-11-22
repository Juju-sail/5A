import {NgModule} from '@angular/core';
import {RouterModule, Routes} from '@angular/router';
import {LivreComponent} from "./pages/livre/livre.component";

const routes: Routes = [
  {
    path: '', redirectTo: 'livres', pathMatch: "full"
  },
  {
    path: 'livres', component: LivreComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {
}
