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

namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Contact _c;

        public MainWindow()
        {
            InitializeComponent();

            _c = new Contact();
            DataContext = _c; // DataContext est une propriété héritée
                              // Définit l'objet partagé avec XAML 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Bonjour {_c.PrenomNom}");
        }
    }

    public class Contact
    {
        public string Nom { get; set; } = string.Empty;

        // Equivalent :
        //
        // private string _nom = string.Empty;
        // 
        // public string Nom
        // {
        //     get { return _nom; }
        //     set { _nom = value; }
        // }

        public string Prenom { get; set; } = string.Empty;

        public string PrenomNom
        {
            get { return $"{Prenom} {Nom}"; }
        }
    }
}
