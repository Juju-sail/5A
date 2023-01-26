using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulaire
{
    public class Contact
    {
        public string Nom { get; set; } = "Gogh";

        // Raccourci pour :
        //
        // private string _nom = "Gogh";
        // 
        // public string Nom
        // {
        //     get { return _nom; }
        //     set { _nom = value; }
        // }

        // On aurait pu utiliser un simple champ :
        //
        // public string Nom = "Gogh";

        public string Prenom { get; set; } = "Van";
    }
}
