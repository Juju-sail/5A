import {Component, Input, OnInit} from '@angular/core';
import {Restaurant} from "../../dto/restaurant.dto";

@Component({
  selector: 'app-restaurant-table',
  templateUrl: './restaurant-table.component.html',
  styleUrls: ['./restaurant-table.component.css']
})
export class RestaurantTableComponent implements OnInit {

  @Input()
  public restaurants: Restaurant[] = [];

  constructor() {
  }

  ngOnInit(): void {
  }

}
