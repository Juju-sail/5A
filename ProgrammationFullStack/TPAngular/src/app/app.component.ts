import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  public valeurCompteurPere: number = 0;
  title = 'TPAngular';

  public incrementCounter(): void{
    this.valeurCompteurPere ++ ;
    console.log(this.valeurCompteurPere)
  }
  public decrementCounter(): void{
    this.valeurCompteurPere --;
    console.log(this.valeurCompteurPere)
  }

  public resetCounter(newValue: number){
    this.valeurCompteurPere = newValue;
  }
}
