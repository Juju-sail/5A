import {Component, OnInit} from '@angular/core';
import {Restaurant} from "../../dto/restaurant.dto";
import {RestaurantService} from "../../services/restaurant.service";
import {RestaurantFormContent} from "../restaurant-form/restaurant-form.component";

@Component({
  selector: 'app-restaurant',
  templateUrl: './restaurant.component.html',
  styleUrls: ['./restaurant.component.css']
})
export class RestaurantComponent implements OnInit {

  public restaurants: Restaurant[] = [];

  constructor(private restaurantService: RestaurantService) {
  }

  public ngOnInit(): void {
    this.restaurantService.getRestaurant().subscribe({
      next: restaurants => this.restaurants = restaurants
    })
  }

  public createRestaurant(restaurant: RestaurantFormContent): void {
    this.restaurantService.createRestaurant(restaurant.nom, restaurant.adress).subscribe({
      next: value => this.restaurants.push(value)
    })
  }

}
