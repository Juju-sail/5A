using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulaire
{
    public class ContactViewModel : ViewModelBase
    {
        private string _nom    = "Gogh";
        private string _prenom = "Van";

        public string Nom
        {
            get { return _nom; }
            set
            {
                _nom = value;
                OnPropertyChanged(nameof(Nom));
                OnPropertyChanged(nameof(PrenomNom));
            }
        }

        public string Prenom
        {
            get { return _prenom; }
            set
            {
                _prenom = value;
                OnPropertyChanged(nameof(Prenom));
                OnPropertyChanged(nameof(PrenomNom));
            }
        }

        public string PrenomNom
        {
            get { return $"{Prenom} {Nom}"; }
        }

        public override string ToString()
        {
            return PrenomNom;
        }
    }
}
