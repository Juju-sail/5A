import {Component, OnInit} from '@angular/core';
import {Livre} from "../../dto/livre.dto";
import {LivreService} from "../../services/livre.service";
import {LivreFormContent} from "../../components/livre-form/livre-form.component";

@Component({
  selector: 'app-livre',
  templateUrl: './livre.component.html',
  styleUrls: ['./livre.component.css']
})
export class LivreComponent implements OnInit {

  public livres: Livre[] = [];

  constructor(private livreService: LivreService) {
  }

  public ngOnInit(): void {
    this.livreService.getLivres().subscribe({
      next: livres => this.livres = livres
    })
  }

  public createLivre(livre: LivreFormContent): void {
    this.livreService.createLivre(livre.titre).subscribe({
      next: value => this.livres.push(value)
    })
  }

}
