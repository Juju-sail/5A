import {Component, Input, OnInit} from '@angular/core';
import {Livre} from "../../dto/livre.dto";

@Component({
  selector: 'app-livre-table',
  templateUrl: './livre-table.component.html',
  styleUrls: ['./livre-table.component.css']
})
export class LivreTableComponent implements OnInit {

  @Input()
  public livres: Livre[] = [];

  constructor() { }

  public ngOnInit(): void {
  }

}
