export interface Livre {

  id: number;
  titre: string;
  commentaires: Commentaire[];

}

export interface Commentaire {

  id: number;
  message: string;

}
