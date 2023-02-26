using MusicLibrary.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Model
{
    public static class AlbumTracks
    {
        //Fonction en + pour récupérer les albums et les chansons de la base de données
        public static ObservableCollection<Album> albums { get; set; } = new ObservableCollection<Album>();

    }
}
