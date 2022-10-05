import {Component, OnInit} from '@angular/core';
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

  public ngOnInit(): void {
    console.log(1)
    this.livreService.getLivre().subscribe(value => {
      console.log(2)
      this.livres = value
    })
    console.log(3)
  }

}
