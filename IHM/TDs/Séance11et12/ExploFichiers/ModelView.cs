using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploFichiers
{
    
    internal class ModelView : INotifyPropertyChanged
    {
        

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyChemin)
        {
            // Déclenche l'évènement PropertyChanged.
            if (PropertyChanged != null) // Si l'évènement a au moins un abonné
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyChemin));
            }
        }

    }
}
