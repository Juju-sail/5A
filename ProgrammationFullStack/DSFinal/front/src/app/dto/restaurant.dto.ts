import {EvaluationComponent} from "../components/evaluation/evaluation.component";

export interface Restaurant {
  nom: string;
  adresse: string;
  moyenne: number;
  evaluations: EvaluationComponent[];
}

