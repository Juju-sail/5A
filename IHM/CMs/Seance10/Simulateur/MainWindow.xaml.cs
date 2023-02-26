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

namespace Simulateur
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TimeSpan _lastRenderingTime; // TimeSpan représente une durée.

        public MainWindow()
        {
            InitializeComponent();

            _lastRenderingTime = TimeSpan.Zero;
            CompositionTarget.Rendering += CompositionTarget_Rendering;
        }

        // Déclenché à chaque rafraîchissement de la fenêtre (60 Hz)
        private void CompositionTarget_Rendering(object? sender, EventArgs e)
        {
            // Etrangeté de .NET : cet évènement porte un paramètre avec un mauvais type
            RenderingEventArgs args = (RenderingEventArgs)e;

            if (_lastRenderingTime != TimeSpan.Zero)
            {
                TimeSpan delta = args.RenderingTime - _lastRenderingTime;

                double freq = 1.0 / delta.TotalSeconds;
                Title = $"{freq} Hz";
            }

            _lastRenderingTime = args.RenderingTime;
        }
    }
}
