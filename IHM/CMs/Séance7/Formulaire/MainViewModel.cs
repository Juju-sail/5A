using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulaire
{
    public class MainViewModel : ViewModelBase
    {
        // ObservableCollection<> = List<> + Notification de l'IU à chaque modification.

        private readonly ObservableCollection<ContactViewModel> _contacts;
        private                                ContactViewModel _nouveau;

        public MainViewModel()
        {
            _contacts = new ObservableCollection<ContactViewModel>();
            _nouveau  = new ContactViewModel();
        }

        public ObservableCollection<ContactViewModel> Contacts
        {
            get { return _contacts; }
        }

        public ContactViewModel Nouveau
        {
            get { return _nouveau; }
            set 
            { 
                _nouveau = value;
                OnPropertyChanged(nameof(Nouveau));
            }
        }
    }
}
