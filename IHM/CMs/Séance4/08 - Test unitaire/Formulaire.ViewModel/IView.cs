using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulaire
{
    // Fonctions exposées par la vue à la vue-modèle
    public interface IView
    {
        void Popup(string message);

        void Affiche(ContactViewModel c);
    }
}
