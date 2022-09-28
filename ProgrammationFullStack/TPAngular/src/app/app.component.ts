import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  public valeurCompteurPere: number = 0;
  title = 'TPAngular';
  public compteurArray: number[] = []

  public incrementCounter(): void{
    this.valeurCompteurPere ++ ;
    console.log(this.valeurCompteurPere)
    this.calculArray()
  }
  public decrementCounter(): void{
    this.valeurCompteurPere --;
    console.log(this.valeurCompteurPere)
    this.calculArray()
  }

  public resetCounter(newValue: number){
    this.valeurCompteurPere = newValue;
    this.calculArray()
  }

  private calculArray(): void{
    this.compteurArray = []
    for (let i = 0; i < this.valeurCompteurPere; i++) {
      this.compteurArray.push(i);
    }
  }

}
