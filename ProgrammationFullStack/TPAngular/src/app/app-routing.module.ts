import {NgModule} from '@angular/core';
import {RouterModule, Routes} from '@angular/router';
import {HomeComponent} from "./components/home/home.component";
import {LivresComponent} from "./components/livres/livres.component";
import {FormulaireAddLivreComponent} from "./components/formulaire-add-livre/formulaire-add-livre.component";

const routes: Routes = [
  {path: '', component: HomeComponent},
  {path: 'livres', component: LivresComponent},
  {path: 'form', component: FormulaireAddLivreComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {
}
