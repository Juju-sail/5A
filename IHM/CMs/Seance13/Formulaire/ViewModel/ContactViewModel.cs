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

        // Ajout d'un contact en BD
        public ContactViewModel()
        {
            _model = new Contact();
        }

        // Import d'un contact existant en BD
        public ContactViewModel(Contact model)
        {
            _model = model;
        }

        public Contact Model
        {
            get { return _model; }
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
