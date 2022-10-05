import {Component, EventEmitter, OnInit, Output} from '@angular/core';
import {NgForm} from "@angular/forms";

@Component({
  selector: 'app-restaurant-form',
  templateUrl: './restaurant-form.component.html',
  styleUrls: ['./restaurant-form.component.css']
})
export class RestaurantFormComponent implements OnInit {

  public nomInput: string = "";
  public adressInput: string = "";

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
        adress: this.adressInput
      });
    }
  }

}

export interface RestaurantFormContent {
  nom: string;
  adress: string;
}
