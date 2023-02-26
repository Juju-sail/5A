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

namespace Formulaire
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ContactViewModel _c;

        public MainWindow()
        {
            InitializeComponent();

            _c = new ContactViewModel();
            DataContext = _c; // DataContext est une propriété héritée
                              // Définit l'objet partagé avec XAML 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _lb.Items.Add(_c);

            // Prépare le prochain ajout :
            _c = new ContactViewModel();
            DataContext = _c;
        }
    }
}
