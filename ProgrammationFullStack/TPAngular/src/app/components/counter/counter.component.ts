import {Component, EventEmitter, Input, OnInit, Output} from '@angular/core';

@Component({
  selector: 'app-counter',
  templateUrl: './counter.component.html',
  styleUrls: ['./counter.component.css']
})
export class CounterComponent implements OnInit {

  @Input()
  public valeurCompteurFils: number =0;

  @Output('increment')
  public incrementEvent: EventEmitter<void> = new EventEmitter<void>();

  @Output('decrement')
  public decrementEvent: EventEmitter<void> = new EventEmitter<void>();

  constructor() { }

  ngOnInit(): void {
  }

  public incrementCounter(): void{
    this.incrementEvent.emit();
  }
  public decrementCounter(): void{
    this.decrementEvent.emit();
  }



}
