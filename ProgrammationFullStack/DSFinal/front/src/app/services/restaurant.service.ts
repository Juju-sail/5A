import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {Observable} from "rxjs";
import {Restaurant} from "../dto/restaurant.dto";

@Injectable({
  providedIn: 'root'
})
export class RestaurantService {

  constructor(private httpClient: HttpClient) {

  }

  public getRestaurant(): Observable<Restaurant[]>{
    return this.httpClient.get<Restaurant[]>('http://localhost:8080/restaurants');
  }
}
