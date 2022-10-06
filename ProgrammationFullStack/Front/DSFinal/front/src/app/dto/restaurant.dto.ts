import {EvaluationComponent} from "../components/evaluation/evaluation.component";

export interface Restaurant {
  id: number;
  nom: string;
  adresse: string;
  moyenne: number;
  evaluations: EvaluationComponent[];
}

