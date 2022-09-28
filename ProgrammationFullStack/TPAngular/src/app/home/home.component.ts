import { Component, OnInit } from '@angular/core';
import {Router} from "@angular/router";

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

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

  constructor(private router: Router) {

  }


  ngOnInit(): void {
  }

}
