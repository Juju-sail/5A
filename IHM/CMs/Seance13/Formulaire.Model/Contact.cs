using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulaire
{
    public class Contact
    {
        // En C#, on appelle cette syntaxe [..] un 'attribut'
        // En Java, on a l'équivalent avec les 'annotations' @..

        [Key] // Dénote la clé primaire
        public int Id { get; set; }

        public string Nom { get; set; } = "";

        // Equivaut à :
        //
        // private string _nom = "";
        // 
        // public string Nom
        // {
        //     get { return _nom; }
        //     set { _nom = null; }
        // }

        public string Prenom { get; set; } = "";
    }
}
