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
        private MainViewModel _vm;

        public MainWindow()
        {
            InitializeComponent();

            _vm = new MainViewModel();
            DataContext = _vm; // DataContext est une propriété héritée
                               // Définit l'objet partagé avec XAML 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _vm.Contacts.Add(_vm.Nouveau);

            // Prépare le prochain ajout :
            _vm.Nouveau = new ContactViewModel();
        }
    }
}
