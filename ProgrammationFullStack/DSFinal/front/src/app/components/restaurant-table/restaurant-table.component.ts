import {Component, Input, OnInit} from '@angular/core';
import {Restaurant} from "../../dto/restaurant.dto";
import {Router} from "@angular/router";

@Component({
  selector: 'app-restaurant-table',
  templateUrl: './restaurant-table.component.html',
  styleUrls: ['./restaurant-table.component.css']
})
export class RestaurantTableComponent implements OnInit {

  @Input()
  public restaurants: Restaurant[] = [];

  constructor(private router: Router) {
  }

  ngOnInit(): void {
  }

  public navigateToDetails(id: number) {
    this.router.navigate(['restaurants/' + id])
  }
}
