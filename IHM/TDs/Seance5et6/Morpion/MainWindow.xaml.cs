using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Morpion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool _joueur; // false = J1 && true = J2

        public MainWindow()
        {
            InitializeComponent();




        }

        public void bouton() // Methode qui réagit au click d'un des boutons de la grille
        {
            Bouton myBouton= new Bouton();

            /* il faut :
             * Recuperer la colone
             * Recuperer la ligne
             * Recuperer le contenu
             * 
             * Et les mettre dans un objet Bouton
             * 
             */

            myBouton._i = 1;
            myBouton._j = 1;
            myBouton._contenu = "";

            // Appel méthode coche

            // appel méthode Gagnant

            // Pour appeller ces deux méthodes, il faut savoir quel joueur joue...

        }


        

    }
    


}
