using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
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

namespace ExploFichiers
{
    public partial class MainWindow : Window
    {
        // System.IO.DirectoryInfo _chemin = new System.IO.DirectoryInfo(@"C:\Users\julie\Documents\PolytechNancy");
        private readonly ModelViewChemin _c;
        public MainWindow()
        {
            InitializeComponent();
            _c = new ModelViewChemin();
            DataContext= _c;

            cheminCourant.Text = _c.ToString();

            
            System.IO.DirectoryInfo[] dirInfos = _c.chemin.GetDirectories("*.*");

            foreach (System.IO.DirectoryInfo d in dirInfos)
            {
                sousDir.Text = d.Name;
            }



        }

        private void Return(object sender, RoutedEventArgs e)
        {
            String[] splitChemin = _c.chemin.ToString().Split("\\");

            splitChemin = splitChemin.SkipLast(1).ToArray();

            String newChemin = string.Join("\\", splitChemin);

            _c.chemin = new System.IO.DirectoryInfo(newChemin);

        }
    }
}
