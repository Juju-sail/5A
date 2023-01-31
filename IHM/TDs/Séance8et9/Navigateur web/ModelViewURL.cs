using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigateur_web
{
    internal class ModelViewURL : ModelView
    {
        private String _currentURL = "default URL";
        public String CurrentURL
        {
            get { return _currentURL; }
            set
            {
                _currentURL = value;
                OnPropertyChanged(nameof(CurrentURL));
            }
        }
    }
}
