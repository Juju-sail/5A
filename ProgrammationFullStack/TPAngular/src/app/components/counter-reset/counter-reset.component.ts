import {Component, EventEmitter, OnInit, Output} from '@angular/core';

@Component({
  selector: 'app-counter-reset',
  templateUrl: './counter-reset.component.html',
  styleUrls: ['./counter-reset.component.css']
})
export class CounterResetComponent implements OnInit {

  @Output('reset')
  public resetEvent: EventEmitter<number> = new EventEmitter<number>();

  constructor() {
  }

  ngOnInit(): void {
  }

  public reset(): void {
    this.resetEvent.emit(0);

  }
}
