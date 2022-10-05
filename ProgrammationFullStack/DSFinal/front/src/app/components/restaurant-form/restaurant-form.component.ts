import {Component, EventEmitter, OnInit, Output} from '@angular/core';
import {NgForm} from "@angular/forms";
import {EvaluationComponent} from "../evaluation/evaluation.component";

@Component({
  selector: 'app-restaurant-form',
  templateUrl: './restaurant-form.component.html',
  styleUrls: ['./restaurant-form.component.css']
})
export class RestaurantFormComponent implements OnInit {

  public nomInput: string = "";
  public adressInput: string = "";
  public nbEtoiles: number = 0;
  public evaluations: EvaluationComponent[] = [];

  @Output()
  public restaurantCreated: EventEmitter<RestaurantFormContent> = new EventEmitter();

  constructor() {
  }

  ngOnInit(): void {
  }

  public save(form: NgForm): void {
    if (form.valid) {
      console.log("resto valid")
      this.restaurantCreated.emit({
        nom: this.nomInput,
        adress: this.adressInput,
        nbEtoiles: this.nbEtoiles,
        evaluations: this.evaluations
      });
    }
  }

}

export interface RestaurantFormContent {
  nom: string;
  adress: string;
  nbEtoiles: number;
  evaluations: EvaluationComponent[];
}
