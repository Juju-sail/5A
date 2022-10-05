import {Injectable} from '@angular/core';
import {Observable} from "rxjs";
import {Livre} from "../dto/livre.dto";
import {HttpClient} from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class LivreService {

  constructor(private httpClient: HttpClient) {
  }

  public getLivres(): Observable<Livre[]> {
    return this.httpClient.get<Livre[]>(`http://localhost:8080/livres`);
  }

  public createLivre(titre: string): Observable<Livre> {
    return this.httpClient.post<Livre>(`http://localhost:8080/livres`, {titre: titre})
  }

}
