import { Component, OnInit } from '@angular/core';
import {Livre, LivreServiceService} from "../../services/livre-service.service";

@Component({
  selector: 'app-livre-table',
  templateUrl: './livre-table.component.html',
  styleUrls: ['./livre-table.component.css']
})
export class LivreTableComponent implements OnInit {

  public livres: Livre[] = [];

  ngOninit(): void {

  }

  constructor(private livreService: LivreServiceService) {

  }

  ngOnInit(): void {
    this.livres = this.livreService.getLivre();
  }

}
