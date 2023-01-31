using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploFichiers
{
    internal class ModelViewChemin : ModelView
    {
        private System.IO.DirectoryInfo _chemin = new System.IO.DirectoryInfo(@"C:\Users\julie\Documents\PolytechNancy");

        public System.IO.DirectoryInfo chemin
        {
            get { return _chemin; }
            set { 
                _chemin = value; 
                OnPropertyChanged(nameof(chemin));
            
            }
        }
    }
}
