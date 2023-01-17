using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public int _saisie;
        public int _operateur = 0;
        public int _result = 0;
        public int _calcul;
        public int _tailleAffichage;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Generate1(object sender, RoutedEventArgs e)
        {
            Result.Text += "1";
        }
        private void Generate2(object sender, RoutedEventArgs e)
        {
            Result.Text += "2";
        }
        private void Generate3(object sender, RoutedEventArgs e)
        {
            Result.Text += "3";
        }
        private void Generate4(object sender, RoutedEventArgs e)
        {
            Result.Text += "4";
        }
        private void Generate5(object sender, RoutedEventArgs e)
        {
            Result.Text += "5";
        }
        private void Generate6(object sender, RoutedEventArgs e)
        {
            Result.Text += "6";
        }
        private void Generate7(object sender, RoutedEventArgs e)
        {
            Result.Text += "7";
        }
        private void Generate8(object sender, RoutedEventArgs e)
        {
            Result.Text += "8";
        }
        private void Generate9(object sender, RoutedEventArgs e)
        {
            Result.Text += "9";
        }
        private void Generate0(object sender, RoutedEventArgs e)
        {
            Result.Text += "0";
        }
        
        private void sum(object sender, RoutedEventArgs e)
        {
            _result = int.Parse(Result.Text);
            Result.Text = "";
            _operateur = 1;
        }
        private void substract(object sender, RoutedEventArgs e)
        {
            _result = int.Parse(Result.Text);
            Result.Text = "";
            _operateur = 2;
        }
        private void multiply(object sender, RoutedEventArgs e)
        {
            _result = int.Parse(Result.Text);
            Result.Text = "";
            _operateur = 3;
        }
        private void divide(object sender, RoutedEventArgs e)
        {
            _result = int.Parse(Result.Text);
            Result.Text = "";
            _operateur = 4;
        }
        private void Calcul(object sender, RoutedEventArgs e)
        {
            _saisie = int.Parse(Result.Text);

            if(_operateur== 1) // somme
            {
                _calcul = _result + _saisie;
                Result.Text = _calcul.ToString();
            }
            if (_operateur == 2) // soustraction
            {
                _calcul = _result - _saisie;
                Result.Text = _calcul.ToString();
            }
            if (_operateur == 3) // multiplication
            {
                _calcul = _result * _saisie;
                Result.Text = _calcul.ToString();
            }
            if (_operateur == 4) // division
            {
                _calcul = _result / _saisie;
                Result.Text = _calcul.ToString();
            }
        }

        private void Reset(object sender, RoutedEventArgs e)
        {
            _result= 0;
            Result.Text = "";
            _operateur = 0;
        }

        private void dell(object sender, RoutedEventArgs e)
        {
            _tailleAffichage = Result.Text.Length;
            Result.Text = Result.Text.Substring(0, _tailleAffichage - 1);
        }

    }
}
