import {Component, OnInit} from '@angular/core';
import {EvaluationService} from "../../services/evaluation.service";

@Component({
  selector: 'app-evaluation',
  templateUrl: './evaluation.component.html',
  styleUrls: ['./evaluation.component.css']
})
export class EvaluationComponent implements OnInit {
  public evaluations : EvaluationComponent[] = [];
  public auteur: string = ""
  public commentaire: string = ""
  public nbEtoiles: number = 0

  constructor(private evaluationService: EvaluationService) {
  }

  ngOnInit(): void {
  }

  public createEvaluation(auteur: string, commentaire: string, nbEtoiles: number): void{
    this.evaluationService.createEval(auteur, commentaire, nbEtoiles).subscribe({
      next: value => this.evaluations.push(value)
    })
  }
}
