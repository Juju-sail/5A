import {Component, EventEmitter, Input, OnInit, Output} from '@angular/core';

@Component({
  selector: 'app-random-counter',
  templateUrl: './random-counter.component.html',
  styleUrls: ['./random-counter.component.css']
})
export class RandomCounterComponent implements OnInit {
  @Input()
  public valeurCompteur: number =0;

  @Output('valeurCompteurChange')
  public valeurCompteurChangeEvent: EventEmitter<number> = new EventEmitter<number>();

  constructor() { }

  ngOnInit(): void {
  }

  public setCounterToRandom(): void{
    this.valeurCompteur = Math.random() * 100;
    this.valeurCompteurChangeEvent.emit(this.valeurCompteur);
  }
}
