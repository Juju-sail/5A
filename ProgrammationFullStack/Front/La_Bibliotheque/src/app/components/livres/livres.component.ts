import {Component, OnInit} from '@angular/core';
import {LivreFormeContent} from "../formulaire-add-livre/formulaire-add-livre.component";
import {Livre, LivreServiceService} from "../../services/livre-service.service";

@Component({
  selector: 'app-livres',
  templateUrl: './livres.component.html',
  styleUrls: ['./livres.component.css']
})
export class LivresComponent implements OnInit {

  public livres: Livre[] = [];

  constructor(private livreService: LivreServiceService) {
  }

  ngOnInit(): void {
  }

  public createLivre(data: LivreFormeContent): void{
    this.livreService.addLivre(data.titre).subscribe(
      {
        next: value => this.livres.push(value)
      }
    )
}}
