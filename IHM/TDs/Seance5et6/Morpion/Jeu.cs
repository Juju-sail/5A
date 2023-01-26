using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class Jeu
{
    public Dictionary<bool, String> etat = new Dictionary<bool, String>(){
            {true, "X"},
            {false, "O"}
    };
    public String _symbole;

    public Jeu()
	{
        /* ------------- Déroulement jeu : -------------
             * 
             * J1 click sur un bouton de la grille (position : i,j)
             * Appel méthode BoutonVide(i,j).
             * Si True, son contenu se change en X
             * 
             * Appel méthode Verification_ligne(X)
             * Si vrai {
             *  Appel méthode Gagnant(X)
             * }
             * 
             * J2 click sur un bouton de la grille (position : i,j)
             * Appel méthode BoutonVide(i,j).
             * Si True, son contenu se change en O
             * 
             * Appel méthode Verification_ligne(O)
             * Si vrai {
             *  Appel méthode Gagnant(O)
             * }
             * 
             * 
             * ------------- Méthodes utilisées : ------------------
             * 
             * BoutonVide(i, j){
             *  Regarder content bouton en postion i, j
             *  Si != null {
             *      return False
             *  }
             *  Sinon
             *      return True
             * }
             * 
             * ____________________________
             * 
             * Verification_ligne(etat){
             *  Sur la ligne 1 à 3, recuperer le content de chaque bouton.
             *  Si ils sont tous identique à l'état,
             *      return True
             *  Sur la colone 1 à 3, recuperer le content de chque bouton.
             *  Si ils sont tous identiques à l'état,
             *      return True
             *  Recuperer les contents de chquae bouton des position i=j.
             *  Si ils sont tous identiques à l'état,
             *      return True
             *  Recuper les content de chaque bouton des position i = 3-j.
             *  Si ils sont tous identiques à l'état,
             *      return True
             *  Sinon 
             *      return False
             *  
             * }
             * 
             * ____________________________
             * 
             * Gagnant(etat){
             *  Si etat = X 
             *      return J1 gagné
             *      Fin du jeu
             *  Sinon, Si etat = O
             *      return J2 gagné
             *      Fin du jeu
             *  Sinon,
             *      return "le jeu continue"
             * 
             * }
             * 
             * 
             */


        
    }

    public bool BoutonVide(Bouton bouton)
    {
        if (bouton._contenu != "") // Si bouton utilisé (contenu non vide)
        {
            return false;
        }
        else
        {
            return true; // bouton dispo
        }
    }

    public void Coche(bool joueur, Bouton bouton)
    {
        BoutonVide(bouton); // retourne true si le bouton est vide

        if (joueur)
        {
            // changer contenu du bouton en X (J1)
        }
        else
        {
            // changer contenu du bouton en O (J2)
        }
    }

    public bool Verification(bool joueur)
    {
        _symbole = etat[joueur];

        // Parcours Grille :

        //Sur la ligne 1 à 3
        //Sur la colone 1 à 3
        //i = j 
        //i = 3-j

        // Pour les 4 situation :
        // Recuperer le contenu des boutons
        // Verifier si ils sont tous identiques à symbole,
        // Si oui, alors return true
        return true;

    }

    public void Gagnant(bool joueur)
    {
        if(Verification(joueur))
        {
            if(_symbole == "X")
            {
                // J1 a gagné
            }
            else if (_symbole == "O")
            {
                // J2 a gagné
            }
            // fin du jeu
        }
    }



}
