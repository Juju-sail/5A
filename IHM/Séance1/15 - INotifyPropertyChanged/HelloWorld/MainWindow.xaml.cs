using System;
using System.Collections.Generic;
using System.ComponentModel;
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

    // WPF reconnaît l'interface INotifyPropertyChanged et s'abonne à l'évènement PropertyChanged
    public class Contact : INotifyPropertyChanged
    {
        // Evènement déclenché lorsqu'une propriété change de valeur
        public event PropertyChangedEventHandler? PropertyChanged;

        private string _nom = "Gogh";
        
        public string Nom
        {
            get { return _nom; }
            set 
            {
                _nom = value;

                // Déclenche l'évènement PropertyChanged.
                if (PropertyChanged != null) // Si l'évènement a au moins un abonné
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Nom"));
                    PropertyChanged(this, new PropertyChangedEventArgs("PrenomNom"));
                }
            }
        }

        private string _prenom = "Van";

        public string Prenom
        {
            get { return _prenom; }
            set
            {
                _prenom = value;

                // Déclenche l'évènement PropertyChanged.
                if (PropertyChanged != null) // Si l'évènement a au moins un abonné
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Prenom"));
                    PropertyChanged(this, new PropertyChangedEventArgs("PrenomNom"));
                }
            }
        }

        public string PrenomNom
        {
            get { return $"{Prenom} {Nom}"; }
        }
    }
}
