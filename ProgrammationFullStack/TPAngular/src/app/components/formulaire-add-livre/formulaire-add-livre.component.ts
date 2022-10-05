import {Component, OnInit} from '@angular/core';
import {NgForm} from '@angular/forms';


@Component({
  selector: 'app-formulaire-add-livre',
  templateUrl: './formulaire-add-livre.component.html',
  styleUrls: ['./formulaire-add-livre.component.css']
})


export class FormulaireAddLivreComponent implements OnInit {
  public nomVariable: String = "..."

  constructor() {

  }

  ngOnInit(): void {
  }

  mySubmitFonction(form: NgForm): void {
    if (form.valid) {
      console.log("form validé")
    }
  }


}
