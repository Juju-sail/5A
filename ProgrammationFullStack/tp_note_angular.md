# Examen de la formation Angular

**Lisez bien l'énoncé avant de vous lancer.**

## Introduction

Le guide Michelin a décidé de mettre à jour son application web permettant de gérer les
restaurants visités et leur classement.

Grâce à vos compétences, vous avez été choisis pour effectuer cette tâche.

## Définitions

Un **restaurant** est caractérisé par :

- un identifiant unique (un nombre entier positif)
- Un nom (longueur max de 90 caractères)
- Une adresse (longueur max de 255 caractères)
- Une liste d'**évaluations**
- La moyenne de ses evaluations

Une **évaluation** est caractérisée par :

- un identifiant unique (un nombre entier positif)
- Le nom de l'évaluateur (longueur max de 50 caractères)
- Le commentaire (longueur max de 255 caractères)
- Le nombre d'étoiles recommandé (0,1,2 ou 3) appelée "note"

## Cahier des charges

L'application doit être constituée comme suit :

- Une page principale :

  - un tableau des **restaurants** avec, pour chaque :
    - son nom
    - son adresse
    - la moyenne du nombre d'étoiles recommandé pour ce restaurant (Si le restaurant n'a pas encore d'évaluation afficher "/" à la place)
    - un bouton permettant d'accéder à sa page de détails
    - les lignes dont le restaurant à un nombre d'étoiles recommandé moyen supérieur à 2 doivent s'afficher en jaune
    - les lignes dont le restaurant à un nombre d'étoiles recommandé moyen inférieur à 1 doivent s'afficher en rouge
    - Les lignes dont le restaurant n'a pas d'évaluation ne doivent pas être colorées
  - un formulaire permettant d'ajouter un **restaurant**
    - Nom : Obligatoire
    - Adresse (sur un seul champ) : Obligatoire

- Une page de détail (accessible depuis le tableau décrit précédemment) :
  - le nom du restaurant
  - son adresse
  - la liste de ses évaluations avec pour chaque :
    - L'auteur
    - Le commentaire
    - Le nombre d'étoiles
    - un bouton permettant de supprimer l'évaluation
  - un formulaire permettant d'ajouter une **évaluation** :
    - Nom: Obligatoire, 1 caractère minimum, 30 maximum
    - Commentaire : 255 caractères maximum
    - Nombre d'étoiles recommandé : Obligatoire, la valeur doit être 0, 1, 2 ou 3
  - un formulaire (identique au formulaire d'ajout) permettant d'éditer le restaurant

La liste initiale des **restaurants** doit être chargée via requête HTTP. Chaque changement sur un restaurant doit déclencher une requête HTTP appropriée :
POST pour l'ajout d'un nouveau restaurant, PUT pour une mise à jour.

#### Bonus

En vue d'améliorer la sécurité de son système d'information, le service CyberSecurité voudrait que vous **interceptiez** (ce mot est important) automatiquement
toutes les requêtes HTTP émises par l'application pour y ajouter le header :
`Authorization: SUPER_MOT_DE_PASSE_TOP_SECRET`

## Conseils supplémentaires

- Planifiez bien les tâches que vous devrez faire afin d'organiser au mieux vos dossiers et votre code dès le début.
- Regardez bien le nom des propriétés dans le backend
- Le style de l'application ne sera bien sûr pas noté. Vous serez évalué sur les concepts que vous implémenterez dans votre application, pas sur le CSS.
- Mieux vaut faire peu correctement que beaucoup salement.
- Vous ne faites pas du code seulement pour vous-même mais aussi pour qu'il puisse être compris par quelqu'un d'autre, notamment moi.
- Les commentaires expliquant ce que vous faites sont bien sûr les bienvenus.
- Vous avez accès à votre précédent travail et à internet.
- La question bonus est, comme son nom l'indique, un bonus. Ne la faites que si vous avez terminé tout le reste.
