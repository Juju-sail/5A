import {Component, EventEmitter, OnInit, Output} from '@angular/core';
import {NgForm} from '@angular/forms';


@Component({
  selector: 'app-formulaire-add-livre',
  templateUrl: './formulaire-add-livre.component.html',
  styleUrls: ['./formulaire-add-livre.component.css']
})


export class FormulaireAddLivreComponent implements OnInit {
  public nomVariable: string = "test"

  @Output()
  public livresCreated: EventEmitter<LivreFormeContent> = new EventEmitter();


  constructor() {

  }

  ngOnInit(): void {
  }

  mySubmitFonction(form: NgForm): void {
    if (form.valid) {
      console.log("form validé")
      this.livresCreated.emit({
          titre: this.nomVariable
        }
      )

    }
    else{
      console.log("coup dur")
    }
  }


}

export interface LivreFormeContent {
  titre: string;
}
