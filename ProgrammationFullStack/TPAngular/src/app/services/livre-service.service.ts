import { Injectable } from '@angular/core';
import {Observable} from "rxjs";
import {HttpClient} from "@angular/common/http";

export interface Livre{
  id: number
  titre: string
}

@Injectable({
  providedIn: 'root'
})
export class LivreServiceService {

  constructor(private httpClient: HttpClient) { }

  public getLivre(): Observable<Livre[]> {
    return this.httpClient.get<Livre[]>('http://localhost:8080/livres')
  }
}
