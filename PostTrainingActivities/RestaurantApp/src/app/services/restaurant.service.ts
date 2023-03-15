import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Restaurant } from '../classes/restaurant';

@Injectable({
  providedIn: 'root'
})
export class RestaurantService {

  private url: string = "https://localhost:7192/api/";

  constructor(private http: HttpClient) { }


  getRestaurants() {
    return this.http.get<Restaurant>(`${this.url}Restaurants`);
  }





}
