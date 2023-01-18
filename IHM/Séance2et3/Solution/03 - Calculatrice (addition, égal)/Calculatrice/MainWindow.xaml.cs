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

namespace Calculatrice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _saisie;
        private    int _resultat;
        private   bool _plus;

        public MainWindow()
        {
            InitializeComponent();

            _saisie   = null;
            _resultat = 0;
            _plus     = false;
        }

        private void ChiffreButton_Click(object sender, RoutedEventArgs e)
        {
            Button bt      = (Button)sender;
            string chiffre = (string)bt.Content;

            if (_saisie == null || _saisie == "0")
            {
                _saisie = chiffre;
            }
            else
            {
                _saisie = _saisie + chiffre;
            }

            _tb.Text = _saisie;
        }

        private void OperateurButton_Click(object sender, RoutedEventArgs e)
        {
            Button bt        = (Button)sender;
            string operateur = (string)bt.Content;

            // Calcul de la dernière opération.
            if (_saisie != null)
            {
                if (!_plus)
                {
                    _resultat = int.Parse(_saisie);
                }
                else
                {
                    _resultat = _resultat + int.Parse(_saisie);
                }
            }

            switch (operateur)
            {
                case "=":
                    _plus = false;                   
                    break;

                case "+":
                    _plus = true;
                    break;
            }

            _saisie  = null;
            _tb.Text = _resultat.ToString();
        }
    }
}
