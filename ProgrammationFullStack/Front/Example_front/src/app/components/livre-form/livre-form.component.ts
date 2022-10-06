import {Component, EventEmitter, OnInit, Output} from '@angular/core';
import {NgForm} from "@angular/forms";

@Component({
  selector: 'app-livre-form',
  templateUrl: './livre-form.component.html',
  styleUrls: ['./livre-form.component.css']
})
export class LivreFormComponent implements OnInit {

  public titreInput: string = "";
  public auteurInput: string = "";

  @Output()
  public livreCreated: EventEmitter<LivreFormContent> = new EventEmitter();

  constructor() {
  }

  ngOnInit(): void {
  }

  public save(form: NgForm): void {

    if (form.valid) {
      this.livreCreated.emit({
        auteur: this.auteurInput,
        titre: this.titreInput
      });
    }
  }

}

export interface LivreFormContent {

  titre: string;
  auteur: string;

}
