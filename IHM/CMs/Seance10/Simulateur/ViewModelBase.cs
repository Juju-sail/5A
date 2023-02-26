using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulateur
{
    // WPF reconnaît l'interface INotifyPropertyChanged et s'abonne à l'évènement PropertyChanged
    public class ViewModelBase : INotifyPropertyChanged
    {
        // Evènement déclenché lorsqu'une propriété change de valeur
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            // Déclenche l'évènement PropertyChanged.
            if (PropertyChanged != null) // Si l'évènement a au moins un abonné
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
