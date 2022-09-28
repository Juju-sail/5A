import { Injectable } from '@angular/core';

export interface Livre{
  id: number
  titre: string
}

@Injectable({
  providedIn: 'root'
})
export class LivreServiceService {

  constructor() { }

  public getLivre(): Livre[] {
    return [{id : 0, titre: "hg"}, {id: 1, titre: "divgt"}]
  }
}
