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
using Microsoft.Web.WebView2.Core;

namespace Navigateur_web
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ModelViewURL _c;
        public MainWindow()
        {
            InitializeComponent();

            _c = new ModelViewURL();
            DataContext = _c;
        }



        private void ButtonGo_Click(object sender, RoutedEventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.Navigate(_c.CurrentURL); // Recupère ce qui est tapé dans la barre d'adresse et s'y rend
            }
        }

        private void webView_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e) // Appel via .xaml : NavigationCompleted = "blabalba";
        {
            _c.CurrentURL = webView.Source.ToString(); // Va dans element webView et recupère l'element Source. (Et on le met dans la variable affichée dans ComboBox)
        }
    }
}
