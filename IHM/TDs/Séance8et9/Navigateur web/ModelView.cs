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
        private String _currentURL = "default";
        public String CurrentURL{
            get { return _currentURL; }
            set {
            _currentURL= value;

                if(PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("CurrentURL"));

                }
            }
        }
    }
}
