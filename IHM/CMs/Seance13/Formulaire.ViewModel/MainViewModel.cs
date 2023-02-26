﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Formulaire
{
    public class MainViewModel : ViewModelBase
    {
        // ObservableCollection<> = List<> + Notification de l'IU à chaque modification.

        private readonly                        AnnuaireContext _bd;
        private readonly ObservableCollection<ContactViewModel> _contacts;
        private                                ContactViewModel _nouveau;
        private                               ContactViewModel? _selection;

        public MainViewModel(AnnuaireContext bd)
        {
            _bd        = bd;
            _contacts  = new ObservableCollection<ContactViewModel>();
            _nouveau   = new ContactViewModel();
            _selection = null;

            // Import des contacts existants en BD.
            foreach (Contact c in _bd.Contacts)
            {
                _contacts.Add(new ContactViewModel(c));
            }
        }

        // Encapsulation dans une collection en lecture seule.
        public ReadOnlyObservableCollection<ContactViewModel> Contacts
        {
            get { return new ReadOnlyObservableCollection<ContactViewModel>(_contacts); }
        }

        public ContactViewModel Nouveau
        {
            get { return _nouveau; }
        }

        public ContactViewModel? Selection
        {
            get { return _selection; }
            set
            {
                _selection = value;
                OnPropertyChanged(nameof(Selection));
            }
        }

        public ICommand AjoutCommand
        {
            get { return new RelayCommand(Ajout); }
        }

        public void Ajout()
        {
            _bd.Contacts.Add(_nouveau.Model); // Ecriture BD.
            _contacts.Add(_nouveau);
            Selection = _nouveau;

            // Prépare le prochain ajout :
            _nouveau = new ContactViewModel();
            OnPropertyChanged(nameof(Nouveau));
        }

        public ICommand SuppressionCommand
        {
            get { return new RelayCommand(Suppression); }
        }

        public void Suppression()
        {
            if (_selection != null)
            {
                _bd.Contacts.Remove(_selection.Model); // Ecriture BD.
                _contacts.Remove(_selection);
                Selection = null;
            }
        }
    }
}