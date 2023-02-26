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
        private readonly Contact _model;

        public ContactViewModel()
        {
            _model = new Contact();
        }

        public string Nom
        {
            get { return _model.Nom; }
            set
            {
                _model.Nom = value;
                OnPropertyChanged(nameof(Nom));
                OnPropertyChanged(nameof(PrenomNom));
            }
        }

        public string Prenom
        {
            get { return _model.Prenom; }
            set
            {
                _model.Prenom = value;
                OnPropertyChanged(nameof(Prenom));
                OnPropertyChanged(nameof(PrenomNom));
            }
        }

        public string PrenomNom
        {
            get { return $"{_model.Prenom} {_model.Nom}"; }
        }

        public override string ToString()
        {
            return PrenomNom;
        }
    }
}
