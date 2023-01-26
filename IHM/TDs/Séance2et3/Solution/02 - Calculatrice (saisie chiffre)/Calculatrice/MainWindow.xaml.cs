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

        public MainWindow()
        {
            InitializeComponent();

            _saisie = "0";
        }

        private void ChiffreButton_Click(object sender, RoutedEventArgs e)
        {
            Button bt      = (Button)sender;
            string chiffre = (string)bt.Content;

            if (_saisie == "0")
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

        }
    }
}
