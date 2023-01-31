using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigateur_web
{
    
    internal class ModelView : INotifyPropertyChanged
    {
        

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyURL)
        {
            // Déclenche l'évènement PropertyChanged.
            if (PropertyChanged != null) // Si l'évènement a au moins un abonné
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyURL));
            }
        }

    }
}
